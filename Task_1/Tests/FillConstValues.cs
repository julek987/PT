using System;
using Data.API;
using Data.Implementation;
using Logic.Implementation;

namespace TestProject1;
internal class FillConstValues : IFill
{
    public override void Fill(IDataRepository dataRepo)
    {
        // Users fill
        dataRepo.AddUser(new Users("0","Tom", "Hanks"));
        dataRepo.AddUser(new Users("1","Denzel", "Washington"));
        dataRepo.AddUser(new Users("2","Morgan", "Freeman"));
        dataRepo.AddUser(new Users("3","Harrison", "Ford"));
        dataRepo.AddUser(new Users("4","Jack", "Nicholson"));

        // Catalog fill
        ICatalog catalog1 = new Catalog("0", "Le Petit Prince", "Antoine de Saint-Exupéry");
        dataRepo.AddCatalog(catalog1);
        ICatalog catalog2 = new Catalog("1","From Blood and Ash", "Jennifer L. Armentrout");
        dataRepo.AddCatalog(catalog2);
        ICatalog catalog3 = new Catalog("2","The Great Gatsby", "F. Scott Fitzgerald");
        dataRepo.AddCatalog(catalog3);
        ICatalog catalog4 = new Catalog("3","Pride and Prejudice", "Jane Austen");
        dataRepo.AddCatalog(catalog4);
        ICatalog catalog5 = new Catalog("4","Anna Karenina", "Leo Tolstoy");
        dataRepo.AddCatalog(catalog5);

        // State fill
        IState state1 = new State("0", catalog1);
        IState state2 = new State("1", catalog1);
        IState state3 = new State("2", catalog1);
        dataRepo.AddState(state1);
        dataRepo.AddState(state2);
        dataRepo.AddState(state3);

        // Events fill
        dataRepo.AddEvent(new Rent("0", "0"));
        dataRepo.AddEvent(new Rent("1", "1"));
        dataRepo.AddEvent(new Rent("2", "2"));
        dataRepo.AddEvent(new Return("0", "0"));
    }
}