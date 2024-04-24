using StaffPortalAPI.Domain.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Domain.Models.Products
{
    public interface IProductRepository
    {

        List<Product> GetAll();

        void Add(Product product);

        void Remove(Product product);
    }
}
