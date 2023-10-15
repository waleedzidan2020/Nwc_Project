using Microsoft.AspNetCore.Mvc;
using NWCProject.Repositories;
using NWCProject.ViewModels;

namespace NWCProject.MVC.Controllers
{
    public class SubscriberController : Controller
    {
        public SubscriberRepository subscriberRepo;

        public SubscriberController(SubscriberRepository subscriberRepo)
        {
            this.subscriberRepo = subscriberRepo;
        }
        [HttpGet]
        public IActionResult Add()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Add(SubscriberEditViewModel sub)
        {
            if (ModelState.IsValid)
            {
               var IsAdded = subscriberRepo.AddSubsciber(sub);
            }
            var modelErrors = new List<string>();
            foreach (var modelState in ModelState.Values)
            {
                foreach (var modelError in modelState.Errors)
                {
                    modelErrors.Add(modelError.ErrorMessage);
                }
            }
                return View(sub);
        }

        [HttpGet]
        public async Task<IActionResult> Get() {

          var rest=  await subscriberRepo.GetList();
   

            return View(rest);
        
        }
    }
}
