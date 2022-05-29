using Service.API;
using Data.API;

namespace Service.Implementation
{
    public class DataService : IService
    {
        private IDataRepository dataRepository;

        internal  DataService(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

    }
}