using Data.API;
using Data;

namespace Service.Implementation
{
    internal class Return : IReturn
    {
        public IState State { get; set; }

        public IUsers User { get; set; }

        public string Id { get; set; }

    }
}
