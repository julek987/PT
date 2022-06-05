using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Presentation.Model
{
    public class StateModel : IState
    {
        public StateModel(string stateId, string catalogId)
        {
            Id = stateId;
            CatalogId = catalogId;
            Available = true;
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
