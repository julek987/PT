namespace Library
{
    public class State
    {
        private Catalog Cata;
        private int amount;
        private float price; //or double zamiast float
        private DateTime purchase_date;

        public State(Catalog cata, int amount, float price, DateTime purchase_date)
        {
            Cata = cata;
            this.amount = amount;
            this.price = price;
            this.purchase_date = purchase_date;
        }
        public Catalog Cata2 { get { return Cata; } set => Cata = value; }
        public int Amount { get { return amount; } set => amount = value; }
        public float Price { get { return price; } set => price = value; }
        public DateTime Purchase_date { get { return purchase_date; } set => purchase_date = value; }
        public string All { get => this.Cata.All + " " + Purchase_date + " " + Amount + " " + Price;}
        public override bool Equals(object obj) 
        {
            if(obj is State)
            {
                State other = obj as State; //or (State)obj;
                return this.Cata.Equals(other.Cata) && this.purchase_date == other.purchase_date;
            }
            return base.Equals(obj);
        }
        
    }
}
