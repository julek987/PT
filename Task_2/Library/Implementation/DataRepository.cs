using Data.API;

namespace Data.Implementation;
internal class DataRepository : IDataRepository
{
    private readonly DataContext dataContext;

    public DataRepository(IFill dataFill)
    {
        dataContext = new DataContext();
        dataFill.Fill(this);
    }
    //User
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
        int RentCount = 0;
        int ReturnCount = 0;
        foreach (var e in dataContext.events.OfType<IRent>())
            if (e.UserId == u.Id)
                RentCount++;
        foreach (var e in dataContext.events.OfType<IReturn>())
            if (e.UserId == u.Id)
                ReturnCount++;
        if(RentCount!=ReturnCount)
                throw new Exception("User has an unreturned book, cannot be deleted.");
        dataContext.users.Remove(u);
    }

    public override void DeleteUserWithId(string id)
    {
        int RentCount = 0;
        int ReturnCount = 0;
        foreach (var e in dataContext.events.OfType<IRent>())
            if (e.UserId == id)
                RentCount++;
        foreach (var e in dataContext.events.OfType<IReturn>())
            if (e.UserId == id)
                ReturnCount++;
        if(RentCount!=ReturnCount)
                throw new Exception("User has an unreturned book, cannot be deleted.");
        dataContext.users.Remove(dataContext.users.Single(u => u.Id == id));
    }

    public override bool UserExists(string id)
    {
        foreach (var user in dataContext.users)
        {
            if (user.Id == id) return true;
        }
        return false;
    }
    //Catalog
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

    public override bool CatalogExists(string id)
    {
        return dataContext.catalogs.ContainsKey(id);
    }
    //Event
    public override void AddEvent(IEvent e)
    {
        dataContext.events.Add(e);
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
    //State
    public override void AddState(IState s)
    {
        dataContext.states.Add(s);
    }

    public override IState GetState(string id)
    {
        return dataContext.states.Single(s => s.StateId == id);
    }

    public override IEnumerable<IState> GetAllStates()
    {
        return dataContext.states;
    }

    public override void DeleteState(IState s) // If we have a state
    {
        foreach (var e in dataContext.events)
            if (e.StateId == s.StateId)
                throw new Exception("State is in use");
        dataContext.states.Remove(s);
    }

    public override void DeleteStateWithId(string id)
    {
        foreach (var e in dataContext.events)
            if (e.StateId == id)
                throw new Exception("State is in use");
        dataContext.states.Remove(dataContext.states.Single(s => s.StateId == id));
    }

    public override bool StateExists(string id)
    {
        foreach (var state in dataContext.states)
        {
            if (state.StateId == id) return true;
        }
        return false;
    }

    public override bool IsAvailable(string id)
    {
        foreach (var s in dataContext.states)
        {
            if (s.StateId == id)
            {
                if (s.Available) return true;
            }
        }
        return false;
    }

    public override void ChangeAvailability(string id)
    {
        foreach (var s in dataContext.states)
        {
            if (s.StateId == id)
            {
                if (s.Available)
                {
                    s.Available = false;
                    break;
                }
                if(!s.Available) s.Available = true;
                break;
            }
        }
    }
}