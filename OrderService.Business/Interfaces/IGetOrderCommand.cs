using OrderService.Models.Dto.Responses;

namespace OrderService.Business.Interfaces
{
    public interface IGetOrderCommand
    {
        public Task<OrderResponse> ExecuteAsync(int id, CancellationToken ct);
    }
}
