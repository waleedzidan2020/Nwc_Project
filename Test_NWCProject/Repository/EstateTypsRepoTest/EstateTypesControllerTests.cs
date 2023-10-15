

using Castle.Core.Logging;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NWCProject.MVC.Controllers;
using NWCProject.Repositories;
using NWCProject.ViewModels;
using Serilog.Core;
using System.Reflection;
using Xunit.Sdk;

namespace Test_NWCProject.Repository.EstateTypsRepoTest
{
    public class EstateTypesControllerTests
    {
        private readonly EstateTypesRepository _estateTypesRepository;
        private ILogger<EstateTypesController> _logger;

        public EstateTypesControllerTests()
        {
            _estateTypesRepository = A.Fake<EstateTypesRepository>();
            _logger = A.Fake<ILogger<EstateTypesController>>();

        }


        [Fact]
        public void EstateTypesController_Add_ReturnView()
        {

            //Arrange 
            var model = A.Fake<EstateTypeEditViewModel>();
            A.CallTo(() => _estateTypesRepository.AddEstateType(model)).Returns(true);
            var objController=  new EstateTypesController(_estateTypesRepository, _logger);
            
            //Act 
            var result=  objController.Add(model);
           
            //Assert
            result.Should().BeOfType<ViewResult>();


        }
        


    }
}
