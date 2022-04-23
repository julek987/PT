using Data.API;

namespace Data;

//OK
internal class Catalog : ICatalog
{
    public Catalog(string id, string title, string author)
    {
        this.Title = title;
        this.Author = author;
        this.Id = id;
    }

    public string Title { get; set; }

    public string Author { get; set; }

    public string Id { get; set; }
}