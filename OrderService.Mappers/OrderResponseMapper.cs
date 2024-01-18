using OrderService.Mappers.Interfaces;
using OrderService.Models.Db;
using OrderService.Models.Dto.Responses;

namespace OrderService.Mappers
{
    public class OrderResponseMapper : IOrderResponseMapper
    {
        public OrderResponse Map(Order order)
        {
            return new()
            {
                Id = order.Id,
                CitySender = order.CitySender,
                AddressSender = order.AddressSender,
                CityRecipient = order.CityRecipient,
                AddressRecipient = order.AddressRecipient,
                WeightCargo = order.WeightCargo.ToString(),
                DateDispatch = order.DateDispatch
            };
        }
    }
}
