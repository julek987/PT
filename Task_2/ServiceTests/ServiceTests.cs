using NSubstitute;
using Service.API;
using Data.API;
using Service.Implementation;
using Service.Model;


namespace ServiceTests
{
    public class ServiceTests
    {
        private readonly IDataContext dataContext;
        private readonly IService service;

        public ServiceTests()
        {
            dataContext = Substitute.For<IDataContext>();
            service = new DataService(dataContext);
        }


        [Fact]
        public async Task AddUser()
        {
            //IUsers user = new UsersModel("Will", "Smith", "1");
            await service.AddUser("1", "Will", "Smith");
            await dataContext.Received(1).AddUserAsync(Arg.Is<Data.IUsers>(user => user.Id == "1")) ; 

        }

        [Fact]
        public async Task AddCatalog()
        {
            //Service.API.ICatalog cat = new CatalogModel("1", "Anna Karenina", "Lew Tolstoy", service);
            await service.AddCatalog("1", "Anna Karenina", "Lew Tolstoy");
            await dataContext.Received(1).AddCatalogAsync(Arg.Is<Data.API.ICatalog>(cat => cat.Id == "1"));

        }

        [Fact]
        public async Task DeleteUser()
        {
            //IUsers user = new UsersModel(service, "Will", "Smith", "1");
            await service.AddUser("Will", "Smith", "1");
            await service.DeleteUser("1");
            await dataContext.Received(1).DeleteUserAsync("1");

        }

        [Fact]
        public async Task DeleteCatalog()
        {
            //Service.API.ICatalog cat = new CatalogModel("1", "Anna Karenina", "Lew Tolstoy", service);
            await service.AddCatalog("1", "Anna Karenina", "Lew Tolstoy");
            await service.DeleteCatalog("1");
            await dataContext.Received(1).DeleteCatalogAsync("1");

        }
    }
}