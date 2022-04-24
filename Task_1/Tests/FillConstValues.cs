using System;
using Data.API;

namespace Data.Implementation;

//DO WE NEED IT?
internal class FillConstValues : IFill
{
    public void Fill(IDataContext dataContext)
    {
        // Users fill
        dataContext.AddUser(new Users("Tom", "Hanks", "0"));
        dataContext.AddUser(new Users("Denzel", "Washington", "1"));
        dataContext.users.Add(new Users("Morgan", "Freeman", "2"));
        dataContext.users.Add(new Users("Harrison", "Ford", "3"));
        dataContext.users.Add(new Users("Jack", "Nicholson", "4"));

        // Catalog fill
        dataContext.catalogs.Add("0", new Catalog("Le Petit Prince", "Antoine de Saint-Exupéry", "0"));
        dataContext.catalogs.Add("1", new Catalog("From Blood and Ash", "Jennifer L. Armentrout", "1"));
        dataContext.catalogs.Add("2", new Catalog("The Great Gatsby", "F. Scott Fitzgerald", "2"));
        dataContext.catalogs.Add("3", new Catalog("Pride and Prejudice", "Jane Austen", "3"));
        dataContext.catalogs.Add("4", new Catalog("Anna Karenina", "Leo Tolstoy", "4"));

        // State fill
        for (var i = 0; i < 5; i++)
            dataContext.AddState(new State(dataContext.catalogs[i], i + 5, 5 * i, DateTime.Today));

        // Events fill
        for (var i = 0; i < 5; i++)
            dataContext.events.Add(new Event(dataContext.users[i], dataContext.states[i], DateTime.Today));

        //Adding additional data relations (many to one)
        dataContext.events.Add(new Event(dataContext.users[0], dataContext.states[3], DateTime.Today));
        dataContext.events.Add(new Event(dataContext.users[1], dataContext.states[3], DateTime.Today));
        dataContext.events.Add(new Event(dataContext.users[2], dataContext.states[3], DateTime.Today));
        dataContext.events.Add(new Event(dataContext.users[3], dataContext.states[3], DateTime.Today));
    }
}