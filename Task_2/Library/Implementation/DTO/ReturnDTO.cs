using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;
namespace Data.Implementation
{
    internal class ReturnDTO : IReturn
    {
        public IState State{ get; set;}

        public IUsers User { get; set;}

        public string Id { get; set; }

    }
}
