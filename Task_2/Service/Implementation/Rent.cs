using Data;
using Data.API;

namespace Service.Implementation
{
    internal class Rent : IRent
    {
        public IState State
        {
            get; set;
        }

        public IUsers User
        {
            get; set;
        }

        public string Id { get; set; }

    }
}