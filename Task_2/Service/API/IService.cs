using Data.API;
using Service.Implementation;

namespace Service.API
{
    public interface IService
    {
        Task AddUser(string id, string Firstname, string Lastname );
        Task DeleteUser(int id);
        //Task IEnumerable<IUsers> GetAllUsers();
        Task AddState(int id, int book_id, string available);
        Task DeleteState(int id);
        Task DeleteBook(int id);
        Task DeleteEvent(int id);
       
        
        Task BorrowBook(string userId, string stateId);
        Task ReturnBook(string userId, string stateId);

    }
    public interface IModelCatalog
    {
        public string Title { get; }
        public string Author { get; }
        public string Id { get; }
    }
    public interface IModelState
    {
        public ICatalog Catalog { get; set; }
        string Id { get; }
        bool Available { get; set; }
    }

    public interface IModelUsers
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Id { get; set; }
    }

    public interface IModelRent
    {
        string StateId { get; }
        string UserId { get; }
        string Id { get; set; }
    }
    public interface IModelReturn
    {
        string StateId { get; }
        string UserId { get; }
        string Id { get; set; }
    }

    public static IService CreateLogic(IDataRepository? dataRepository = default)
    {
        return new Service(dataRepository ?? IDataRepository.CreateDataRepository());
    }

    /* TO DO :
     public abstract class DataServiceFactory
    {
        public static IService CreateService(IRepository repository = default)
        {
            return new DataService(repository ?? DataRepositoryFactory.CreateRepository());
        }
    }
    */



}
