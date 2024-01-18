using OrderService.Models.Db;
using OrderService.Models.Dto.Requests;

namespace OrderService.Mappers.Interfaces
{
    public interface IDbOrderMapper
    {
        public Order Map(OrderRequest request);
    }
}
