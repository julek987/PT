namespace Data.API;

public interface IRent : IEvent
{
    string StateId { get; }
    string UserId { get; }
    bool Available { get; }
}