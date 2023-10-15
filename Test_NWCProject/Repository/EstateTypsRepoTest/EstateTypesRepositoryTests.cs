

using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using NWCProject;
using NWCProject.Repositories;
using NWCProject.ViewModels;
using Xunit;

namespace Test_NWCProject.Repository.EstateTypsRepoTest
{
    public class EstateTypesRepositoryTests
    {

        private async Task<NwcDbContext> GetDbContext()
        {

            var Oprtion = new DbContextOptionsBuilder<NwcDbContext>().
             UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var dbcontext = new NwcDbContext(Oprtion);

            var IsCreated = await dbcontext.Database.EnsureCreatedAsync();

            await dbcontext.SaveChangesAsync();
            return IsCreated == true ? dbcontext : new NwcDbContext(Oprtion);
        }


        [Fact]
        public async void EstateTypesRepository_AddEstateType_ReturnTrue()
        {

            //Arrange
            var obj = new EstateTypeEditViewModel()
            {
                Name = "Balace",
                Code = '9'

            };
            var Db = await GetDbContext();
            var repo = new EstateTypesRepository(Db);
            //Act
            var result = repo.AddEstateType(obj);



            //assert
            result.Should().BeTrue();


        }

        [Fact]
        public async void EstateTypesRepository_GetListEstateTypes_ReturnList()
        {

            //Arrange 
            var Db = await GetDbContext();
            var repo = new EstateTypesRepository(Db);
            //Act
            var result = await repo.GetListEstateTypes();
            //Assert
            result.Should().BeOfType<List<EstateViewModel>>();


        }

      





    }
}
