using Data.API;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
namespace Data.Implementation;

internal class DataContext : DbContext, IDataContext
{

    private const string defaultConnectionString =
        @"Data Source=LAPTOP-0CCV3DTJ;Initial Catalog=Database_Task2_PT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


    private readonly string _connectionString;

    public DataContext( string? connectionString = null)
    {
        this._connectionString = connectionString ?? defaultConnectionString;
    }

    internal Dictionary<string, ICatalog> catalogs = new();
    internal List<IEvent> events = new();
    internal List<IState> states = new();
    internal List<IUsers> users = new();

    public DbSet<UsersDTO> _users { get; set; }
    public IQueryable<IUsers> Users => _users;
    public DbSet<RentDTO> _rents { get; set; }
    public IQueryable<IRent> Rents => _rents;
    public DbSet<ReturnDTO> _returns { get; set; }
    public IQueryable<IReturn> Returns => _returns;
    public DbSet<StateDTO> _states { get; set; }
    public IQueryable<IState> States => _states;
    public DbSet<CatalogDTO> _catalogs { get; set; }
    public IQueryable<ICatalog> Catalogs => _catalogs;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<StateDTO>().HasOne(state => (CatalogDTO)state.Catalog);
    }

    public async Task AddUserAsync(IUsers user)
    {
        UsersDTO userToAdd = new() { FirstName = user.FirstName, LastName = user.LastName, Id = user.Id };
        await AddAsync(userToAdd);
    }

    public async Task AddCatalogAsync(ICatalog catalog)
    {
        CatalogDTO catalogToAdd = new() { Id = catalog.Id, Author = catalog.Author, Title = catalog.Title};
        await AddAsync(catalogToAdd);
    }

    public async Task AddStateAsync(IState state)
    {
        //TO DO
        //StateDTO stateToAdd = new() { Available = true, Id = state.Id, state.Catalog };
    }

    public async Task AddRentAsync(IRent rent)
    {
        RentDTO rentToAdd = new() { Id = rent.Id, StateId = rent.StateId, UserId = rent.UserId };
        await AddAsync(rentToAdd);
    }

    public async Task AddReturnAsync(IReturn rreturn)
    {
        ReturnDTO returnToAdd = new() { Id = rreturn.Id, StateId = rreturn.StateId, UserId = rreturn.UserId };
        await AddAsync(returnToAdd);
    }
}