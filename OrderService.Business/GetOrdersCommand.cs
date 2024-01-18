using OrderService.Business.Interfaces;
using OrderService.Data.Interfaces;
using OrderService.Mappers.Interfaces;
using OrderService.Models.Dto.Responses;

namespace OrderService.Business
{
    public class GetOrdersCommand : IGetOrdersCommand
    {
        private readonly IOrderRepository _repository;
        private readonly IOrderResponseMapper _mapper;

        public GetOrdersCommand(
            IOrderRepository repository,
            IOrderResponseMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<OrderResponse>> ExecuteAsync(CancellationToken ct)
        {
            var dbOrders = await _repository.GetOrdersAsync(ct);

            return dbOrders.ConvertAll(converter: x => _mapper.Map(x));
        }
    }
}
