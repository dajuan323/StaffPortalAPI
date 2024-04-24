using MediatR;
using StaffPortalAPI.Application.Abstractions;


namespace StaffPortalAPI.Application.Products.Create;

public sealed record CreateProductCommand(
    string ProductName,
    string Sku,
    string Currency,
    decimal Amount) : IRequest;
