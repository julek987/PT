namespace Library
{
    public class Users
    {
        private string firstName;
        private string lastName;
        private string id; //moze jednak int??

        public Users(string firstName, string lastName, string id)
        {
            this.firstName = firstName;
            this.lastName = lastName;   
            this.id = id;
        }

        public string FirstName { get { return firstName; } set => firstName = value;}
        public string LastName { get { return lastName; } set => lastName = value;}
        public string Id { get { return id; } set => id = value;}
        public string All { get => id + " " +  firstName + " " + lastName; }

        public override bool Equals(object obj)
        {
            Users other = obj as Users;
            return this.Id == other.Id;
        }
    }
}
