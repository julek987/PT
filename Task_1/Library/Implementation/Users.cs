namespace Data.Implementation;

internal class Users : IUsers
{
    public Users(string id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Id { get; set; }
}