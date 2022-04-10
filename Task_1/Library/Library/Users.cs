namespace Data
{
    //OK
    internal class Users
    {
        private string firstName;
        private string lastName;
        private string id; 

        internal Users(string id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;   
        }

        internal string FirstName { get => firstName; set => firstName = value; }
        internal string LastName { get => lastName; set => lastName = value;}
        internal string Id { get => id;  set => id = value;}

    }
}
