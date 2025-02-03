namespace ProductOrderService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StorageUntil { get; set; }
        public string Status { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public decimal TotalCost { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
