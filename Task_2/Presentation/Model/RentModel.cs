using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Presentation.Model
{
    public class RentModel : IRent
    {
        public RentModel(string stateId, string userId, IService service)
        {
            Id = Guid.NewGuid().ToString();
            StateId = stateId;
            UserId = userId;
            Servicee = service;
        }
        public string StateId { get; set;}
        public string UserId { get; set; }
        public string Id { get; set; }

        public IService Servicee { get; }

        public async Task AddAsync()
        {
            await Servicee.AddRent(this);
        }

    }
}
