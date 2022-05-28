namespace Presentation
{
  public interface ICatalogModel
  {
    string Title { get; set; }
    string Author { get; set; }
    string Id { get; set; }
    string ToString();
  }  
  public interface IDataContexModel
  {
    public IDictionary<string, ICatalogModel> Catalogs { get; }
    public IList<IStateModel> States { get; }
    public IList<IUsersModel> Users { get; }
  }  
  public interface IStateModel
  {
    string BookId { get; }
    string StateId { get; set; }
    bool Available { get; set; }
    string ToString();
  }  
  public interface IUsersModel
  {
    string FirstName { get; set; }
    string LastName { get; set; }
    string Id { get; set; }
    string ToString();
  } 
}
