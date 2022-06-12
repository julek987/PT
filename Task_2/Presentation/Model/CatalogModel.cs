using System.Threading.Tasks;
using Presentation.Model.ModelAPI;
using Service.API;

namespace Presentation.Model
{
    internal class CatalogModel : ICatalogModel
    {
        public CatalogModel(string id, string title, string author)
        {
            Title = title;
            Author = author;
            Id = id;

            Servicee = IService.Create();
        }

        public IService Servicee { get; }
        public string Title { get; set; }

        public string Author { get; set; }

        public string Id { get; set; }

        public async Task AddAsync()
        {
            await Servicee.AddCatalog(Id, Title, Author);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteCatalog(Id);
        }
    }
}
