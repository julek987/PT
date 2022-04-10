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
        //QUESTION
        //return or get set?? for example: public string Title { get => title; set => title = value; }
        public string Title { get { return title; } } 
        public string Author { get { return author; } }
        public string Number { get { return number; } } //or use a INT ??
        public string All { get => number + " " + title + " " + author; }

        public override bool Equals(object obj)
        {
            Catalog other = obj as Catalog; //or (Catalog)obj
            return this.number == other.number;
        }


    }
}
