using Data.API;
using Data.Implementation;
using Logic.API;

namespace Logic.Implementation;

internal class BusinessLogic : IBusinessLogic
{
    private readonly IDataRepository _data;

    public override void BorrowBook(string userId, string stateId)
    {
        if(stateId == null) throw new InvalidOperationException("Can't rent a book that isn't available");
        _data.AddEvent(new Rent(userId, stateId));
    }

    public override void ReturnBook(string userId, string stateId)
    {   if (stateId == null) throw new InvalidOperationException("Can't return book that wasn't rent");
        _data.AddEvent(new Return(userId, stateId));
    }
}