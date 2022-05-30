using Data.API;

namespace Service.Implementation
{
    internal class Catalog : ICatalog
    {
        public Catalog(string id, string title, string author)
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