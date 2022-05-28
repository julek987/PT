using System.Runtime.CompilerServices;
using Data.Implementation;
[assembly:InternalsVisibleTo("Tests")]
namespace Data.API;

public abstract class IDataRepository
{
    public abstract void AddUser(IUsers u);
    public abstract IUsers GetUser(string id);
    public abstract IEnumerable<IUsers> GetAllUsers();

    public abstract void DeleteUser(IUsers u); //if we have a user. 
    public abstract void DeleteUserWithId(string id);
    public abstract bool UserExists(string id);


    public abstract void AddCatalog(ICatalog c);
    public abstract ICatalog GetCatalog(string id);
    public abstract IEnumerable<ICatalog> GetAllCatalogs();
    public abstract void DeleteCatalogWithId(string id);
    public abstract void DeleteCatalog(ICatalog c); // If we have a catalog.
    public abstract bool CatalogExists(string id);

    public abstract void AddEvent(IEvent e);
    public abstract IEnumerable<IEvent> GetAllEvents();
    public abstract void DeleteEvent(IEvent e);
    
    public abstract void AddState(IState s);
    public abstract IState GetState(string id);
    public abstract IEnumerable<IState> GetAllStates();
    public abstract void DeleteState(IState s); // If we have a state
    public abstract void DeleteStateWithId(string id);
    public abstract bool StateExists(string id);
    public abstract bool IsAvailable(string id);
    public abstract void ChangeAvailability(string id);

    public static IDataRepository CreateDataRepository(IFill? fill = default)
    {
        return new DataRepository(fill ?? new EmptyFill());
    }
}