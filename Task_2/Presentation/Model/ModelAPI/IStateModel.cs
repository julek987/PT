using System.Threading.Tasks;

namespace Presentation.Model.ModelAPI
{
    public interface IStateModel
    {
        string CatalogId { get; set; }
        string Id { get; set; }
        bool Available { get; set; }
        Task AddAsync();
        Task DeleteAsync();
    }

}
