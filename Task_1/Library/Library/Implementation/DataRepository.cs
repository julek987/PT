using Data.API;

namespace Data.Implementation;

//TO FINISH
//initialiser why??
internal class DataRepository : IDataRepository
{
    private readonly DataContext dataContext;
    private readonly DataFill dataFill;

    public DataRepository(DataContext dataContext, DataFill dataFill)
    {
        this.dataContext = dataContext;
        this.dataFill = dataFill;
    }

    public override void FillStatic()
    {
        dataFill.Fill(dataContext);
    }

    public override void AddUser(IUsers u)
    {
        dataContext.users.Add(u);
    }

    public override IUsers GetUser(string id)
    {
        return dataContext.users.Single(u => u.Id == id);
    }

    public override IEnumerable<IUsers> GetAllUsers()
    {
        return dataContext.users;
    }

    public override void DeleteUser(IUsers u) //if we have a user. 
    {
        foreach (var e in dataContext.events)
            if (e.UserID == u.Id)
                throw new Exception("Czytelnik posiada wypozyczenie wiec nie mozna go usunac");
        dataContext.users.Remove(u);
    }

    public override void DeleteUserWithId(string id)
    {
        foreach (var e in dataContext.events)
            if (e.UserID == id)
                throw new Exception("Czytelnik posiada wypozyczenie wiec nie mozna go usunac");
        dataContext.users.Remove(dataContext.users.Single(u => u.Id == id));
    }

    public override void AddCatalog(ICatalog c)
    {
        dataContext.catalogs.Add(c.Id, c);
    }

    public override ICatalog GetCatalog(string id)
    {
        return dataContext.catalogs[id];
    }

    public override IEnumerable<ICatalog> GetAllCatalogs()
    {
        return dataContext.catalogs.Values;
    }

    public override void DeleteCatalogWithId(string id)
    {
        foreach (var s in dataContext.states)
            if (s.BookId == id)
                throw new Exception("Cannot remove object. Is in use by State");
        dataContext.catalogs.Remove(id);
    }

    public override void DeleteCatalog(ICatalog c) // If we have a catalog.
    {
        foreach (var s in dataContext.states)
            if (s.BookId == c.Id)
                throw new Exception("Cannot remove object. Is in use by State");

        dataContext.catalogs.Remove(c.Id);
    }

    public override void AddEvent(IEvent e)
    {
        dataContext.events.Add(e);
    }

    public override IEvent GetEvent(string id)
    {
        return dataContext.events.Single(e => e.EventID == id);
    }

    public override IEnumerable<IEvent> GetAllEvents()
    {
        return dataContext.events;
    }

    public override void DeleteEvent(IEvent e)
    {
        foreach (var ee in dataContext.events)
            if (e.Equals(ee))
            {
                dataContext.events.Remove(e);
                return;
            }

        throw new Exception("There is no such event");
    }

    public override void DeleteEvent(int id)
    {
        if (id >= dataContext.events.Count()) throw new Exception("There is no such event");
        dataContext.events.Remove(dataContext.events[id]);
    }

    public override void AddState(IState s)
    {
        dataContext.states.Add(s);
    }

    public override IState GetState(string id)
    {
        return dataContext.states.Single(s => s.Stateid == id);
    }

    public override IEnumerable<IState> GetAllStates()
    {
        return dataContext.states;
    }

    public override void DeleteState(IState s) // If we have a state
    {
        foreach (var e in dataContext.events)
            if (e.StateID == s.Stateid)
                throw new Exception("State is in use");
        dataContext.states.Remove(s);
    }

    public override void DeleteStateWithId(string id)
    {
        foreach (var e in dataContext.events)
            if (e.StateID == id)
                throw new Exception("State is in use");
        dataContext.states.Remove(dataContext.states.Single(s => s.Stateid == id));
    }
}