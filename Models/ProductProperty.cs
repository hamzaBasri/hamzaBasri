namespace Models
{
    public class ProductProperty
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }
        public int OptionId { get; set; }
        public PropertyOption Option { get; set; }
    }
}
