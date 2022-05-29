using Service.API;

namespace Presentation.Model;
public class Model
{
    private IService service;
    
    public IService Service
    {
        get { return service; }
    }
}