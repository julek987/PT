namespace Presentation;

public class StateModel : IStateModel
{
    private readonly ICatalogModel CatalogModel;
    public string BookId => CatalogModel.Id;
    public string StateId { get; set; }

    public bool Available { get; set; }
    
    public override string ToString()
    {
        return BookId + " " + StateId + " " + Available;
    }
}