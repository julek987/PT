using Service.API;
using Data.API;
using Data;

namespace Service.Implementation
{
    public class DataService : IService
    {


        private IDataContext dataContext;

        internal  DataService(IDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task IAddCatalog(API.ICatalog c)
        {
            await dataContext.AddCatalogAsync(new Catalog(c.Id, c.Title, c.Author));
        }

        public async Task IAddRent(API.IRent r)
        {
            await dataContext.AddRentAsync(new Rent()
            {
                //TO DO
                Id = r.Id,
                //State = dataContext.FindAsync(r.State.Id),
                //User = dataContext.User

            }) ;
        }

        public async Task IAddReturn(API.IReturn rn)
        {
               // TO DO
        }

        public async Task IAddState(API.IState s)
        {
               // TO DO
        }

        public async Task IAddUser(API.IUsers u)
        {
            await dataContext.AddUserAsync(new Users(u.Id, u.FirstName, u.LastName));
        }

        public async Task IDeleteCatalog(string id)
        {
            await dataContext.DeleteCatalogAsync(id);
        }

        public async Task IDeleteRent(string id)
        {
            await dataContext.DeleteRentAsync(id);
        }

        public async Task IDeleteReturn(string id)
        {
            await dataContext.DeleteReturnAsync(id);
        }

        public async Task IDeleteState(string id)
        {
            await dataContext.DeleteStateAsync(id);
        }

        public async Task IDeleteUser(string id)
        {
            await dataContext.DeleteUserAsync(id);
        }

        public async Task<IEnumerable<API.ICatalog>> IGetAllCatalogs()
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<API.IRent>> IGetAllRents()
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<API.IReturn>> IGetAllReturns()
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<API.IState>> IGetAllStates()
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<API.IUsers>> IGetAllUsers()
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async  Task<API.ICatalog> IGetCatalog(string id)
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async Task<API.IRent> IGetRent(string id)
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async Task<API.IReturn> IGetReturn(string id)
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async Task<API.IState> IGetState(string id)
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async Task<API.IUsers> IGetUser(string id)
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async Task IUpdateCatalog(API.ICatalog c)
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async Task IUpdateState(API.IState s)
        {
            // TO DO
            throw new NotImplementedException();
        }

        public async Task IUpdateUser(API.IUsers u)
        {
            // TO DO
            throw new NotImplementedException();
        }

    }
}