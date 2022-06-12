using Data.API;

namespace Data.Implementation;

internal class State : IState
{
    private readonly ICatalog catalog;

    public State(string stateId, ICatalog catalog)
    {
        Id = stateId;
        this.catalog = catalog;
        Available = true;
    }
    public string CatalogId => catalog.Id;
    public string Id { get; set; }
    public bool Available { get; set; }
    public ICatalog Catalog { get; set; }
}