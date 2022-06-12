using System.Runtime.CompilerServices;
using Data.Implementation;
[assembly:InternalsVisibleTo("Tests")]
namespace Data.API;

public interface IDataRepository
{
    public static IDataRepository CreateDataRepository(IFill? fill = default)
    {
        return new DataRepository(fill ?? new EmptyFill());
    }
}