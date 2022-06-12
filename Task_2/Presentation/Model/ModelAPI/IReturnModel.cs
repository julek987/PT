using System.Threading.Tasks;

namespace Presentation.Model.ModelAPI
{
    public interface IReturnModel
    {
        string Id { get; set; }
        public string StateId { get; set; }
        public string UserId { get; set; }

        Task AddAsync();
    }
}
