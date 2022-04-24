using Data.API;
using Data.Implementation;
using Logic.API;

namespace Logic.Implementation;

internal class BusinessLogic : IBusinessLogic
{
    private readonly IDataRepository _data;

    public override void BorrowBook(string stateId, string userId)
    {
        _data.AddEvent(new Rent(stateId, userId));
    }

    public override void ReturnBook(string stateId)
    {
        throw new NotImplementedException();
    }
}