using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;

namespace Data.Implementation
{
    internal class UsersDTO : IUsers
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Id { get; set; } = null!;
    }
}
