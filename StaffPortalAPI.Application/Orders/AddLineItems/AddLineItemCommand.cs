using StaffPortalAPI.Application.Abstractions.Messaging;
using StaffPortalAPI.Domain.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StaffPortalAPI.Application.Orders.AddLineItems;

public sealed record AddLineItemCommand(
    OrderId OrderId) : ICommand;

