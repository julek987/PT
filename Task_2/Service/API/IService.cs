using Service.Implementation;
using Data.API;

namespace Service.API;
    public interface IService
    {
    public static IService Create() => new DataService(IDataContext.CreateContext());

    //Catalog
    Task<IEnumerable<ICatalog>> GetAllCatalogs();
    Task AddCatalog(string Id, string Title, string Author);
    Task DeleteCatalog(string id);

    //User
    Task<IEnumerable<IUsers>> GetAllUsers();
    Task AddUser(string id, string firstName, string lastName);
    Task DeleteUser(string id);

    //State
    Task AddState(string stateId, string catalogId);
    Task DeleteState(string id);

    //Rent
    Task AddRent(string Id, string StateId, string UserId);
    Task DeleteRent(string id);

    //Return
    Task AddReturn(string Id, string StateId, string UserId);
    Task DeleteReturn(string id);


}

