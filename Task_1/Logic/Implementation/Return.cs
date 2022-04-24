using Data.API;

namespace Data.Implementation;

internal class Return : IReturn
{
    public Return(string stateId, string userId)
    {
        StateId = stateId;
        UserId = userId;
    }

    public string StateId { get; }
    public string UserId { get; }
}