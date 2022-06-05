namespace Service.API;

public interface IState
{
    string CatalogId { get; set; }
    string Id { get;}
    bool Available { get; set; }
}