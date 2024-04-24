using MediatR;
using StaffPortalAPI.Application.Abstractions.Messaging;
using StaffPortalAPI.Domain.Models.Orders;
using StaffPortalAPI.Domain.Models.Products;
using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Application.Orders.AddLineItems;

internal sealed class AddLineItemCommandHandler : ICommandHandler<AddLineItemCommand>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IProductRepository _productRepository;


    public AddLineItemCommandHandler(
        IOrderRepository orderRepository,
        IProductRepository productRepository
   )
    {
        _orderRepository = orderRepository;
        _productRepository = productRepository;
       
    }

    public Task<Result> Handle(AddLineItemCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
