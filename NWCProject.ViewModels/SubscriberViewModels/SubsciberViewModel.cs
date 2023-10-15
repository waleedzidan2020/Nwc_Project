using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.ViewModels
{
    public class SubsciberViewModel
    {
        [Required]
        public char Id { get; set; }
        [Required]

        public string Name { get; set; }
      
        public string City { get; set; }
        public string Area { get; set; }
  
        public string Mobile { get; set; }
       public int NumberOfSubscription { get; set; }
    }
}
