using Service.API;
using Data.API;
using Service.Model;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ServiceTests")]

namespace Service.Implementation
{
    internal class DataService : IService
    {
        private IDataContext dataContext;

        internal DataService(IDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task AddCatalog(string Id, string Title, string Author)
        {
            await dataContext.AddCatalogAsync(new Catalog(Id, Title, Author));
        }

        public async Task AddState(string StateId, string CatalogId)
        {
            await dataContext.AddStateAsync(new State(

                StateId,
                dataContext.Catalogs.Where(c => c.Id == CatalogId).First()

            ));
        }

        public async Task AddUser(string Id, string FirstName, string LastName)
        {
            await dataContext.AddUserAsync(new Users(Id, FirstName, LastName));
        }

        public async Task AddRent(string Id, string StateId, string UserId)
        {
            await dataContext.AddRentAsync(new Rent()
            {
                Id = Id,
                State = dataContext.States.Where(s => s.Id == StateId).First(),
                User = dataContext.Users.Where(u => u.Id == UserId).First() 
                
            }) ;
        }

        public async Task AddReturn(string Id, string StateId, string UserId)
        {
            await dataContext.AddReturnAsync(new Return()
            {
                State = (from state in dataContext.States where state.Id == StateId select state).First(),
                Id = Id,
                User = dataContext.Users.Where(u => u.Id == UserId).First()
            });
        }

        public Task DeleteCatalog(string id)
        {
            return dataContext.DeleteCatalogAsync(id);
        }

        public Task DeleteRent(string id)
        {
            return dataContext.DeleteRentAsync(id);
        }

        public Task DeleteReturn(string id)
        {
            return dataContext.DeleteReturnAsync(id);
        }

        public Task DeleteState(string id)
        {
            return dataContext.DeleteStateAsync(id);
        }

        public Task DeleteUser(string id)
        {
            return dataContext.DeleteUserAsync(id);
        }

        public async Task<IEnumerable<API.ICatalog>> GetAllCatalogs()
        {
            return dataContext.Catalogs.Select(c => new CatalogModel(c.Id, c.Title, c.Author, this)).ToList();
        }
        public async Task<IEnumerable<API.IUsers>> GetAllUsers()
        {
            return dataContext.Users.Select(u => new UsersModel(this,u.Id, u.FirstName, u.LastName)).ToList();
        }

        public async  Task<API.ICatalog> GetCatalog(string id)
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async Task<API.IUsers> GetUser(string id)
        {
            // TO DO
            throw new NotImplementedException();
        }


    }
}