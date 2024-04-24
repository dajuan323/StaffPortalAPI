using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StaffPortalAPI.Domain.Models.Products;
using StaffPortalAPI.Persistence.Data;

namespace StaffPortalAPI.Persistence.Repositories;

internal sealed class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _appContext;


    public ProductRepository(ApplicationDbContext appContext)
    {
        _appContext = appContext;
    }
    public void Add(Product product)
    {
        _appContext.Add(product);
    }

    public List<Product> GetAll()
    {
        var products = new List<Product>();
        return products;
    }


    public void Remove(Product product)
    {
        throw new NotImplementedException();
    }
}

