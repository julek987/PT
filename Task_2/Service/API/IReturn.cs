namespace Service.API;

public interface IReturn
{
    string Id { get; set; }
    public string StateId { get; set; }
    public string UserId { get; set; }

    Task AddAsync();
}