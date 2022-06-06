using Data.API;

namespace TestProject1
{
    internal class CatalogTest : ICatalog
    {
        public CatalogTest(string title, string author, string id)
        {
            Title = title;
            Author = author;
            Id = id;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Id { get; set; }

    }
}
