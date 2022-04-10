namespace Library
{
    public class Catalog
    {
        private string title;
        private string author;
        private string number;

        public Catalog(string title, string author, string number)
        {
            this.title = title;
            this.author = author;
            this.number = number;
        }

        public string Title { get { return title; } set => title = value; }
        public string Author { get { return author; } set => author = value; }
        public string Number { get { return number; } set => number = value; } //or use a INT ??
        public string All { get => number + " " + title + " " + author; }

        public override bool Equals(object obj)
        {
            Catalog other = (Catalog)obj; 
            return this.number == other.number;
        }


    }
}
