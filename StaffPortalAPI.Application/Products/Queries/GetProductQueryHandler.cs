using MediatR;


using Microsoft.EntityFrameworkCore;
using StaffPortalAPI.Application.Abstractions.Messaging;
using StaffPortalAPI.Application.Data;
using StaffPortalAPI.Domain.Models.Products;
using StaffPortalAPI.SharedKernel;

namespace StaffPortalAPI.Application.Products.Queries;

internal sealed class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductResponse>
{
    private readonly IApplicationDbContext _appDbContext;

    public GetProductQueryHandler(IApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<ProductResponse> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var product = await _appDbContext.Products
            .Where(p => p.Id == request.productId)
            .Select(p => new ProductResponse(
                p.Id.Value,
                p.ProductName.Value,
                p.Sku.Value,
                p.Price.Currency,
                p.Price.Amount))
            .FirstOrDefaultAsync(cancellationToken);

        return product ?? throw ProductNotFoundException(request.productId);
    }

    private Exception ProductNotFoundException(ProductId productId)
    {
        throw new NotImplementedException();
    }
}

