using MediatR;
using ProductOrderService.Models;

namespace OrderManagmentService.Commands.Orders.CreateOrder
{
    public class CreateOrderCommand : IRequest<CreateOrderDto>
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StorageUntil { get; set; }
        public string Status { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public decimal TotalCost { get; set; }
        public required List<Order> OrderDetails { get; set; }
    }
}
