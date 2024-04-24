using MediatR;
using StaffPortalAPI.Application.Abstractions.Messaging;


namespace StaffPortalAPI.Application.Orders.Create;

public record CreateOrderCommand(Guid CustomerId) : IRequest;

