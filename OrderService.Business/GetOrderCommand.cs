using OrderService.Business.Interfaces;
using OrderService.Models.Dto.Responses;

namespace OrderService.Business
{
    public class GetOrderCommand : IGetOrderCommand
    {
        public async Task<OrderResponse> ExecuteAsync(int id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
