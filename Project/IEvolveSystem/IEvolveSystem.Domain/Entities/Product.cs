using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEvolveSystem.Domain.Entities
{
    public class Product
    {
        /*
         The property must have the same name and same data type as the database column, because of the entity
         framework core aproach we are going to use
         */
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }
}
