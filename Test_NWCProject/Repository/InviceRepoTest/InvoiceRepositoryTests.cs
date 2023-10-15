

using FakeItEasy;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using NWCProject;
using NWCProject.Models;
using NWCProject.Repositories;
using NWCProject.Repositories.HelperMethods;
using NWCProject.ViewModels;

namespace Test_NWCProject.Repository.InviceRepoTest
{
    public class InvoiceRepositoryTests
    {
        private SubscriberRepository _subscriberRepository;
        private SubscriptionRepository _subscriptionRepository;
        private SliceValuesRepository _sliceValuesRepository;
        private InvoiceCalculateHelper _invoiceCalculateHelper;
        public InvoiceRepositoryTests()
        {
            _subscriberRepository = A.Fake<SubscriberRepository>();
            _subscriptionRepository = A.Fake<SubscriptionRepository>();
            _sliceValuesRepository = A.Fake<SliceValuesRepository>();
            _invoiceCalculateHelper = A.Fake<InvoiceCalculateHelper>();

        }
        private async Task<NwcDbContext> GetDbContext()
        {

            var Oprtion = new DbContextOptionsBuilder<NwcDbContext>().
             UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var dbcontext = new NwcDbContext(Oprtion);

            var IsCreated = await dbcontext.Database.EnsureCreatedAsync();

            if (IsCreated)
            {

                await dbcontext.AddAsync(new NWC_Subscriber_File()
                {
                    Name = "AmgadAli",
                    City = "Aswan",
                    Area = "alakkad",
                    Mobile = "01148225295",
                    Id = '2'



                });
                await dbcontext.AddAsync(new NWC_Subscription_File()
                {
                    SubscriberId = '2',
                    Is_There_Sanitaion = true,
                    Subscription_File_No = 'a',
                    Unit_Number = 5,
                    Unit_TypeCode = '1'



                });



            }
            await dbcontext.SaveChangesAsync();

            return IsCreated == true ? dbcontext : new NwcDbContext(Oprtion);
        }

        [Fact]
        public async void InvoicesRepository_CalculateInvoice_ReturnInvoiceEditViewModel()
        {

            //Arrange 
            var Db = await GetDbContext();
           
            var obj = new InvoicesRepository(Db, _subscriberRepository, _subscriptionRepository, _sliceValuesRepository, _invoiceCalculateHelper);
            var model = A.Fake<InvoiceEditViewModel>();
            char Id = 'a';
            var subscriptionObject = Db.nWC_Subscription_Files.Where(i => i.Subscription_File_No == Id).FirstOrDefault();


            A.CallTo(() => _invoiceCalculateHelper.AddSomeInformationForInvoice(model, subscriptionObject)).Returns(model);
            A.CallTo(() => _subscriptionRepository.GetBySubscriptionNo(Id)).Returns(new NWC_Subscription_File()
            {
                SubscriberId = '2',
                Is_There_Sanitaion = true,
                Subscription_File_No = 'a',
                Unit_Number = 5,
                Unit_TypeCode = '1'



            });
            A.CallTo(() => _invoiceCalculateHelper.Calculation_Amount_Consumption(model.Current_Consumption_Amount, model.Previous_Consumption_Amount)).Returns(10);



            int SizeOfCard = 10;
            A.CallTo(() => _sliceValuesRepository.Calculate_Water_Price(model.Amount_Consumption, SizeOfCard)).Returns(10);
            A.CallTo(() => _sliceValuesRepository.Calculate_Sanitation_Price(model.Amount_Consumption, SizeOfCard)).Returns(10);
            A.CallTo(() => _sliceValuesRepository.Calculate_Sanitation_Price(model.Amount_Consumption, SizeOfCard)).Returns(10);
            A.CallTo(() => _sliceValuesRepository.Calculate_Sanitation_Price(model.Amount_Consumption, SizeOfCard)).Returns(10);
            A.CallTo(() => _sliceValuesRepository.Calculate_Sanitation_Price(model.Amount_Consumption, SizeOfCard)).Returns(10);

            //Act
            var result = obj.CalculateInvoice(model);
         
            //ASSERT
             
            result.Should().NotBeNull();
            result.Should().BeOfType<InvoiceEditViewModel>();



        }

    }
}
