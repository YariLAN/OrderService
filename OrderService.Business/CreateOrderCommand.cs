using OrderService.Business.Interfaces;
using OrderService.Models.Dto.Requests;

namespace OrderService.Business
{
    public class CreateOrderCommand : ICreateOrderCommand
    {
        public Task<int?> ExecuteAsync(OrderRequest request, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
