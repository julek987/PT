using System;
using System.Threading.Tasks;
using Presentation.Model.ModelAPI;

namespace Presentation.Model
{
    public class RentModel : IRentModel
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
