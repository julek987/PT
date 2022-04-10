namespace Library
{
    public class Event
    {
        private Users U;
        private State S;
        private DateTime Purchase_Date;

        public Event(Users u, State s, DateTime purchase_date)
        {
            U = u;
            S = s;
            Purchase_date = purchase_date;
        }

        public Users u { get { return U}, set => U = value;}
        public State s { get { return S}, set => S = value;}
        public DateTime Purchase_date { get { return Purchase_Date}, set => Purchase_Date = value;}
        public string Final { get { return this.U.Final + " " + this.S.Final + " " + Purchase_date;}

        public override bool Equals(object obj)
        {
            if (obj is Event)
            {
                Event other = obj as Event;
                return this.U.Equals(other.U) && this.Purchase_Date == other.Purchase_Date;
            }
            return base.Equals(obj);
        }
    }
}
