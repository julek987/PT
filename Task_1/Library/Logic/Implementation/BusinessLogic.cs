using Data.API;
using Logic.API;

namespace Logic.Implementation;

internal class BusinessLogic : IBusinessLogic
{
    private readonly IDataRepository _data;

    public override bool BorrowBook(string userId, string stateId)
    {
        throw new NotImplementedException(); 
    }

    public override void ReturnBook(string stateId)
    {
        throw new NotImplementedException();
    }
}