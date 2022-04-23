using Data.API;

namespace Data
{
    //TO IMPLEMENT
    internal class DataContext
    {
        internal List<IUsers> users = new List<IUsers> ();
        internal Dictionary<string, ICatalog> catalogs = new Dictionary<string, ICatalog>();
        internal List<IState> states = new List<IState> ();
        internal List<IEvent> events = new List<IEvent>(); 

        public DataContext(List<IUsers> users, Dictionary<string, ICatalog> catalogs, List<IState> states, List<IEvent> events)
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
        
        //Catalog
        internal void AddState(string id, string title, string author, string stateid)
        {
            ICatalog? catalog = catalogs.GetValueOrDefault(id);
            catalog ??= new Catalog(id, title, author);
            State state = new State(stateid, catalog);
            catalogs[catalog.Id] = catalog;
            states.Add(state);
        }
    }
}
