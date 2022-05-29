using Data.API;
namespace Data.Implementation;
internal class DataRepository : IDataRepository
{
    private readonly DataContext dataContext;
    IDataContext context = IDataContext.CreateContext();
    public DataRepository(IFill dataFill)
    {
        dataContext = new DataContext();
        dataFill.Fill(this);
    }
    #region old
    public void AddUser(IUsers u)
    {
        dataContext.users.Add(u);
    }

    public IUsers GetUser(string id)
    {
        return dataContext.users.Single(u => u.Id == id);
    }

    public IEnumerable<IUsers> GetAllUsers()
    {
        return dataContext.users;
    }

    public void DeleteUser(IUsers u) //if we have a user. 
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

    public void DeleteUserWithId(string id)
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

    public bool UserExists(string id)
    {
        foreach (var user in dataContext.users)
        {
            if (user.Id == id) return true;
        }
        return false;
    }

    public void AddCatalog(ICatalog c)
    {
        dataContext.catalogs.Add(c.Id, c);
    }

    public ICatalog GetCatalog(string id)
    {
        return dataContext.catalogs[id];
    }

    public IEnumerable<ICatalog> GetAllCatalogs()
    {
        return dataContext.catalogs.Values;
    }

    public void DeleteCatalogWithId(string id)
    {
        foreach (var s in dataContext.states)
            if (s.Catalog.Id == id)
                throw new Exception("Cannot remove object. Is in use by State");
        dataContext.catalogs.Remove(id);
    }

    public void DeleteCatalog(ICatalog c) // If we have a catalog.
    {
        foreach (var s in dataContext.states)
            if (s.Catalog.Id == c.Id)
                throw new Exception("Cannot remove object. Is in use by State");

        dataContext.catalogs.Remove(c.Id);
    }

    public bool CatalogExists(string id)
    {
        return dataContext.catalogs.ContainsKey(id);
    }

    public void AddEvent(IEvent e)
    {
        dataContext.events.Add(e);
    }

    public IEnumerable<IEvent> GetAllEvents()
    {
        return dataContext.events;
    }

    public void DeleteEvent(IEvent e)
    {
        foreach (var ee in dataContext.events)
            if (e.Equals(ee))
            {
                dataContext.events.Remove(e);
                return;
            }

        throw new Exception("There is no such event");
    }
    public void AddState(IState s)
    {
        dataContext.states.Add(s);
    }

    public IState GetState(string id)
    {
        return dataContext.states.Single(s => s.Id == id);
    }

    public IEnumerable<IState> GetAllStates()
    {
        return dataContext.states;
    }

    public void DeleteState(IState s) // If we have a state
    {
        foreach (var e in dataContext.events)
            if (e.StateId == s.Id)
                throw new Exception("State is in use");
        dataContext.states.Remove(s);
    }

    public void DeleteStateWithId(string id)
    {
        foreach (var e in dataContext.events)
            if (e.StateId == id)
                throw new Exception("State is in use");
        dataContext.states.Remove(dataContext.states.Single(s => s.Id == id));
    }

    public bool StateExists(string id)
    {
        foreach (var state in dataContext.states)
        {
            if (state.Id == id) return true;
        }
        return false;
    }

    public bool IsAvailable(string id)
    {
        foreach (var s in dataContext.states)
        {
            if (s.Id == id)
            {
                if (s.Available) return true;
            }
        }
        return false;
    }

    public void ChangeAvailability(string id)
    {
        foreach (var s in dataContext.states)
        {
            if (s.Id == id)
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
    #endregion
    /*public async Task<ICatalog> TGetCatalog(string id)
    {
        return await Task.Run<ICatalog>(() => dataContext.Catalogs.Where(b => b.Id == id).FirstOrDefault());
    }

    public async Task<IEnumerable<ICatalog>> TGetAllCatalogs()
    {
        return await Task.Run<IEnumerable<ICatalog>>(() => dataContext.Catalogs);
    }

    public async Task TAddCatalog(ICatalog c)
    {
        throw new NotImplementedException();
    }

    public async Task TUpdateCatalog(ICatalog c)
    {
        throw new NotImplementedException();
    }

    public async Task TDeleteCatalog(ICatalog c)
    {
        throw new NotImplementedException();
    }

    public async Task<IUsers> TGetUser(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<IUsers>> TGetAllUsers()
    {
        throw new NotImplementedException();
    }

    public async Task TAddUser(IUsers u)
    {
        throw new NotImplementedException();
    }

    public async Task TUpdateUser(IUsers u)
    {
        throw new NotImplementedException();
    }

    public async Task TDeleteUser(IUsers u)
    {
        throw new NotImplementedException();
    }

    public async Task<IState> TGetState(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<IState>> TGetAllStates()
    {
        throw new NotImplementedException();
    }

    public async Task TAddState(IState s)
    {
        throw new NotImplementedException();
    }

    public async Task TUpdateState(IState s)
    {
        throw new NotImplementedException();
    }

    public async Task TDeleteState(IState s)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<IEvent>> TGetAllEvents()
    {
        throw new NotImplementedException();
    }

    public async Task TAddEvent(IEvent e)
    {
        throw new NotImplementedException();
    }

    public async Task TUpdateEvent(IEvent e)
    {
        throw new NotImplementedException();
    }

    public async Task TDeleteEvent(IEvent e)
    {
        throw new NotImplementedException();
    }
    */
}