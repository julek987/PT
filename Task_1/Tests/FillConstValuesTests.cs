using System;
using Data;
using Data.API;
using Data.Implementation;
using Xunit;

namespace TestProject1;

public class FillConstValuesTests
{
    
    [Fact]
    public void testFill()
    {
        var datarepo = IDataRepository.CreateDataRepository(new FillConstValues());
        Assert.True(datarepo.UserExists("0"));
        Assert.False(datarepo.UserExists("5"));
    }
}