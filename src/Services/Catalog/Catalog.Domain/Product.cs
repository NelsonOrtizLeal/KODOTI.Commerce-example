namespace Catalog.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ProductInStock Stock { get; set; }

        // Para crear una relacion de 1 - 1 con ProductInStock
        // public ProductInStock Stock { get; set; }

        // Para crear una relacion de 1 - muchos con ProductInStock
        // public List<ProductInStock> Stock { get; set; }
    }
}
