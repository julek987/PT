using Data.API;

namespace Data
{
    //OK
    internal class State : IState
    {
        private ICatalog catalog;

        public State(string stateid, ICatalog catalog)
        {
            Stateid = stateid;
            this.catalog = catalog;
        }
        
        public string BookId => catalog.Id;
        public string Stateid { get; set; }
        
    }
}
