using EntityFrame.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrame.Persistence.Interfaces
{
    public interface IOrdersRepository
    {
        Task<List<Order>> GetOrdersByCustomerId(int customerId);
        Task<Order?> GetByIdAsync(int id);
    }
}
