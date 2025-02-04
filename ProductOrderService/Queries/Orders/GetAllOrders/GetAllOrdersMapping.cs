using AutoMapper;
using ProductOrderService.Models;

namespace ProductOrderService.Queries.Orders.GetAllOrders
{
    public class GetAllOrdersMapping : Profile
    {
        public GetAllOrdersMapping() 
        {
            CreateMap<Order, GetAllOrdersDto>();
            CreateMap<OrderDetail, OrderDetailModel>();
        }
    }
}
