using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NWCProject.Models;

namespace NWCProject.ViewModels
{
    public static class InvoiceExtension {



        public static InvoiceViewModel FromEditToViewModel(this InvoiceEditViewModel EditView) {


            return new InvoiceViewModel() {
            
                 
                 Estate_Types_Code=EditView.Estate_Types_Code,
                 Amount_Consumption=EditView.Amount_Consumption,
                 Current_Consumption_Amount=EditView.Current_Consumption_Amount,
                 IsCalculated=EditView.IsCalculated,
                 Invoices_Date=EditView.Invoices_Date,
                 Invoices_From=EditView.Invoices_From,
                 Invoices_To=EditView.Invoices_To,
                 Invoice_Number=EditView.Invoice_Number,
                 Invoice_Year=EditView.Invoice_Year,
                 Is_There_Sanitaion=EditView.Is_There_Sanitaion,
                 Previous_Consumption_Amount=EditView.Previous_Consumption_Amount,
                 Service_Fee=EditView.Service_Fee,
                 Subscription_No=EditView.Subscription_No,
                 Tax_Rate=EditView.Tax_Rate,
                 Tax_Value=EditView.Tax_Value,
                 Total_Bill=EditView.Total_Bill,
                 Total_Invoice=EditView.Total_Invoice,
                 Total_Reasons=EditView.Total_Reasons,
                 Units_Number=EditView.Units_Number,
                 Wastewater_Consumption_Value=EditView.Wastewater_Consumption_Value,
                 Water_Consumption_Value=EditView.Water_Consumption_Value,
                 SubscriberName=EditView.SubscriberName,
                 Subscriber_Code=EditView.Subscriber_Code
            
            
            };




        }


        public static InvoiceViewModel ToViewModel(this NWC_Invoices model)
        {

            return new InvoiceViewModel() {


                Subscriber_Code = model.Subscriber_Code,
                Estate_Types_Code = model.Estate_Types_Code,
                Amount_Consumption = model.Amount_Consumption,
                Current_Consumption_Amount = model.Current_Consumption_Amount,
                Invoices_Date = model.Invoices_Date,
                Invoices_From = model.Invoices_From,
                Invoices_To = model.Invoices_To,
                Invoice_Number = model.Invoice_Number,
                Service_Fee = model.Service_Fee,
                Invoice_Year = model.Invoice_Year,
                Is_There_Sanitaion = model.Is_There_Sanitaion,
                Previous_Consumption_Amount = model.Previous_Consumption_Amount,
                Subscription_No = model.Subscription_No,
                Tax_Value = model.Tax_Value,
                Tax_Rate = model.Tax_Rate,
                Total_Bill = model.Total_Bill,
                Total_Invoice = model.Total_Bill,
                Wastewater_Consumption_Value = model.Wastewater_Consumption_Value,
                Water_Consumption_Value = model.Water_Consumption_Value,
                SubscriberName=model.Subscribers.Name
                



            };





        }

        public static NWC_Invoices  ToModel(this InvoiceEditViewModel EditView)
        {



            return new NWC_Invoices() {

                Subscriber_Code = EditView.Subscriber_Code,
                Estate_Types_Code=EditView.Estate_Types_Code,
                Amount_Consumption=EditView.Amount_Consumption,
                Current_Consumption_Amount=EditView.Current_Consumption_Amount,
                Invoices_Date=EditView.Invoices_Date,
                Invoices_From=EditView.Invoices_From,
                Invoices_To=EditView.Invoices_To,
                Invoice_Number=EditView.Invoice_Number,
                Service_Fee=EditView.Service_Fee,
                Invoice_Year=EditView.Invoice_Year,
                Is_There_Sanitaion=EditView.Is_There_Sanitaion,
                Previous_Consumption_Amount=EditView.Previous_Consumption_Amount,
                Subscription_No=EditView.Subscription_No,
                Tax_Value=EditView.Tax_Value,
                Tax_Rate=EditView.Tax_Rate,
                Total_Bill=EditView.Total_Bill,
                Total_Invoice=EditView.Total_Bill,
                Wastewater_Consumption_Value=EditView.Wastewater_Consumption_Value,
                Water_Consumption_Value=EditView.Water_Consumption_Value
                
                
            };



        }





    }
    public class InvoiceViewModel
    {
        public char Subscriber_Code { get; set; }
        public string SubscriberName { get; set; } = string.Empty;
        public string Subsciber_Mobile_Number { get; set; } = string.Empty; 
        public char Invoice_Number { get; set; } //by create random Guid 

        public char Estate_Types_Code { get; set; }
        public string Estate_Name { get; set; } = string.Empty;


        public char Subscription_No { get; set; }
        public int Last_Reading_Meter { get; set; }

        public char Invoice_Year { get; set; } = '2';

        public DateTime Invoices_Date { get; set; }
 
        public DateTime Invoices_From { get; set; }
        public DateTime Invoices_To { get; set; } //calculate
        public int Previous_Consumption_Amount { get; set; }
 
        public int Current_Consumption_Amount { get; set; }

        public decimal Service_Fee { get; set; }

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
  




    }
}
