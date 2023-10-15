using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Models
{
    public class NWC_Invoices
    {
        public char Invoice_Number { get; set; }
        [ForeignKey("NWC_Subscriber_File")]
        public char Subscriber_Code { get; set; }
        [ForeignKey("NWC_Rreal_Estate_Types")]
        public char Estate_Types_Code { get; set; }
        [ForeignKey("NWC_Subscription_File")]
        public char Subscription_No { get; set; }

        public char Invoice_Year { get; set; }
        public DateTime Invoices_Date { get; set; }
        public DateTime Invoices_From { get; set; }
        public DateTime Invoices_To { get; set; }
        public int Previous_Consumption_Amount { get; set; }
        public int Current_Consumption_Amount { get; set; }
        public decimal Service_Fee { get; set; }
        public decimal Tax_Rate { get; set; }
        public bool Is_There_Sanitaion { get; set; } = true;
        public int Amount_Consumption { get; set; }
        public decimal Water_Consumption_Value { get; set; }
        public decimal Wastewater_Consumption_Value { get; set; }

        public decimal Total_Invoice { get; set; }
        public decimal Tax_Value { get; set; }
        public decimal Total_Bill { get; set; }
        public string Total_Reasons { get; set; } = string.Empty;
       public NWC_Subscriber_File Subscribers { get; set; }
       public NWC_Rreal_Estate_Types Units_Types { get; set; }
       public NWC_Subscription_File subscriptions { get; set; }

    }
}
