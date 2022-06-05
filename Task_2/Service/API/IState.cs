namespace Service.API;

public interface IState
{
    string CatalogId { get; set; }
    string Id { get; set; }
    bool Available { get; set; }

    Task AddAsync();
    Task DeleteAsync();
}