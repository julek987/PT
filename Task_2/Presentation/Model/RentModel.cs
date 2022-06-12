using System;
using System.Threading.Tasks;
using Presentation.Model.ModelAPI;
using Service.API;

namespace Presentation.Model
{
    public class RentModel : IRentModel
    {
        public RentModel(string stateId, string userId)
        {
            Id = Guid.NewGuid().ToString();
            StateId = stateId;
            UserId = userId;

            Servicee = IService.Create();
        }
        public string StateId { get; set;}
        public string UserId { get; set; }
        public string Id { get; set; }

        public IService Servicee { get; }

        public async Task AddAsync()
        {
            await Servicee.AddRent(Id, StateId, UserId);
        }

    }
}
