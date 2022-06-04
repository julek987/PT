using Service.API;

namespace Service.Model
{
    internal class CatalogModel : ICatalog
    {
        public CatalogModel(IService service, string id, string title, string author)
        {
            Servicee = service;
            Id = id;
            Title = title;
            Author = author;
        }

        public IService Servicee { get; }
        public string Id { get; }
        public string Title { get; set; }
        public string Author { get; set; }

        public async Task Create()
        {
            await Servicee.AddCatalog(this);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteCatalog(this.Id);
        }
    }


}
