using AutoMapper;
using ProductOrderService.Models;

namespace ProductOrderService.Queries.Orders.GetOrderById
{
    public class GetOrderByIdMapping : Profile
    {
        public GetOrderByIdMapping() 
        {
            CreateMap<Order, GetOrderByIdDto>();
            CreateMap<OrderDetail, OrderDetailModel>();
        }
    }
}
