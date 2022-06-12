using System.Threading.Tasks;
using Presentation.Model.ModelAPI;
using Service.API;

namespace Presentation.Model
{
    public class UsersModel : IUsersModel
    {
        public UsersModel(string id, string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;

            Servicee = IService.Create();
        }

        public IService Servicee { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }

        public async Task AddAsync()
        {
            await Servicee.AddUser(Id, FirstName, LastName);
        }

        public async Task DeleteAsync()
        {
            await Servicee.DeleteUser(Id);
        }


    }
}
