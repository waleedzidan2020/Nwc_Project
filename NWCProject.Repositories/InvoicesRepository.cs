
using NWCProject.Models;
using NWCProject.Repositories.HelperMethods;
using NWCProject.ViewModels;

namespace NWCProject.Repositories
{
    public class InvoicesRepository : GeneralRepository<NWC_Invoices>
    {
        public SubscriberRepository subscriberRepo;
        public SubscriptionRepository subscriptionRepo;
        public SliceValuesRepository SliceValuesRepo;
        private NwcDbContext nwcDbContext;
        private InvoiceCalculateHelper calculateHelper;
        public InvoicesRepository(NwcDbContext nwcDbContext, SubscriberRepository subscriberRepo, SubscriptionRepository subscriptionRepo, SliceValuesRepository sliceValuesRepo, InvoiceCalculateHelper calculateHelper) : base(nwcDbContext)
        {
            this.subscriberRepo = subscriberRepo;
            this.subscriptionRepo = subscriptionRepo;
            SliceValuesRepo = sliceValuesRepo;
            this.nwcDbContext = nwcDbContext;
            this.calculateHelper = calculateHelper;
        }

       

        public InvoiceEditViewModel CalculateInvoice(InvoiceEditViewModel model)
        {
            var subscriptionObject = subscriptionRepo.GetBySubscriptionNo(model.Subscription_No);

            if (subscriptionObject != null)
            {
                model.Previous_Consumption_Amount = subscriptionObject.Last_Reading_Meter;
                model.Amount_Consumption = calculateHelper.Calculation_Amount_Consumption(model.Current_Consumption_Amount, model.Previous_Consumption_Amount);
                model.Units_Number = subscriptionObject.Unit_Number;
                int sizeOfcard = subscriptionObject.Unit_Number * 15;
                model.Water_Consumption_Value = SliceValuesRepo.Calculate_Water_Price(model.Amount_Consumption, sizeOfcard);
                model.Wastewater_Consumption_Value = SliceValuesRepo.Calculate_Sanitation_Price(model.Amount_Consumption, sizeOfcard);
                model.Total_Invoice = model.Water_Consumption_Value + model.Wastewater_Consumption_Value;
                model.Tax_Value = model.Total_Invoice * (model.Tax_Rate / 100);
                model.Total_Bill = model.Total_Invoice + model.Tax_Value;
                model.IsCalculated = true;
            }


            if (model.IsCalculated == true)
            {

                var Result = calculateHelper.AddSomeInformationForInvoice(model, subscriptionObject);
                if (Result != null)
                {
                    return Result;
                }

            }


            return model;


        }

        public virtual async Task<ErorrModel> AddInvoice(InvoiceEditViewModel EditViewModel) {
            try {


                var model = await base.AddAsync(EditViewModel.ToModel());
                if (model != null)
                {
                    nwcDbContext.SaveChanges();
                    return new ErorrModel() {
                        Status = true,
                        ErrorMessage="Add Sucsses"
                    
                    
                    };

                }


            } catch (Exception Ex ) {


                
                return new ErorrModel()
                {
                    Status = false,
                    ErrorMessage = Ex.Message


                }; ;

            }
            return new ErorrModel()
            {
                Status = false,
                ErrorMessage="SomeThing Went Wrong"


            };
            
        
        }

      


        public virtual  List<InvoiceViewModel> GetInvoicesList() {

            var List=base.GetWithRelatedEntity(i => true, "Subscribers", "Units_Types", "subscriptions").ToList();
            List<InvoiceViewModel> ListOfInvoices = new();
            foreach (var item in List) {

                ListOfInvoices.Add(item.ToViewModel());                      
            
            }
            if (ListOfInvoices.Count >0) {

                return ListOfInvoices;
            }


            return null;
        
        
        
        
        }



       




    }
}
