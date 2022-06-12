using System.Threading.Tasks;
using Presentation.Model.ModelAPI;

namespace Presentation.Model
{
    internal class CatalogModel : ICatalogModel
    {
        public CatalogModel(string id, string title, string author, IService servicee)
        {
            Title = title;
            Author = author;
            Id = id;
            Servicee = servicee;
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
