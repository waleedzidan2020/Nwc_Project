
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NWCProject.MVC.Controllers;
using NWCProject.Repositories;
using NWCProject.ViewModels;
using Xunit.Abstractions;

namespace Test_NWCProject;

public class UnitTest1
{

    readonly ITestOutputHelper testOutput;
    readonly InvoicesRepository _invoicesRepository;
    InvoicesController _controller;
    public UnitTest1(ITestOutputHelper testOutput)
    {
        _invoicesRepository = A.Fake<InvoicesRepository>();

        this.testOutput = testOutput;
        //SUT
        _controller = new InvoicesController(_invoicesRepository);
    }

    [Fact]

    public  void Invoices_GetList_Should_ReturnView()
    {


        //Arrange
      var result1=  A.Fake<List<InvoiceViewModel>>();
      A.CallTo(() => _invoicesRepository.GetInvoicesList()).Returns(result1);
        //Act
      var result=  _controller.GetList();
        //Assert
        result.Should().BeOfType<ViewResult>();
    


    }

    [Theory(Skip = "Dont run this test case")]
    [ClassData(typeof(EstateTypeTest))]
    public void AddInvoice_Should_ReturnTrue_WhenInvoiceNotExistInDataBase(EstateTypeEditViewModel model)
    {



    }
}
//Arrange
public class EstateTypeTest : TheoryData<EstateTypeEditViewModel>
{

    public EstateTypeTest()
    {
        List<EstateTypeEditViewModel> estateTypeEditViewModels = new() {
        new EstateTypeEditViewModel()
        {
            Name = "villa",
            Code = '2'

        },
        new EstateTypeEditViewModel()
        {
            Name = "villa",
            Code = '9'

        }



        };
        foreach (var item in estateTypeEditViewModels)
        {
            Add(item);
        }

    }

}
