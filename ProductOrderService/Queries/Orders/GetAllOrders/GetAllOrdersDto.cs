using ProductOrderService.Queries.Orders.GetOrderById;

namespace ProductOrderService.Queries.Orders.GetAllOrders
{
    public class GetAllOrdersDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StorageUntil { get; set; }
        public string Status { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public decimal TotalCost { get; set; }
        public required List<OrderDetailModel> OrderDetails { get; set; }
    }

    public class OrderDetailModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
