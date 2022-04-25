using System.Runtime.CompilerServices;
using Logic.Implementation;
[assembly:InternalsVisibleTo("Tests")]
namespace Logic.API;

public abstract class IBusinessLogic
{
    public abstract void BorrowBook(string userId, string stateId);

    public abstract void ReturnBook(string stateId);
    
}