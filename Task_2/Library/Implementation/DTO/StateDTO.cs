﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;
namespace Data.Implementation
{
    public class StateDTO : IState
    {
        public string Id { get; init; }

        [ForeignKey(nameof(Catalog))]
        public string CatalogDTOId { get; set; }

        public ICatalog Catalog { get; set; }
        public bool Available { get; set; }
    }
}