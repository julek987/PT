using Data.API;
using Data.Implementation;

namespace Data.Implementation;

internal class DataContext : IDataContext
{
    internal Dictionary<string, ICatalog> catalogs = new();
    internal List<IEvent> events = new();
    internal List<IState> states = new();
    internal List<IUsers> users = new();

    //Users
    public override void AddUser(IUsers user)
    {
        users.Add(user);
    }

    //Catalog
    public override void AddState(string id, string title, string author, string stateid)
    {
        var catalog = catalogs.GetValueOrDefault(id);
        catalog ??= new Catalog(id, title, author);
        var state = new State(stateid, catalog);
        catalogs[catalog.Id] = catalog;
        states.Add(state);
    }
}