namespace ProductOrderService.Queries.Products.GetProductById
{
    public class GetProductByIdDto
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
