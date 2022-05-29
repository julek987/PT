using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;

namespace Presentation
{
    public interface ICatalogModel
    {
        public string Title { get; }
        public string Author { get; }
        public string Id { get; }
    }

    public interface IStateModel
    {
        public ICatalog Catalog { get; set; }
        string Id { get; }
        bool Available { get; set; }
    }
    public interface IUsersModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Id { get; set; }
    }
    public interface IRentModel
    {
        string StateId { get; }
        string UserId { get; }
    }
    public interface IReturnModel
    {
        string StateId { get; }
        string UserId { get; }
    }
    public interface IDataContexModel
    {
        public IList<IUsersModel> Users { get; }
        public IList<IStateModel> States { get; }
        public IList<ICatalogModel> Catalogs { get; }
    }

}
