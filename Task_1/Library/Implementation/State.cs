using Data.API;

namespace Data.Implementation;

internal class State : IState
{
    private readonly ICatalog catalog;

    public State(string stateId, ICatalog catalog)
    {
        StateId = stateId;
        this.catalog = catalog;
    }

    public string BookId => catalog.Id;
    public string StateId { get; set; }
    
    public bool Available { get; set; }
}