using Data.API;
using Data.Implementation;

namespace Data.Implementation;

internal class DataContext : IDataContext
{
    internal Dictionary<string, ICatalog> catalogs = new();
    internal List<IEvent> events = new();
    internal List<IState> states = new();
    internal List<IUsers> users = new();
}