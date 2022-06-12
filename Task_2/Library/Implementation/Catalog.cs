using Data.API;
namespace Data.Implementation;

internal class Catalog : ICatalog
{
    public Catalog(string id, string title, string author)
    {
        Title = title;
        Author = author;
        Id = id;
    }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Id { get; set; }
}