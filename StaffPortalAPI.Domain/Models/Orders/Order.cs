using StaffPortalAPI.Domain.Models.Customers;
using StaffPortalAPI.SharedKernel;

namespace StaffPortalAPI.Domain.Models.Orders;

public class Order : Entity
{
    private readonly HashSet<LineItem> _lineItems = new();
    private Order()
    {
        
    }

    public OrderId Id { get; private set; }
    public TestCustomerId CustomerId { get; private set; }

    public IReadOnlyList<LineItem> LineItems => _lineItems.ToList();

    public static Order Create(TestCustomerId customerId)
    {
        var order = new Order
        {
            Id = new OrderId(Guid.NewGuid()),
            CustomerId = customerId
        };

        order.Raise(new OrderCreatedDomainEvent(order.Id));

        return order;
    }


    public void Add(ProductId productId, Money price)
    {
        var lineItem = new LineItem(new LineItemId(Guid.NewGuid()), Id, productId, price);

        _lineItems.Add(lineItem);
    }



}
