using Service.API;

namespace Service.Model
{
    internal class CatalogModel : ICatalog
    {
        public CatalogModel(string id, string title, string author, IService servicee)
        {
            Id = id;
            Title = title;
            Author = author;
            Servicee = servicee;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public IService Servicee { get; }

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
