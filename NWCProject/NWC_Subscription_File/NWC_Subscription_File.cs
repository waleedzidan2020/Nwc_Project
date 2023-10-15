using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Models
{
    public class NWC_Subscription_File
    {
        public char Subscription_File_No { get; set; }
        [ForeignKey("NWC_Rreal_Estate_Types")]
        public virtual  char Unit_TypeCode { get; set; }
        [ForeignKey("NWC_Subscriber_File")]
        public virtual char SubscriberId { get; set; }
       

        public int Unit_Number { get; set; }
        public bool Is_There_Sanitaion { get; set; } = true;
        public int Last_Reading_Meter { get; set; }
        public string Reasons { get; set; } = string.Empty;
        public NWC_Rreal_Estate_Types Unit_Type { get; set; }
        public NWC_Subscriber_File subscriber { get; set; }
        public NWC_Invoices invoices { get; set; }
       

    }
}
