namespace Presentation;

public class UsersModel : IUsersModel
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Id { get; set; }

    public override string ToString()
    {
        return Id + " " + FirstName + " " + LastName;
    }

}