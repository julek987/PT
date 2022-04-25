using Data.API;

namespace Logic.Implementation;

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