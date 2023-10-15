using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Models
{
    public class NWC_Subscriber_File
    {
        public char Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string Resons { get; set; } = string.Empty;
        public List<NWC_Rreal_Estate_Types> Units_Type { get; set; }
        public List<NWC_Invoices> Invoice { get; set; }
    }
}
