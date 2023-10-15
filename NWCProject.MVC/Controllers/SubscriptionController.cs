using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using NWCProject.Repositories;
using NWCProject.ViewModels;

using System;


namespace NWCProject.MVC.Controllers
{
    public class SubscriptionController : Controller
    {
       private EstateTypesRepository typesRepository;
        private SubscriberRepository subscriberRepo;
        private SubscriptionRepository subscriptionrepo;
        IMemoryCache memory;
        ILogger<SubscriptionController> Logger;


        public SubscriptionController(EstateTypesRepository typesRepository, IMemoryCache memory, SubscriberRepository subscriberRepo, SubscriptionRepository subscriptionrepo, ILogger<SubscriptionController> logger)
        {
            this.typesRepository = typesRepository;
            this.memory = memory;
            this.subscriberRepo = subscriberRepo;
            this.subscriptionrepo = subscriptionrepo;
            Logger = logger;
        }


        private List<SelectListItem> GetListSelectItems(List<EstateViewModel> viewModel) {
           
            List<SelectListItem> selectList = new List<SelectListItem>();
            foreach (var item in viewModel) {

                selectList.Add(new SelectListItem()
                {

                    Text = item.Name,
                    Value = item.Code.ToString()


                }) ;


            }

            return selectList;

        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            

           var CurrentSub= memory.Get("CurrentSubscriber");
            if (CurrentSub != null) {

                ViewData["CurrentSubscriber"] = CurrentSub;
                memory.Remove("CurrentSubscriber");

            }
            var result = await typesRepository.GetListEstateTypes();
            if (result != null)
            {
                var SelectList = GetListSelectItems(result);
                ViewBag.Items = SelectList;
                memory.Set("SelectList", SelectList);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(SubscriptionEditViewModel model)
        {
            if (ModelState.IsValid)
            {

                subscriptionrepo.AddSubscription(model);
                Logger.LogInformation("AddedSuccess");

            }
            else {

            
                Logger.LogInformation("Not Added");



            }

            ViewBag.Items= memory.Get("SelectList");

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Get(string id)
        {
         
          var user=  subscriberRepo.GetById(id);
            if (user != null) 
            memory.Set("CurrentSubscriber", user);

            return RedirectToAction("Add", "Subscription");
        }
        public  IActionResult GetList() {

         var subscriptionList=   subscriptionrepo.GetSubscriptionList();
            if (subscriptionList != null) {

                return View(subscriptionList);
            
            
            }
            return View();



        
        
        
        }
        
    }
}
