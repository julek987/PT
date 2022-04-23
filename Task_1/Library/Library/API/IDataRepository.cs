using Data.Implementation;

namespace Data.API;

public abstract class IDataRepository
{
    public abstract void FillStatic();
    public abstract void AddUser(IUsers u);
    public abstract IUsers GetUser(string id);
    public abstract IEnumerable<IUsers> GetAllUsers();

    public abstract void DeleteUser(IUsers u); //if we have a user. 
    public abstract void DeleteUserWithId(string id);


    public abstract void AddCatalog(ICatalog c);
    public abstract ICatalog GetCatalog(string id);
    public abstract IEnumerable<ICatalog> GetAllCatalogs();
    public abstract void DeleteCatalogWithId(string id);
    public abstract void DeleteCatalog(ICatalog c); // If we have a catalog.


    public abstract void AddEvent(IEvent e);
    public abstract IEvent GetEvent(string id);
    public abstract IEnumerable<IEvent> GetAllEvents();
    public abstract void DeleteEvent(IEvent e);
    public abstract void DeleteEvent(int id);

    public abstract void AddState(IState s);
    public abstract IState GetState(string id);
    public abstract IEnumerable<IState> GetAllStates();
    public abstract void DeleteState(IState s); // If we have a state
    public abstract void DeleteStateWithId(string id);

    public static IDataRepository CreateDataRepository()
    {
        return new DataRepository();
    }
}