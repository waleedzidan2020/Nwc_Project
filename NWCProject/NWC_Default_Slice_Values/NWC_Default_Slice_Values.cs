using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Models
{
    public class NWC_Default_Slice_Values
    {
        public char Slice_Code { get; set; }
        public string? Slice_Name { get; set; }
        public decimal Water_Price { get; set; }
        public int Amount_of_Consumption { get; set; }
        public decimal Sanitation_Price { get; set; }
        public string Reasons { get; set; } = string.Empty;
       
          
    
    }
}
