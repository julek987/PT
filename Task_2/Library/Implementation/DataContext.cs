using Data.API;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
namespace Data.Implementation;

internal class DataContext : DbContext, IDataContext
{

    private const string defaultConnectionString =
        //Julianos
        @"Data Source=LAPTOP-0CCV3DTJ;Initial Catalog=Database_Task2_PT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //Magdos
        //@"Data Source = LAPTOP-K74FCUSP; Initial Catalog = PT_baza_task2; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    private readonly string _connectionString;

    public DataContext( string? connectionString = null)
    {
        this._connectionString = connectionString ?? defaultConnectionString;
    }

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
        modelBuilder.Entity<ReturnDTO>().HasOne(@return => (StateDTO)@return.State);
        modelBuilder.Entity<RentDTO>().HasOne(rent => (StateDTO)rent.State);
        modelBuilder.Entity<ReturnDTO>().HasOne(@return => (UsersDTO)@return.User);
        modelBuilder.Entity<RentDTO>().HasOne(rent => (UsersDTO)rent.User);

    }

    public async Task AddUserAsync(IUsers user)
    {
        UsersDTO userToAdd = new() { FirstName = user.FirstName, LastName = user.LastName, Id = user.Id };
        await _users.AddAsync(userToAdd);
        await SaveChangesAsync();
    }

    public async Task AddCatalogAsync(ICatalog catalog)
    {
        CatalogDTO catalogToAdd = new() { Id = catalog.Id, Author = catalog.Author, Title = catalog.Title};
        await _catalogs.AddAsync(catalogToAdd);
        await SaveChangesAsync();
    }

    public async Task AddStateAsync(IState state)
    {
        StateDTO stateToAdd = new() { Available = true, Id = state.Id, Catalog = state.Catalog};
        await _states.AddAsync(stateToAdd);
        await SaveChangesAsync();
    }

    public async Task AddRentAsync(IRent rent)
    {
        RentDTO rentToAdd = new() { Id = rent.Id, State = rent.State, User = rent.User };
        await _rents.AddAsync(rentToAdd);
        await SaveChangesAsync();
    }

    public async Task AddReturnAsync(IReturn @return)
    {
        ReturnDTO returnToAdd = new() { Id = @return.Id, State = @return.State, User = @return.User };
        await _returns.AddAsync(returnToAdd);
        await SaveChangesAsync();
    }
    public async Task DeleteCatalogAsync(string Id)
    {

        CatalogDTO? entityToRemove = await _catalogs.FindAsync(Id);
        if(entityToRemove != null)
        {
            _catalogs.Remove(entityToRemove);
            await SaveChangesAsync();
        }
        
    }
        public async Task DeleteStateAsync(string Id)
    {

        StateDTO? entityToRemove = await _states.FindAsync(Id);
        if(entityToRemove != null)
        {
            _states.Remove(entityToRemove);
            await SaveChangesAsync();
        }
        
    }
        public async Task DeleteUserAsync(string Id)
    {

        UsersDTO? entityToRemove = await _users.FindAsync(Id);
        if(entityToRemove != null)
        {
            _users.Remove(entityToRemove);
            await SaveChangesAsync();
        }
        
    }
        public async Task DeleteRentAsync(string Id)
    {

        RentDTO? entityToRemove = await _rents.FindAsync(Id);
        if(entityToRemove != null)
        {
            _rents.Remove(entityToRemove);
            await SaveChangesAsync();
        }
        
    }
        public async Task DeleteReturnAsync(string Id)
    {

        ReturnDTO? entityToRemove = await _returns.FindAsync(Id);
        if(entityToRemove != null)
        {
            _returns.Remove(entityToRemove);
            await SaveChangesAsync();
        }
        
    }
}