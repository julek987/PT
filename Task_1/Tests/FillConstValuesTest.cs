using System;
using Data.API;
using Data.Implementation;

namespace TestProject1;
internal class FillConstValuesTest : IFill
{
    public override void Fill(IDataContext dataContext)
    {
        // Users fill
        dataContext.AddUser(new Users("0","Tom", "Hanks"));
        dataContext.AddUser(new Users("1","Denzel", "Washington"));
        dataContext.AddUser(new Users("2","Morgan", "Freeman"));
        dataContext.AddUser(new Users("3","Harrison", "Ford"));
        dataContext.AddUser(new Users("4","Jack", "Nicholson"));

        // Catalog fill
        dataContext.AddCatalog(new Catalog("0","Le Petit Prince", "Antoine de Saint-Exupéry"));
        dataContext.AddCatalog(new Catalog("1","From Blood and Ash", "Jennifer L. Armentrout"));
        dataContext.AddCatalog(new Catalog("2","The Great Gatsby", "F. Scott Fitzgerald"));
        dataContext.AddCatalog(new Catalog("3","Pride and Prejudice", "Jane Austen"));
        dataContext.AddCatalog(new Catalog("4","Anna Karenina", "Leo Tolstoy"));

        // State fill
        dataContext.AddState("0","Le Petit Prince", "Antoine de Saint-Exupéry", "0");
        dataContext.AddState("0","Le Petit Prince", "Antoine de Saint-Exupéry", "1");
        dataContext.AddState("0","Le Petit Prince", "Antoine de Saint-Exupéry", "2");
        dataContext.AddState("1","From Blood and Ash", "Jennifer L. Armentrout","3");
        dataContext.AddState("1","From Blood and Ash", "Jennifer L. Armentrout","4");
        dataContext.AddState("1","From Blood and Ash", "Jennifer L. Armentrout","5");

        // Events fill
        dataContext.AddRent(new Rent("0", "0"));
        dataContext.AddRent(new Rent("1", "1"));
        dataContext.AddRent(new Rent("2", "2"));
        dataContext.AddReturn(new Return("0", "0"));
    }
}