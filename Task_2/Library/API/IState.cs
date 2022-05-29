namespace Data.API;

public interface IState
{
    public ICatalog Catalog { get; set; }
    string Id { get;}
    bool Available { get; set; }
}