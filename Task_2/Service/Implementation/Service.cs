using Service.API;
using Data.API;
using Data;

namespace Service.Implementation
{
    public class DataService : IService
    {
        private IDataRepository dataRepository;

        internal  DataService(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public Task ITAddCatalog(ICatalog c)
        {
            throw new NotImplementedException();
        }

        public Task ITAddState(IState s)
        {
            throw new NotImplementedException();
        }

        public Task ITAddUser(IUsers u)
        {
            throw new NotImplementedException();
        }

        public Task ITDeleteCatalog(ICatalog c)
        {
            throw new NotImplementedException();
        }

        public Task ITDeleteState(IState s)
        {
            throw new NotImplementedException();
        }

        public Task ITDeleteUser(IUsers u)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ICatalog>> ITGetAllCatalogs()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IState>> ITGetAllStates()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IUsers>> ITGetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<ICatalog> ITGetCatalog(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IState> ITGetState(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IUsers> ITGetUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task ITUpdateCatalog(ICatalog c)
        {
            throw new NotImplementedException();
        }

        public Task ITUpdateState(IState s)
        {
            throw new NotImplementedException();
        }

        public Task ITUpdateUser(IUsers u)
        {
            throw new NotImplementedException();
        }

        /*
        public Task AddState(int id, int book_id, string available)
        {
            throw new NotImplementedException();
        }

        public Task AddUser(string id, string Firstname, string Lastname)
        {
            throw new NotImplementedException();
        }

        public Task BorrowBook(string userId, string stateId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteState(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task ReturnBook(string userId, string stateId)
        {
            throw new NotImplementedException();
        }
        */
    }
}