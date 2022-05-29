using Service.API;

namespace Presentation;
public class Model
{
    private IService service;
    
    public IService Service
    {
        get { return service; }

    }
    /*
    public Model(IService service = default(IService))
    {
        if (service == null)
        {
            this.service = DataServiceFactory.CreateService();
        }
        else
        {
            this.service = service;
        }
    }
    */
}