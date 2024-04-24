using StaffPortalAPI.Domain.Models.Customers;
using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Domain.Models.Orders;

public sealed record OrderCreatedDomainEvent(OrderId OrderId) : IDomainEvent;
