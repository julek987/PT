using System.Threading.Tasks;
using Presentation.Model.ModelAPI;

namespace Presentation.Model
{
    public class StateModel : IStateModel
    {
        public StateModel(string stateId, string catalogId, IService servicee)
        {
            Id = stateId;
            CatalogId = catalogId;
            Available = true;
            Servicee = servicee;
        }

        public string CatalogId { get; set; }
        public string Id { get; set; }

        public bool Available { get; set; }
        public IService Servicee { get; }


        public async Task AddAsync()
        {
            await Servicee.AddState(this);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteState(this.Id);
        }
    }
}
