using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NWCProject.Models;
using NWCProject.ViewModels;

namespace NWCProject.Repositories
{
    public class EstateTypesRepository : GeneralRepository<NWC_Rreal_Estate_Types>
    {
        public EstateTypesRepository(NwcDbContext nwcDbContext) : base(nwcDbContext)
        {

        }

        public virtual bool AddEstateType(EstateTypeEditViewModel estateTypeEdit)
        {

            var EstateType = estateTypeEdit.ToModel();
            if (EstateType != null)
            {
                var Estatemodel = base.GetOne(i => i.Code == estateTypeEdit.Code).SingleOrDefault();
                if (Estatemodel == null)
                {
                    base.Add(EstateType);
                    return true;
                }

            }

            return false;



        }

        public async Task<List<EstateViewModel>> GetListEstateTypes()
        {

            var result = await base.GetList();
          


            return result.Select(i => new EstateViewModel
            {

                Code = i.Code,
                Name = i.Name



            }).ToList();

        }

        public static int Sum(int a , int b) {

            return a + b;
        
        }



    }
}
