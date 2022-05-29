using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    internal class CatalogModel
    {
        public CatalogModel(string id, string title, string author)
        {
            Title = title;
            Author = author;
            Id = id;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Id { get; set; }
    }
}
