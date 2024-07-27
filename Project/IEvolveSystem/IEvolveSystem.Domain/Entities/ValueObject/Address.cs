using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEvolveSystem.Domain.Entities.ValueObject
{
    public class Address
    {
        public int CustomerId { get; set; }
        public string? Street { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
    }
}
