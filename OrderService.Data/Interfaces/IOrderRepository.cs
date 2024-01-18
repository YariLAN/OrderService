using OrderService.Models.Db;

namespace OrderService.Data.Interfaces
{
    public interface IOrderRepository
    {
        public Task<int> CreateAsync(Order order, CancellationToken ct);

        public Task<List<Order>> GetOrdersAsync(CancellationToken ct);

        public Task<Order?> GetOrderAsync(int id, CancellationToken ct);
    }
}
