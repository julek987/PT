using Service.API;

namespace Presentation.Model;
public interface IModel
{
    IService Service
    {
        get;
    }
}