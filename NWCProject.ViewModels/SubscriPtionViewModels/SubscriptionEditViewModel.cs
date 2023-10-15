using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NWCProject.Models;


namespace NWCProject.ViewModels
{
    public static class SubscriptionExtension
    {

        public static NWC_Subscription_File ToModel(this SubscriptionEditViewModel subEdit)
        {

            return new NWC_Subscription_File()
            {
                Subscription_File_No = Guid.NewGuid().ToString().FirstOrDefault(),
                Last_Reading_Meter = subEdit.lastReading,
                Is_There_Sanitaion = bool.Parse(subEdit.Is_Sanitation),
                Unit_Number=subEdit.NumberOfUnits,
                Unit_TypeCode=char.Parse(subEdit.UnitCode),
                SubscriberId=char.Parse(subEdit.Id)
               
                


            };



        }


    }

    public class SubscriptionEditViewModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public int NumberOfUnits { get; set; }
        [Required]
        public int lastReading { get; set; }
        [Required]
        public string  UnitCode { get; set; }
        [Required]
        public string Is_Sanitation { get; set; }

        public static List<SelectListItem> TrueOfFlase = new()
        {
            new SelectListItem()
            {
                Text = "نعم",
                Value = true.ToString()


            },
            new SelectListItem()
            {
                Text = "لا",
                Value = false.ToString()


            }


        };
       

    }
}
