using Data.API;

namespace Data.Implementation;

//OK
internal class State : IState
{
    private readonly ICatalog catalog;

    public State(string stateid, ICatalog catalog)
    {
        Stateid = stateid;
        this.catalog = catalog;
    }

    public string BookId => catalog.Id;
    public string Stateid { get; set; }
}