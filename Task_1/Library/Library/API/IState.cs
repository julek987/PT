namespace Data;

public interface IState
{
    string BookId { get; }
    string Stateid { get; set; }
}