using OrderService.Models.Dto.Requests;

namespace OrderService.Business.Interfaces
{
    public interface ICreateOrderCommand
    {
        public Task<int?> ExecuteAsync(OrderRequest request, CancellationToken ct);
    }
}
