using OrderService.Models.Db;
using OrderService.Models.Dto.Responses;

namespace OrderService.Mappers.Interfaces
{
    public interface IOrderResponseMapper
    {
        public OrderResponse Map(Order order);
    }
}
