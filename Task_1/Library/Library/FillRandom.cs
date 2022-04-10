namespace Data
{
    class FillRandom : DataFill
    {
        public FillRandom() { }

        public static int SIZE = 20;

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string str = "I LOVE PROGRAMMING";
            return new string(Enumerable.Repeat(str, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void Fill(DataContext dataContext)
        {
            for (int i = 0; i < SIZE; i++)
            {
                //dataContext.users.Add(new Users(RandomString(),"Kowalski", "1"));
                Console.Write(random);
                Console.Write("hi");
            }
        }
    }

}
