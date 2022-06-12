namespace Data.API;

public interface IReturn
{
    public IState State{ get;}
    public IUsers User{ get;}
    string Id { get; }
}