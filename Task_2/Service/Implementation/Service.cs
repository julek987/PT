using Service.API;
using Data.API;
using Data;
using Service.Model;

namespace Service.Implementation
{
    public class DataService : IService
    {
        private IDataContext dataContext;

        internal  DataService(IDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task AddCatalog(API.ICatalog c)
        {
            await dataContext.AddCatalogAsync(new Catalog(c.Id, c.Title, c.Author));
        }

        public async Task AddState(API.IState s)
        {
            await dataContext.AddStateAsync(new State(

                s.Id,
                dataContext.Catalogs.Where(c => c.Id == s.CatalogId).First()

            ));
        }

        public async Task AddUser(API.IUsers u)
        {
            await dataContext.AddUserAsync(new Users(u.Id, u.FirstName, u.LastName));
        }

        public async Task AddRent(API.IRent r)
        {
            await dataContext.AddRentAsync(new Rent()
            {
                Id = r.Id,
                State = dataContext.States.Where(s => s.Id == r.StateId).First(),
                User = dataContext.Users.Where(u => u.Id == r.UserId).First() 
                
            }) ;
        }

        public async Task AddReturn(API.IReturn rn)
        {
            await dataContext.AddReturnAsync(new Return()
            {
                Id = rn.Id,
                State = dataContext.States.Where(s => s.Id == rn.StateId).First(),
                User = dataContext.Users.Where(u => u.Id == rn.UserId).First()

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
            return dataContext.Catalogs.Select(c => new CatalogModel(c.Id, c.Title, c.Author)).ToList();
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