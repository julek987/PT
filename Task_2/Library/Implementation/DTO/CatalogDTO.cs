using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;

namespace Data.Implementation
{
    internal class CatalogDTO : ICatalog
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
    }
}
