using NWCProject.Models;
using NWCProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Repositories
{
    public class SubscriberRepository : GeneralRepository<NWC_Subscriber_File>
    {
        public SubscriptionRepository subscriptionRepo;
        public SubscriberRepository(NwcDbContext nwcDbContext, SubscriptionRepository subscriptionRepo) : base(nwcDbContext)
        {
            this.subscriptionRepo = subscriptionRepo;
        }
        public bool AddSubsciber(SubscriberEditViewModel subscriber) {
           
            if (subscriber != null) {
                
                base.Add(subscriber.ToModel());
                return true;
            
            }
            return false;
       
        
        
        }


        public NWC_Subscriber_File GetById(string id) {
            if (id != null)
            {
                var result = base.GetOne(i => i.Id == char.Parse(id)).FirstOrDefault();
                return result;
            }
         

            return null;
        
        
        
        }


        public async Task<List<SubsciberViewModel>> GetList() {

          var result=  await base.GetList();

           var Query= result.Select(i=>new SubsciberViewModel() {
            
            Id=i.Id,
            Name=i.Name,
            Area=i.Area,
            City=i.City,
            Mobile=i.Mobile,
            NumberOfSubscription= subscriptionRepo.GetOne(I=>I.SubscriberId==i.Id).ToList().Count


            }).ToList();
            return Query;
        
        }

       
    }
}
