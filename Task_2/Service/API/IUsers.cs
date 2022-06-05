namespace Service.API;

public interface IUsers
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string Id { get; set; }

    Task AddAsync();
    Task DeleteAsync();
}