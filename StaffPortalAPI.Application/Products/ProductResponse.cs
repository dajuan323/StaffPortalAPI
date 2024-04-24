namespace StaffPortalAPI.Application.Products;

public record ProductResponse(
    Guid Id,
    string Name,
    string Sku,
    string Currency,
    decimal Amount);
