namespace Data;

public interface IEvent
{
    string StateID { get; }
    string UserID { get; }
    string EventID { get; set; }
}