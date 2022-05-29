using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;

namespace Data.Implementation
{
    public class RentDTO : IRent
    {
        public string Id { get; set; } = null!;
        public string StateId { get; set; } = null!;

        public string UserId { get; set; } = null!;

    }
}
