using MediatR;
using StaffPortalAPI.Application.Abstractions.Messaging;
using StaffPortalAPI.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Application.Products.Queries;

public record GetProductListQuery() : IRequest<List<Product>>;

