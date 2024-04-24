using Microsoft.EntityFrameworkCore;
using StaffPortalAPI.Domain.Models.Orders;
using StaffPortalAPI.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Persistence.Repositories
{
    internal sealed class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _appContext;
        public OrderRepository(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }
        public void Add(Order order)
        {
            _appContext.Add(order);
        }

        public Task<Order?> GetByIdAsync(OrderId id)
        {
            return _appContext.Orders
                .Include(o => o.LineItems)
                .SingleOrDefaultAsync(o => o.Id == id);
        }
    }
}
