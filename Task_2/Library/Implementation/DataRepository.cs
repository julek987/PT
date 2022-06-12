using Data.API;
namespace Data.Implementation;
internal class DataRepository : IDataRepository
{
    private readonly DataContext dataContext;
    IDataContext context = IDataContext.CreateContext();
    public DataRepository(IFill dataFill)
    {
        dataContext = new DataContext();
        dataFill.Fill(this);
    }
}