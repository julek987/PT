using System.Threading.Tasks;

namespace Presentation.Model.ModelAPI
{
    public interface IUsersModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Id { get; set; }

        Task AddAsync();
        Task DeleteAsync();

    }
}
