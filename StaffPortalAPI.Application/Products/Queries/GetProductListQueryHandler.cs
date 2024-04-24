using MediatR;


using Microsoft.EntityFrameworkCore;
using StaffPortalAPI.Application.Abstractions.Messaging;
using StaffPortalAPI.Application.Data;
using StaffPortalAPI.Domain.Models.Products;
using StaffPortalAPI.SharedKernel;

namespace StaffPortalAPI.Application.Products.Queries;

internal sealed class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, List<Product>>
{
    private readonly IApplicationDbContext _context;

    public GetProductListQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
    {
        List<Product> products = await _context.Products
            .ToListAsync(cancellationToken); // Execute the query and convert the result to a list asynchronously

        // Create a Result object and return it as a completed task
        return products ?? throw new Exception("not found");
    }
}


