using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Models
{
    public class NWC_Rreal_Estate_Types
    {
        public char  Code { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Reasons { get; set; } = string.Empty;
        public List<NWC_Subscriber_File> Subscibers { get; set; }
        public NWC_Invoices Invoice { get; set; }




    }
}
