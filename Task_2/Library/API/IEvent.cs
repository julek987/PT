namespace Data.API;

public interface IEvent
{
    string Id { get; set; }
    string StateId { get; }
    string UserId { get; }
}