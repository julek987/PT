using Service.API;

namespace Service.Model
{
    internal class CatalogModel : ICatalog
    {
        public CatalogModel(string id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public string Id { get; }
        public string Title { get; }
        public string Author { get; }
    }
}
