using Service.API;
using Data.API;

namespace Service.Implementation
{
    public class DataService : IService
    {
        private IDataRepository dataRepository;

        internal  DataService(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

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
    }
}