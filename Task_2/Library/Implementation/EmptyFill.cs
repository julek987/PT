using Data.API;

namespace Data.Implementation;
internal class EmptyFill : IFill
{
    public override void Fill(IDataRepository dataRepository)
    {
    }
}