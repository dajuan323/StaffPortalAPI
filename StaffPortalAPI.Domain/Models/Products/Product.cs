using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Domain.Models.Products;

public class Product
{

    private Product() { }
    public Product(ProductId id, Name productName, Money price, Sku sku)
    {
        Id = id;
        ProductName = productName;
        Price = price;
        Sku = sku;
    }

    public ProductId Id { get; private set; }
    public Name? ProductName { get; private set; }
    public Money? Price { get; private set; }
    public Sku? Sku { get; private set; }

}
