using Data.API;

namespace Data.Implementation;

internal class Rent : IRent
{
    public string StateId { get; }
    public string UserId { get; }
    public bool Available { get; }

   // if(bool Available == true){};

    public Rent(string stateId, string userId)
    {
        StateId = stateId;
        UserId = userId;
    }
}