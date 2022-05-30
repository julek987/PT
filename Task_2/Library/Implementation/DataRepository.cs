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