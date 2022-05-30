using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;
namespace Data.Implementation
{
    internal class StateDTO : IState
    {
        [ForeignKey(nameof(Catalog))]
        public string Id { get; init; }

        public ICatalog Catalog { get; set; }
        public bool Available { get; set; }
    }
}
