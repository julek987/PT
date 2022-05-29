using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    public class RentModel
    {
        public string StateId { get; }
        public string UserId { get; }
        public string Id { get; set; }

        public RentModel(string stateId, string userId)
        {
            StateId = stateId;
            UserId = userId;
        }
    }
}
