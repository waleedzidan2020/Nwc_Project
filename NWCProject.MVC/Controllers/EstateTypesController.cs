using Microsoft.AspNetCore.Mvc;
using NWCProject.ViewModels;
using NWCProject.Repositories;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace NWCProject.MVC.Controllers
{
    public class EstateTypesController : Controller
    {
        EstateTypesRepository estateTypesRepository;
        ILogger<EstateTypesController> logger;

        public EstateTypesController(EstateTypesRepository estateTypesRepository, ILogger<EstateTypesController> logger = null)
        {
            this.estateTypesRepository = estateTypesRepository;
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Add()
        {
           
            return View();
        }
      
        [HttpPost]
        public IActionResult Add(EstateTypeEditViewModel model)
        {
           var res= EstateTypesRepository.Sum(5, 5);
            if (ModelState.IsValid && res==10)
            {
                

               var IsAdded= estateTypesRepository.AddEstateType(model);
                if (IsAdded)
                    logger.LogInformation("Done Add Complete");

                return View();



            }
            else {
                foreach (var item in ModelState)
                {
                    if (item.Value.ValidationState ==ModelValidationState.Invalid) {
                        logger.LogInformation($" line 110 {item.Key}:{item.Value.ValidationState}");
                    }

                }
                return View();

            }
     

        }

      
    }
}
