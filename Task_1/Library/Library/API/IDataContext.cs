namespace Data.API;

public abstract class IDataContext
{
    public abstract void AddUser(IUsers user);

    public abstract void AddState(string id, string title, string author, string stateid);
}