namespace Data;

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

    public string StateID => state.Stateid;
    public string UserID => user.Id;

    public string EventID { get; set; }
}