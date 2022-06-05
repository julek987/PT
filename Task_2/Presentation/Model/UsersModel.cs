using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Presentation.Model
{
    public class UsersModel : Service.API.IUsers
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
