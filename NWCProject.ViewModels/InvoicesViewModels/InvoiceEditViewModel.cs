using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.ViewModels
{
    public class InvoiceEditViewModel
    {

        public char Invoice_Number { get; set; } //by create random Guid 
        public char Subscriber_Code { get; set; }
        public string SubscriberName { get; set; } = string.Empty;
        public char Estate_Types_Code { get; set; }
     

        [Required]
        public char Subscription_No { get; set; }

        public char Invoice_Year { get; set; } = '2';
        [Required]
        public DateTime Invoices_Date { get; set; }
        [Required]
        public DateTime Invoices_From { get; set; }
        public DateTime Invoices_To { get; set; } //calculate
        public int Previous_Consumption_Amount { get; set; }
        [Required]
        public int Current_Consumption_Amount { get; set; }
        [Required]
        public decimal Service_Fee { get; set; }
        [Required]
        public decimal Tax_Rate { get; set; }
        public bool Is_There_Sanitaion { get; set; } = true;
        public int Amount_Consumption { get; set; }
        public decimal Water_Consumption_Value { get; set; }//calculate
        public decimal Wastewater_Consumption_Value { get; set; }//calculate
        public int Units_Number { get; set; }
        public decimal Total_Invoice { get; set; }//calculate
        public decimal Tax_Value { get; set; } //calculate
        public decimal Total_Bill { get; set; }//calculate
        public string Total_Reasons { get; set; } = string.Empty;
        public bool IsCalculated { get; set; } = false;




        //public string ToQueryString()
        //{
        //    var properties = GetType().GetProperties()
        //        .Where(p => p.GetValue(this) != null)
        //        .Select(p => $"{Uri.EscapeDataString(p.Name)}={Uri.EscapeDataString(p.GetValue(this).ToString())}");

        //    return string.Join("&", properties);
        //}

        //    public  Dictionary<string, string> ConvertModelToDictionary()
        //    {
        //        var dictionary = new Dictionary<string, string>();

        //        if (this != null)
        //        {
        //            var properties = this.GetType().GetProperties();

        //            foreach (var property in properties)
        //            {
        //                var value = property.GetValue(this);
        //                dictionary.Add(property.Name,(string)value);
        //            }
        //        }

        //        return dictionary;
        //    }
        //}
    }
}
