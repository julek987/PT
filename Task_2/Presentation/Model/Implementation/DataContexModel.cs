namespace Presentation;

public class DataContexModel : IDataContexModel
{
    public IDictionary<string, ICatalogModel> Catalogs
    {
        get
        {
            Dictionary<string, ICatalogModel> Catalogs = new Dictionary<string, ICatalogModel>()
            {
            };
            return Catalogs;
        }
    }
    public IList<IStateModel> States
    {
        get
        {
            List<IStateModel> States = new List<IStateModel>()
            {
            };
            return States;
        }
    }
    public IList<IUsersModel> Users
    {
        get
        {
            List<IUsersModel> Users = new List<IUsersModel>()
            {
            };
            return Users;
        }
    }
    
}