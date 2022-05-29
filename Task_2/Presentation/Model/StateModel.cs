using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;

namespace Presentation.Model
{
    public class StateModel
    {
        private readonly ICatalog catalog;

        public StateModel(string stateId, ICatalog catalog)
        {
            Id = stateId;
            this.catalog = catalog;
            Available = true;
        }

        public string CatalogId => catalog.Id;
        public string Id { get; set; }

        public bool Available { get; set; }
        public ICatalog Catalog { get; set; }
    }
}
