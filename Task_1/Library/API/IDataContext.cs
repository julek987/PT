namespace Data.API;
public abstract class IDataContext
{
    public abstract void AddUser(IUsers user);

    public abstract void AddState(string id, string title, string author, string stateid);

    public abstract void AddCatalog(ICatalog catalog);

    public abstract void AddRent(IRent rent);

    public abstract void AddReturn(IReturn returnn);
}