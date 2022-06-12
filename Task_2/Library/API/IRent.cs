namespace Data.API;
public interface IRent 
{
    public IState State{ get; }
    public IUsers User{ get;}
    string Id { get; }
}