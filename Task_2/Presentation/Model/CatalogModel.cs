using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Presentation.Model
{
    internal class CatalogModel : ICatalog
    {
        public CatalogModel(string id, string title, string author)
        {
            Title = title;
            Author = author;
            Id = id;
        }

        public IService Servicee { get; }
        public string Title { get; set; }

        public string Author { get; set; }

        public string Id { get; set; }

        public async Task AddAsync()
        {
            await Servicee.AddCatalog(this);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteCatalog(this.Id);
        }
    }
}
