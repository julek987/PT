namespace Library
{
    //TO FINISH
    public class DataRepository
    {
        private DataContext dataContext;
        private DataFill dataFill;

        public DataRepository(DataContext dataContext, DataFill dataFill)
        {
            this.dataContext = dataContext;
            this.dataFill = dataFill;
        }

        public void FillStatic() => dataFill.Fill(dataContext);

        public void AddUser(Users U)
        {
            dataContext.users.Add(U);
        }

        public Users GetUser(string id)
        {
            foreach (var U in dataContext.users)
            {
                if (U.Id == id)
                {
                    return U;
                }
            }
            throw new Exception("There is no such user.");
        }

        public IEnumerable<Users> GetAllUsers()
        {
            return dataContext.users;
        }

        public void DeleteUser(Users U) //if we have a user. 
        {
            foreach (var e in dataContext.events)
            {
                if (e.u == U) throw new Exception("Czytelnik posiada wypozyczenie wiec nie mozna go usunac");
            }
            dataContext.users.Remove(U);
        }

        public void DeleteUserWithId(string _id)
        {
            Users tmp = GetUser(_id);

            foreach (var e in dataContext.events)
            {
                if (e.u == tmp) throw new Exception("Czytelnik posiada wypozyczenie wiec nie mozna go usunac");
            }
            dataContext.users.Remove(tmp);
        }
        private int CatalogCounter=0;

        public int CatalogCounter1 { get { return CatalogCounter; } set => CatalogCounter = value; }

        public void AddCatalog(Catalog C)
        {
            dataContext.catalogs.Add(CatalogCounter, C);
            CatalogCounter++;
        }

        public Catalog GetCatalog(int id)
        {
            return dataContext.catalogs[id];
        }

        public IEnumerable<Catalog> GetAllCatalogs()
        {
            return dataContext.catalogs.Values;
        }

        public void DeleteCatalogWithId(int id)
        {
            foreach (var O in dataContext.states)
            {
                if (O.Cata2.Equals(dataContext.catalogs[id])) throw new Exception("Cannot remove object. Is in use by State");
            }
            dataContext.catalogs.Remove(id);
        }

        public void DeleteCatalog(Catalog C)// If we have a catalog.
        {
            foreach (var O in dataContext.states)
            {
                if (O.Cata2 == C) throw new Exception("Cannot remove object. Is in use by State");
            }

            for (int id = 0; id < dataContext.catalogs.Count; id++)
            {
                if (dataContext.catalogs[id].Equals(C))
                {
                    dataContext.catalogs.Remove(id);
                    return;
                }
            }
        }

        public void AddEvent(Event E)
        {
            dataContext.events.Add(E);
        }

        public Event GetEventWithId(int id)
        {
            return dataContext.events[id];
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return dataContext.events;
        }

        public void DeleteEvent(Event E)
        {
            foreach (var ee in dataContext.events)
            {
                if (E.Equals(ee))
                {
                    dataContext.events.Remove(E);
                    return;
                }
            }
            throw new Exception("There is no such event");
        }

        public void DeleteEvent(int _id)
        {
            if (_id >= dataContext.events.Count()) throw new Exception("There is no such event");
            dataContext.events.Remove(dataContext.events[_id]);
        }

        public void AddState(State S)
        {
            dataContext.states.Add(S);
        }

        public State GetStateWithId(int id)
        {
            return dataContext.states[id];
        }

        public IEnumerable<State> GetAllStates()
        {
            return dataContext.states;
        }

        public void DeleteState(State S)// If we have a state
        {
            foreach (var e in dataContext.events)
            {
                if (e.s.Equals(S))
                {
                    throw new Exception("State is in use");
                }
            }
            dataContext.states.Remove(S);
        }

        public void DeleteStateWithId(int id)
        {
            State S = GetStateWithId(id);
            foreach (var e in dataContext.events)
            {
                if (e.s.Equals(S))
                {
                    throw new Exception("State is in use");
                }
            }
            dataContext.states.Remove(S);
        }
    }

    
}