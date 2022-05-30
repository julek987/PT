using System.Runtime.CompilerServices;
using Data.Implementation;
[assembly:InternalsVisibleTo("Tests")]
namespace Data.API;

public interface IDataRepository
{

    public static IDataRepository CreateDataRepository(IFill? fill = default)
    {
        return new DataRepository(fill ?? new EmptyFill());
    }
    
    //Catalog
    /*Task<ICatalog> TGetCatalog(string id);
    Task<IEnumerable<ICatalog>> TGetAllCatalogs();
    Task TAddCatalog(ICatalog c);
    Task TUpdateCatalog(ICatalog c);
    Task TDeleteCatalog(ICatalog c);

    //User
    Task<IUsers> TGetUser(string id);
    Task<IEnumerable<IUsers>> TGetAllUsers();
    Task TAddUser(IUsers u);
    Task TUpdateUser(IUsers u);
    Task TDeleteUser(IUsers u);

    //State
    Task<IState> TGetState(string id);
    Task<IEnumerable<IState>> TGetAllStates();
    Task TAddState(IState s);
    Task TUpdateState(IState s);
    Task TDeleteState(IState s);

    //Event
    Task<IEnumerable<IEvent>> TGetAllEvents();
    Task TAddEvent(IEvent e);
    Task TUpdateEvent(IEvent e);
    Task TDeleteEvent(IEvent e);
    */

}