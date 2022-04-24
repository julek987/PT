namespace Data.API;

public interface IState
{
    string BookId { get; }
    string StateId { get; set; }
    bool Available { get; set; }
}