using Service.API;

namespace Service.Model
{
    internal class UsersModel : IUsers
    {
        public UsersModel(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Id { get; set; }
    }
}
