using Data.API;
using Data.Implementation;
using Logic.API;

namespace Logic.Implementation;

internal class BusinessLogic : IBusinessLogic
{
    private IDataRepository DataRepo;

    public BusinessLogic(IDataRepository dataRepo)
    {
        DataRepo = dataRepo;
    }

    public override void BorrowBook(string userId, string stateId)
    {
        if(!DataRepo.IsAvailable(stateId)) throw new InvalidOperationException("Can't rent a book that isn't available");
        IRent rent = new Rent(stateId, userId);
        DataRepo.AddEvent(rent);
        DataRepo.ChangeAvailability(stateId);
    }

    public override void ReturnBook(string userId, string stateId)
    {   if (DataRepo.IsAvailable(stateId)) throw new InvalidOperationException("Can't return book that wasn't rent");
        DataRepo.AddEvent(new Return(stateId, userId));
        DataRepo.ChangeAvailability(stateId);
    }
}