using Service.API;

namespace Service.Model
{
    internal class CatalogModel : ICatalog
    {
        public CatalogModel(string id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public string Id { get; }
        public string Title { get; set; }
        public string Author { get; set; }

        public IService Servicee { get; }

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
