using System.Threading.Tasks;
using Presentation.Model.ModelAPI;
using Service.API;

namespace Presentation.Model
{
    public class StateModel : IStateModel
    {
        public StateModel(string stateId, string catalogId)
        {
            Id = stateId;
            CatalogId = catalogId;
            Available = true;

            Servicee = IService.Create();
        }

        public string CatalogId { get; set; }
        public string Id { get; set; }

        public bool Available { get; set; }
        public IService Servicee { get; }


        public async Task AddAsync()
        {
            await Servicee.AddState(Id, CatalogId);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteState(Id);
        }
    }
}
