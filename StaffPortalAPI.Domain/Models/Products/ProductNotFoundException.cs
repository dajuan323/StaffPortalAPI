using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Domain.Models.Products
{
    public sealed class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(Guid id)
            : base($"The product with the ID ={id} was not found.")
        {
        }
    }
}
