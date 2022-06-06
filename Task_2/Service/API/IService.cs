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

