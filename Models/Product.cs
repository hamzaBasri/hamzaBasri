
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }       
        public ProductType Type { get; set; }
        public string Image { get; set; }
        public DateTime CreationDate { get; set; }
        public bool ShoudBeCreated => Id <= 0;
        public ICollection<ProductProperty> ProductProperties { get; set; }

    }
}
