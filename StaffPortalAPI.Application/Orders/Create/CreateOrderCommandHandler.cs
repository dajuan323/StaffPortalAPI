using MediatR;
using StaffPortalAPI.Application.Abstractions.Messaging;
using StaffPortalAPI.Domain.Models.Customers;
using StaffPortalAPI.Domain.Models.Orders;
using StaffPortalAPI.SharedKernel;

namespace StaffPortalAPI.Application.Orders.Create;

internal sealed class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateOrderCommandHandler(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
    {
        _orderRepository = orderRepository;
        _unitOfWork = unitOfWork;
    }
    
    public Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        //var newOrder = Order
        //        .Create(new TestCustomerId(request.CustomerId))
        //        .Add(new LineItem(
        //            new LineItemId(Guid.NewGuid()),
        //            ));

        throw new NotImplementedException();

    }
}
