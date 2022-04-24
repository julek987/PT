namespace Data.Implementation;

//OK
internal class Event : IEvent
{
    protected State state;
    protected Users user;

    public Event(Users user, State state)
    {
        this.user = user;
        this.state = state;
    }

    public string StateId => state.Stateid;
    public string UserId => user.Id;

    public string EventId { get; set; }
}