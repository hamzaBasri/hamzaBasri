using System.Collections.Generic;

namespace Models
{
    public class ProductType 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Property> Properties { get; set; }
        public bool ShoudBeCreated => Id == 0;
    }
}
