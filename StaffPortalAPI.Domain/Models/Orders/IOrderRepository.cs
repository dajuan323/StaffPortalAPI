using StaffPortalAPI.Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Domain.Models.Orders
{
    public interface IOrderRepository
    {
        Task<Order?> GetByIdAsync(OrderId id);

        void Add(Order order);
    }
}
