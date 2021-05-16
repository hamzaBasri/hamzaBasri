using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public decimal Cost { get; set; }
        public bool HasCost => Cost > 0;
        public bool ShoudBeCreated => Id == 0;
        
        public ICollection<ProductProperty> ProductProperties { get; set; }
        public ICollection<PropertyOption> Options { get; set; }

    }
}
