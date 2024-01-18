using OrderService.Models.Db;
using OrderService.Models.Dto.Responses;

namespace OrderService.Business.Interfaces
{
    public interface IGetOrdersCommand
    {
        public Task<List<OrderResponse?>> ExecuteAsync(CancellationToken ct);
    }
}
