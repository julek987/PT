namespace Service.API;
    public interface IService
    {

    //Catalog
    //Task<ICatalog> GetCatalog(string id);
    Task<IEnumerable<ICatalog>> GetAllCatalogs();
    Task AddCatalog(ICatalog c);
    //Task UpdateCatalog(ICatalog c);
    Task DeleteCatalog(string id);

    //User
    //Task<IUsers> GetUser(string id);
    Task<IEnumerable<IUsers>> GetAllUsers();
    Task AddUser(IUsers u);
    //Task UpdateUser(IUsers u);
    Task DeleteUser(string id);

    //State
    //Task<IState> GetState(string id);
   // Task<IEnumerable<IState>> GetAllStates();
    Task AddState(IState s);
    //Task UpdateState(IState s);
    Task DeleteState(string id);

    //Rent
   // Task <IRent> GetRent(string id);
   // Task<IEnumerable<IRent>> GetAllRents();
    Task AddRent(IRent r);
    Task DeleteRent(string id);

    //Return
   // Task<IReturn> GetReturn(string id);
   // Task<IEnumerable<IReturn>> GetAllReturns();
    Task AddReturn(IReturn rn);
    Task DeleteReturn(string id);


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

