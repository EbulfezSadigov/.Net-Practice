using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
