/*using Data.API;

namespace Data.Implementation;

//DO WE NEED IT?
internal class FillRandom : IFill
{
    public static int SIZE = 20;

    private static readonly Random random = new();

    public override void Fill(IDataContext dataContext)
    {
        for (var i = 0; i < SIZE; i++)
        {
            //dataContext.users.Add(new Users(RandomString(),"Kowalski", "1"));
            Console.Write(random);
            Console.Write("hi");
        }
    }

    public static string RandomString(int length)
    {
        const string str = "I LOVE PROGRAMMING";
        return new string(Enumerable.Repeat(str, length).Select(s => s[random.Next(s.Length)]).ToArray());
    }
}*/