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
    public class OrdersRepository : GenericRepository<Order>, IOrdersRepository
    {
        public OrdersRepository(MangaStoreDbContext context) : base(context)
        {
        }

        public async Task<List<Order>> GetOrdersByCustomerId(int customerId)
        {
            return await _context.Orders.Where(order => order.CustomerID == customerId).ToListAsync();
        }
    }
}
