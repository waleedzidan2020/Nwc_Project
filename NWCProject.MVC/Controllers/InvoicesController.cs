using Microsoft.AspNetCore.Mvc;
using NWCProject.ViewModels;
using NWCProject.Repositories;

namespace NWCProject.MVC.Controllers
{

    public class InvoicesController : Controller
    {
        InvoicesRepository invoicesRepo;
       

        public InvoicesController(InvoicesRepository invoicesRepo)
        {
            this.invoicesRepo = invoicesRepo;

        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

     


        [HttpPost]
        public async  Task<IActionResult> Add(InvoiceEditViewModel model)
        {
          

            if (ModelState.IsValid)
            {
                if (!model.IsCalculated)
                {
                    
                    var ResultViewModel = invoicesRepo.CalculateInvoice(model);
                    ViewData["ViewModel"] = ResultViewModel.FromEditToViewModel();
                    return View(ResultViewModel);

                }
                else {

                 var IsFind= await invoicesRepo.AddInvoice(model);
                    if (IsFind.Status)
                    {


                        RedirectToAction("Index", "Home");
                    }
                    return View(model);
                    
                
                }


            }
            return View();
        }


        [HttpGet]
        public IActionResult GetList()
        {
           var Results= invoicesRepo.GetInvoicesList();
            if (Results != null)
            {

                return View(Results);

            }
            return View();
        }




    }
}
