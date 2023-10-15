using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NWCProject.Models;
using NWCProject.ViewModels;
namespace NWCProject.Repositories
{
    public class SubscriptionRepository : GeneralRepository<NWC_Subscription_File>
    {
      
        EstateTypesRepository estateTypesRepository;
        
        public SubscriptionRepository(NwcDbContext nwcDbContext, EstateTypesRepository estateTypesRepository = null) : base(nwcDbContext)
        {
            
            this.estateTypesRepository = estateTypesRepository;
        }


        public void AddSubscription(SubscriptionEditViewModel ViewModel) {

          var Model= ViewModel.ToModel();
          base.Add(Model);
        
        }
        public virtual   NWC_Subscription_File GetBySubscriptionNo(char SubscriptionNo) {
            if (SubscriptionNo != '\0' || !Char.IsWhiteSpace(SubscriptionNo))
            {
                var query = base.GetWithRelatedEntity(i => i.Subscription_File_No == SubscriptionNo, "Unit_Type", "subscriber").FirstOrDefault();
                if (query != null)
                {

                    return query;

                }
            }
            return null;
           


        }


       
        public List<SubscriptionViewModel> GetSubscriptionList()
        {
            var SubscriptionList = base.GetWithRelatedEntity(i => true,  "Unit_Type", "subscriber");
            if (SubscriptionList.FirstOrDefault() != null)

            {
                return SubscriptionList.Select(i => new SubscriptionViewModel()
                {
                    Subscription_File_No=i.Subscription_File_No,
                    SubscriberId=i.SubscriberId,
                    Unit_Number=i.Unit_Number,
                    Last_Reading_Meter=i.Last_Reading_Meter,
                    Is_There_Sanitaion=i.Is_There_Sanitaion,
                    Name_Estate=i.Unit_Type.Name,
                    Mobile=i.subscriber.Mobile,
                    Name=i.subscriber.Name
                }).ToList();
            }

            return null;


        }







    }
}
