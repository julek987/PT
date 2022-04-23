namespace Data
{
    //OK
    internal class Users : IUsers
    {
        private string firstName;
        private string lastName;
        private string id; 

        public Users(string id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;   
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value;}
        public string Id { get => id;  set => id = value;}

    }
}
