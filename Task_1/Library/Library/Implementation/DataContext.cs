using Data.API;
using Data.Implementation;

namespace Data.Implementation;

//TO IMPLEMENT
internal class DataContext
{
    internal Dictionary<string, ICatalog> catalogs = new();
    internal List<IEvent> events = new();
    internal List<IState> states = new();
    internal List<IUsers> users = new();

    public DataContext(List<IUsers> users, Dictionary<string, ICatalog> catalogs, List<IState> states,
        List<IEvent> events)
    {
        this.users = users;
        this.catalogs = catalogs;
        this.states = states;
        this.events = events;
    }

    //Users
    internal void AddUser(string id, string firstName, string lastName)
    {
        users.Add(new Users(id, firstName, lastName));
    }

    //Catalog
    internal void AddState(string id, string title, string author, string stateid)
    {
        var catalog = catalogs.GetValueOrDefault(id);
        catalog ??= new Catalog(id, title, author);
        var state = new State(stateid, catalog);
        catalogs[catalog.Id] = catalog;
        states.Add(state);
    }
}