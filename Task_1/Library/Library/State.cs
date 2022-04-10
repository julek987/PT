namespace Library
{
    public class State
    {
        private Catalog Cata;
        private int amount;
        private float price; //or double zamiast float

        public State(Catalog cata, int amount, float price)
        {
            Cata = cata;
            this.amount = amount;
            this.price = price;
        }
        public Catalog Cata2 { get { return Cata; } set => Cata = value; }
        public int Amount { get { return amount; } set => amount = value; }
        public float Price { get { return price; } set => price = value; }
        public string All { get => this.Cata.All + " " + Amount + " " + Price;}
        public override bool Equals(object obj) 
        {
            if(obj is State)
            {
                State other = obj as State; //or (State)obj;
                return this.Cata.Equals(other.Cata);
            }
            return base.Equals(obj);
        }
        
    }
}
