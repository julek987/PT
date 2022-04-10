namespace Data
{
    //TO FINISH
    public class DataService
    {
        private DataRepository dataRepository;
        public DataService(DataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public void Display(IEnumerable<Users> users)
        {
            List<Users> usersList = users.ToList<Users>();
            for(int i=0; i<users.Count(); i++)
            {
                Console.WriteLine(usersList[i].All);
            }
        }

    }
}
