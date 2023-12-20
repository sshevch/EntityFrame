using EntityFrame.Entities;

namespace EntityFrame.Persistence.Interfaces
{
    public interface IOrderDetailsRepository
    {
        Task<List<OrderDetail>> GetOrderDetailsByOrderId(int orderId);
        Task<OrderDetail> GetOrderDetailsById(int orderDetailId);
        Task DeleteAsync(int id);
    }
}
