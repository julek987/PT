using Data.API;
using Microsoft.EntityFrameworkCore;

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
}