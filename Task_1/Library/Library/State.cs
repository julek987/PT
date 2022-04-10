namespace Data
{
    //OK
    internal class State
    {
        protected Catalog catalog;
        private string amount;
        private float price;

        internal State(string amount, float price)
        {
            this.amount = amount;
            this.price = price;
        }
        
        internal string BookId => catalog.ID;
        internal string Amount { get => amount; set => amount = value; }
        internal float Price { get => price; set => price = value; }
        
    }
}
