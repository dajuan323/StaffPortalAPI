using StaffPortalAPI.SharedKernel;

namespace StaffPortalAPI.Domain.Models.Orders;

public class LineItem : Entity
{
    internal LineItem(LineItemId id, OrderId orderId, ProductId productId, Money price) : this(id, orderId, productId)
    {
        Price = price;
    }

    private LineItem(LineItemId id, OrderId orderId, ProductId productId)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
    }

    public LineItemId Id { get; private set; }
    public OrderId OrderId { get; private set; }
    public ProductId ProductId { get; private set; }
    public Money Price { get; private set; }
}
