namespace Library
{
    //TO FINISH
    //ADD event collection
    public class DataContext
    {
        public List<Users> users = new List<Users> ();
        public Dictionary<int, Catalog> catalogs = new Dictionary<int, Catalog>(); //idk czemu dictionary?
        public List<State> states = new List<State> ();
        public List<Event> events = new List<Event>(); //list instead of observable collection
    }
}
