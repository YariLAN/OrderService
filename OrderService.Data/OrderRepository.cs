using Microsoft.EntityFrameworkCore;
using OrderService.Data.Interfaces;
using OrderService.Models.Db;
using OrderService.Provider;

namespace OrderService.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrdersDbContext _provider;

        public OrderRepository(OrdersDbContext provider)
        {
            _provider = provider;
        }

        public async Task<int> CreateAsync(Order order, CancellationToken ct)
        {
            _provider.Orders.Add(order);

            await _provider.SaveChangesAsync(ct);

            return order.Id;
        }

        public async Task<Order?> GetOrderAsync(int id, CancellationToken ct)
        {
            var order = await _provider.Orders.FindAsync(id, ct);

            return order;
        }

        public async Task<List<Order>> GetOrdersAsync(CancellationToken ct)
        {
            var orders = await _provider.Orders.AsNoTracking().ToListAsync(ct);

            return orders;
        }
    }
}
