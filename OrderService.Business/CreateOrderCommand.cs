using OrderService.Business.Interfaces;
using OrderService.Data.Interfaces;
using OrderService.Mappers.Interfaces;
using OrderService.Models.Dto.Requests;

namespace OrderService.Business
{
    public class CreateOrderCommand : ICreateOrderCommand
    {
        private readonly IDbOrderMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public CreateOrderCommand(
            IOrderRepository orderRepository,
            IDbOrderMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<int?> ExecuteAsync(OrderRequest request, CancellationToken ct)
        {
            var dbOrder = _mapper.Map(request);

            return await _orderRepository.CreateAsync(dbOrder, ct);
        }
    }
}
