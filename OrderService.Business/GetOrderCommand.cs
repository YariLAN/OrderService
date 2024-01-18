using OrderService.Business.Interfaces;
using OrderService.Data.Interfaces;
using OrderService.Mappers.Interfaces;
using OrderService.Models.Db;
using OrderService.Models.Dto.Responses;

namespace OrderService.Business
{
    public class GetOrderCommand : IGetOrderCommand
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderResponseMapper _mapper;

        public GetOrderCommand(
            IOrderRepository orderRepository,
            IOrderResponseMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<OrderResponse?> ExecuteAsync(int id, CancellationToken ct)
        {
            Order? dbOrder = await _orderRepository.GetOrderAsync(id, ct);

            return _mapper.Map(dbOrder);
        }
    }
}
