namespace Library
{
    public class DataContext
    {
        public List<Users> users = new List<Users> ();
        public Dictionary<int, Catalog> catalogs = new Dictionary<int, Catalog>(); 
        public List<State> states = new List<State> ();
        public List<Event> events = new List<Event>(); 
    }
}
