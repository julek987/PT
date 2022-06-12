using Service.API;

namespace Service.Model
{
    internal class RentModel : IRent
    {
        public string StateId { get; set; }

        public string UserId { get; set; }

        public string Id { get; set; }

        public IService Servicee { get; }
        public async Task AddAsync()
        {
            await Servicee.AddRent(Id, StateId, UserId);
        }
    }
}
