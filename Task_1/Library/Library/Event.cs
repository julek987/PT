namespace Data
{
    internal class Event
    {
        protected State state;
        protected Users user;
        internal string BookID => state.BookId;
        internal string UserID => user.Id;

        internal Event(Users user, State state)
        {
            this.user = user;
            this.state = state;
        }
      
    }
}
