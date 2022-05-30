namespace Service.API;
    public interface IService
    {

    //Catalog
    Task<ICatalog> IGetCatalog(string id);
    Task<IEnumerable<ICatalog>> IGetAllCatalogs();
    Task IAddCatalog(ICatalog c);
    Task IUpdateCatalog(ICatalog c);
    Task IDeleteCatalog(string id);

    //User
    Task<IUsers> IGetUser(string id);
    Task<IEnumerable<IUsers>> IGetAllUsers();
    Task IAddUser(IUsers u);
    Task IUpdateUser(IUsers u);
    Task IDeleteUser(string id);

    //State
    Task<IState> IGetState(string id);
    Task<IEnumerable<IState>> IGetAllStates();
    Task IAddState(IState s);
    Task IUpdateState(IState s);
    Task IDeleteState(string id);

    //Rent
    Task <IRent> IGetRent(string id);
    Task<IEnumerable<IRent>> IGetAllRents();
    Task IAddRent(IRent r);
    Task IDeleteRent(string id);

    //Return
    Task<IReturn> IGetReturn(string id);
    Task<IEnumerable<IReturn>> IGetAllReturns();
    Task IAddReturn(IReturn rn);
    Task IDeleteReturn(string id);


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

