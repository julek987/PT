using Data.API;

namespace Data.Implementation;

internal class Rent : IRent
{
    public string StateId { get; }
    public string UserId { get; }
    
    public Rent(string stateId, string userId)
    {
        StateId = stateId;
        UserId = userId;
    }
}