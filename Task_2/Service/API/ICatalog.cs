namespace Service.API;

public interface ICatalog
{
    public IService Servicee { get; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Id { get;}
}