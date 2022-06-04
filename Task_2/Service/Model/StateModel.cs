using Service.API;

namespace Service.Model
{
    internal class StateModel : IState
    {
        private readonly ICatalog catalog;

        public StateModel(string stateId, ICatalog catalog)
        {
            Id = stateId;
            Catalog = catalog;
            Available = true;
        }

        public string CatalogId => catalog.Id;
        public string Id { get; set; }

        public bool Available { get; set; }
        public ICatalog Catalog { get; set; }
    }
}
