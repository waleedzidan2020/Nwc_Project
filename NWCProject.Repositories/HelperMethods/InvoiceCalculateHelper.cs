using NWCProject.Models;
using NWCProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Repositories.HelperMethods
{
    public class InvoiceCalculateHelper
    {
        public virtual int Calculation_Amount_Consumption(int Current_Consumption_Amount, int Last_Reading_Meter)
        {
            if (Current_Consumption_Amount >= Last_Reading_Meter)
                return Current_Consumption_Amount - Last_Reading_Meter;


            return 0;


        }
        public virtual   InvoiceEditViewModel AddSomeInformationForInvoice(InvoiceEditViewModel EditViewModel, NWC_Subscription_File Model)
        {

            if (EditViewModel != null && Model != null)
            {

                EditViewModel.Invoice_Number = Guid.NewGuid().ToString().FirstOrDefault();
                EditViewModel.Subscriber_Code = Model.SubscriberId;
                EditViewModel.SubscriberName = Model.subscriber.Name;
                EditViewModel.Estate_Types_Code = Model.Unit_TypeCode;
                EditViewModel.Is_There_Sanitaion = Model.Is_There_Sanitaion;
                EditViewModel.Invoices_To = EditViewModel.Invoices_From.AddMonths(1);

                return EditViewModel;

            }

            return null;




        }

    }
}
