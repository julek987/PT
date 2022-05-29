using Service.API;
using Data.API;

namespace Service.Implementation
{
    public class Service : IService
    {
        private IDataRepository dataRepository;

        internal  Service(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

    }
}