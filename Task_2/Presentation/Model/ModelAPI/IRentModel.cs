using System.Threading.Tasks;

namespace Presentation.Model.ModelAPI
{
    public interface IRentModel
    {
        string Id { get; set; }
        public string StateId { get; set; }
        public string UserId { get; set; }

        Task AddAsync();
    }
}
