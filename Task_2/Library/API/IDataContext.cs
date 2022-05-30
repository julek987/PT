using Data.Implementation;

namespace Data.API;
public interface IDataContext
{
    public IQueryable<IUsers> Users { get;}

    public IQueryable<ICatalog> Catalogs { get;}

    public IQueryable<IState> States { get;}
  
    public IQueryable<IReturn> Returns { get;}
    public IQueryable<IRent> Rents { get; }
   

    public static IDataContext CreateContext(string? connectionString = null) => new DataContext(connectionString);
    Task AddCatalogAsync(ICatalog catalog);
    Task AddRentAsync(IRent rent);
    Task AddReturnAsync(IReturn @return);
    Task AddStateAsync(IState state);
    Task AddUserAsync(IUsers user);
    Task DeleteCatalogAsync(string Id);
    Task DeleteRentAsync(string Id);
    Task DeleteReturnAsync(string Id);
    Task DeleteStateAsync(string Id);
    Task DeleteUserAsync(string Id);
}