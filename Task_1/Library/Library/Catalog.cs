namespace Data
{
    internal class Catalog
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

        internal string Title { get => title; set => title = value; }
        internal string Author { get => author; set => author = value; }
        internal string ID { get => id; set => id = value; } 


    }
}
