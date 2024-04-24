using MediatR;
using StaffPortalAPI.Application.Abstractions.Messaging;

namespace StaffPortalAPI.Application.Customers.Create;

public sealed record CreateCustomerCommand(
    string FirstName,
    string LastName,
    string Email) : IRequest;

