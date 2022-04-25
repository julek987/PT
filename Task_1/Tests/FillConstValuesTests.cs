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
        Assert.True(datarepo.UserExists("4"));
        Assert.False(datarepo.UserExists("5"));
        Assert.True(datarepo.CatalogExists("1"));
        Assert.False(datarepo.CatalogExists("10"));
        Assert.True(datarepo.StateExists("0"));
        Assert.False(datarepo.StateExists("7"));
        Assert.Throws<Exception>(() => datarepo.DeleteUserWithId("1"));
        datarepo.DeleteUserWithId("4");
        Assert.False(datarepo.UserExists("4"));
    }
}