using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NWCProject.Models;

namespace NWCProject.ViewModels
{
    public static class EstateTypeExtension
    {

        public static NWC_Rreal_Estate_Types ToModel(this EstateTypeEditViewModel EstateTypeEdit)
        {

            return new NWC_Rreal_Estate_Types()
            {
               Name= EstateTypeEdit.Name,
               Code=EstateTypeEdit.Code
            };
        }


    }
    public class EstateTypeEditViewModel
    {
        [Required]
        public char Code { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
