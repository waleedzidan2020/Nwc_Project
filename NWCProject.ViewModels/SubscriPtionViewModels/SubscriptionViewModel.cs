using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.ViewModels
{
    public class SubscriptionViewModel
    {
        public char Subscription_File_No { get; set; }  
        public virtual char SubscriberId { get; set; }
        public string Name_Estate { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Unit_Number { get; set; }
        public bool Is_There_Sanitaion { get; set; } = true;
        public int Last_Reading_Meter { get; set; }
       
       
    }
}
