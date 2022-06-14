using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Models
{
    public class Product:BaseEntity
    {
        public string Image { get; set; }
        [NotMapped]
        public string Img { get; set; }
        public string Text { get; set; }
        public string OldPrice { get; set; }
        public string DiscountPer { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
