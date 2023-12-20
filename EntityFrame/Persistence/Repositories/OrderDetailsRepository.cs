using EntityFrame.Entities;
using EntityFrame.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrame.Persistence.Repositories
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(MangaStoreDbContext context) : base(context)
        {
        }

        public async Task<OrderDetail?> GetOrderDetailsById(int orderDetailId)
        {
            return await _context.OrderDetails.FirstOrDefaultAsync(orderDetail => orderDetail.OrderDetailID == orderDetailId);
        }

        public async Task<List<OrderDetail>> GetOrderDetailsByOrderId(int orderId)
        {
            return await _context.OrderDetails
                .Where(detail => detail.OrderID == orderId)
                .Include(detail => detail.Manga)
                .Include(detail => detail.Order)
                .ToListAsync();
        }
    }
}
