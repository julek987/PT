namespace Data;

public interface IEvent
{
    string StateId { get; }
    string UserId { get; }
    string EventId { get; set; }
}