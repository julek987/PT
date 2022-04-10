namespace Library
{
    //TO FINISH
    public class DataRepository
    {
        private DataContext dataContext;
        private DataFill dataFill;

        public DataRepository(DataContext dataContext, DataFill dataFill)
        {
            this.dataContext = dataContext;
            this.dataFill = dataFill;
        }


    }
}