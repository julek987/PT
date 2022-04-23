namespace Data;

//OK
internal class Users : IUsers
{
    public Users(string id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Id { get; set; }
}