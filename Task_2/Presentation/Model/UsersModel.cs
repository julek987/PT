using System.Threading.Tasks;
using Presentation.Model.ModelAPI;

namespace Presentation.Model
{
    public class UsersModel : IUsersModel
    {
        public UsersModel(IService service, string firstName, string lastName, string id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public IService Servicee { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }

        public async Task AddAsync()
        {
            await Servicee.AddUser(this);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteUser(this.Id);
        }


    }
}
