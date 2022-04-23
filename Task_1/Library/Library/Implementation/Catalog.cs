using Data.API;

namespace Data
{
    //OK
    internal class Catalog : ICatalog
    {
        private string title;
        private string author;
        private string id;

        public Catalog(string id, string title, string author)
        {
            this.title = title;
            this.author = author;
            this.id = id;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Id { get => id; set => id = value; } 


    }
}
