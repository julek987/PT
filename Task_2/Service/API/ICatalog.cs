namespace Service.API;

public interface ICatalog
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Id { get; set; }

    Task AddAsync();
    Task DeleteAsync();

}