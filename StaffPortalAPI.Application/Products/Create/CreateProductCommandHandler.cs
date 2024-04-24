using MediatR;
using StaffPortalAPI.Application.Abstractions.Messaging;
using StaffPortalAPI.Domain.Models.Products;
using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Application.Products.Create;

internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
    private readonly IProductRepository _productRepo;
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductCommandHandler(
        IProductRepository productRepo,
        IUnitOfWork uniOfwork)
    {
        _productRepo = productRepo;
        _unitOfWork = uniOfwork;
    }



    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product(
            new ProductId(Guid.NewGuid()),
            new Name(request.ProductName),
            new Money(request.Currency, request.Amount),
            Sku.Create(request.Sku)!);

        _productRepo.Add(product);
        await _unitOfWork.SaveChangesAsync(cancellationToken);


    }


}
