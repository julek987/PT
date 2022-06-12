using Service.API;

namespace Service.Model
{
    internal class ReturnModel : IReturn
    {
        public string StateId { get; set; }

        public string UserId { get; set; }

        public string Id { get; set; }

        public IService Servicee { get; }

        public async Task AddAsync()
        {
            await Servicee.AddReturn(Id, StateId, UserId);
        }
    }
}
