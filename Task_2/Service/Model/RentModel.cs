using Service.API;

namespace Service.Model
{
    internal class RentModel : IRent
    {
        public IState State { get; set; }

        public IUsers User { get; set; }

        public string Id { get; set; }
    }
}
