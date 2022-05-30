using Data;
using Data.API;
using Service.Implementation;

namespace Service.API;
    public interface IService
    {

    //Catalog
    Task<ICatalog> ITGetCatalog(int id);
    Task<IEnumerable<ICatalog>> ITGetAllCatalogs();
    Task ITAddCatalog(ICatalog c);
    Task ITUpdateCatalog(ICatalog c);
    Task ITDeleteCatalog(ICatalog c);

    //User
    Task<IUsers> ITGetUser(string id);
    Task<IEnumerable<IUsers>> ITGetAllUsers();
    Task ITAddUser(IUsers u);
    Task ITUpdateUser(IUsers u);
    Task ITDeleteUser(IUsers u);

    //State
    Task<IState> ITGetState(string id);
    Task<IEnumerable<IState>> ITGetAllStates();
    Task ITAddState(IState s);
    Task ITUpdateState(IState s);
    Task ITDeleteState(IState s);


}
/*
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

   
     public abstract class DataServiceFactory
    {
        public static IService CreateService(IRepository repository = default)
        {
            return new DataService(repository ?? DataRepositoryFactory.CreateRepository());
        }
    }
    */

