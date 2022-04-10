namespace Data
{
    //TO IMPLEMENT
    internal class DataContext
    {
        private List<Users> users = new List<Users> ();
        private Dictionary<int, Catalog> catalogs = new Dictionary<int, Catalog>();
        private List<State> states = new List<State> ();
        private List<Event> events = new List<Event>(); 

        public DataContext(List<Users> users, Dictionary<int, Catalog> catalogs, List<State> states, List<Event> events)
        {
            this.users = users;
            this.catalogs = catalogs;
            this.states = states;
            this.events = events;
        }

        //Users
        internal void AddUser(string id, string firstName, string lastName)
        {
            users.Add(new Users(id, firstName, lastName));
        }
        internal void GetUser()
        {

        }
        internal void UserAlreadyExist()
        {

        }
        internal void DeleteUser()
        {

        }
        //Catalog
        internal void AddBook(string id, string title, string author, string amount, float price)
        {
            Catalog catalog = new Catalog(id, title, author);
            State state = new State(amount, price);
            //catalogs.Add(new Catalog(id,title, author);
            //states.Add(amount, price);
            //states.Add(catalog);
        }
        internal void GetBook(string id)
        {

        }
        internal void BookAlreadyExists(string id)
        {

        }
        internal void DeleteBook(string id)
        {

        }

    }
}
