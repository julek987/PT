namespace Presentation;

public class CatalogModel : ICatalogModel
{
    public string Title { get; set; }

    public string Author { get; set; }

    public string Id { get; set; }
    
    public override string ToString()
    {
        return Id + " " + Title + " " + Author;
    }
}