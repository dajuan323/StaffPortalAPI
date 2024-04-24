using StaffPortalAPI.SharedKernel;

namespace StaffPortalAPI.Domain.Models.Customers;
public sealed record CustomerCreatedDomainEvent(TestCustomerId CustomerId) : IDomainEvent;

