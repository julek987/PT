using System.Threading.Tasks;

namespace Presentation.Model.ModelAPI
{
    public interface ICatalogModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Id { get; set; }

        Task AddAsync();
        Task DeleteAsync();
    }
}
