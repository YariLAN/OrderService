using OrderService.Mappers.Interfaces;
using OrderService.Models.Db;
using OrderService.Models.Dto.Requests;

namespace OrderService.Mappers
{
    public class DbOrderMapper : IDbOrderMapper
    {
        public Order Map(OrderRequest request)
        {
            return new()
            {
                CitySender = request.CitySender,
                AddressSender = request.AddressSender,
                CityRecipient = request.CityRecipient,
                AddressRecipient = request.AddressRecipient,
                WeightCargo = double.Parse(request.WeightCargo),
                DateDispatch = request.DateDispatch
            };
        }
    }
}
