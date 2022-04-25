using System.Runtime.CompilerServices;
using Data.API;
using Logic.Implementation;
[assembly:InternalsVisibleTo("Tests")]
namespace Logic.API;

public abstract class IBusinessLogic
{
    public abstract void BorrowBook(string userId, string stateId);

    public abstract void ReturnBook(string userId, string stateId);

    public static IBusinessLogic CreateLogic(IDataRepository? dataRepository = default)
    {
        return new BusinessLogic(dataRepository ?? IDataRepository.CreateDataRepository());
    }
}