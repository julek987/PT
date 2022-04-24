using Logic.Implementation;

namespace Logic.API;

public abstract class IBusinessLogic
{
    public abstract bool BorrowBook(string userId, string stateId);

    public abstract void ReturnBook(string stateId);
    
}