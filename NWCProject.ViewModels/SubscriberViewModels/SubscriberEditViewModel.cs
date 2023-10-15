using NWCProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.ViewModels
{
    public  static class SubscriberExtension{

        public static NWC_Subscriber_File ToModel(this SubscriberEditViewModel subEdit) {

            return new NWC_Subscriber_File()
            {
                Name=subEdit.Name,
                Id=subEdit.Id,
                City=subEdit.City,
                Area=subEdit.Area,
                Mobile=subEdit.Mobile



            };
        
        
        
        }
        public static SubsciberViewModel ToViewModel(this NWC_Subscriber_File subEdit)
        {

            return new SubsciberViewModel()
            {
                  
                 Id=subEdit.Id,
                 Name=subEdit.Name,
                 Area=subEdit.Area,
                 City=subEdit.City,
                Mobile=subEdit.Mobile
                 



            };



        }


    }
   
    public class SubscriberEditViewModel
    {
        [Required]
        public char Id { get; set; }
        [Required]
        public string Name { get; set; } 
        [Required]
        public string City { get; set; } 
        [Required]
        public string Area { get; set; } 
        [Required]
        public string Mobile { get; set; } 


    }
}
