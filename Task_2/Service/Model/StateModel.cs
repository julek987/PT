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

        public string CatalogId { get; set; }
        public string Id { get; set; }

        public bool Available { get; set; }
        public ICatalog Catalog { get; set; } //?

        public IService Servicee { get; }

        public async Task AddAsync()
        {
            await Servicee.AddState(Id, CatalogId);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteState(this.Id);
        }
    }
}
