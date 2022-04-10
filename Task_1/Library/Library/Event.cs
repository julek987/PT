namespace Data
{
    public class Event
    {
        private Users U;
        private State S;
        private DateTime purchase_date;

        public Event(Users u, State s, DateTime purchase_date)
        {
            U = u;
            S = s;
            Purchase_date = purchase_date;
        }

        public Users u { get { return U; } set => U = value;}
        public State s { get { return S; } set => S = value;}
        public DateTime Purchase_date { get { return purchase_date; } set => purchase_date = value;}
        public string All
        {
            get { return this.U.All + " " + this.S.All + " " + Purchase_date; }

        }
        public override bool Equals(object obj)
        {
            if (obj is Event)
            {
                Event other = obj as Event;
                return this.U.Equals(other.U) && this.purchase_date == other.purchase_date;
            }
            return base.Equals(obj);
        }
    }
}
