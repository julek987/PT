using Data.API;

namespace Data.Implementation;

//DO WE NEED IT?
internal class EmptyFill : IFill
{
    public override void Fill(IDataContext datacontext)
    {
    }
}