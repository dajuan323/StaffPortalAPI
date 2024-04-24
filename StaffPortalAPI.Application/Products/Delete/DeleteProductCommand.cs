using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Application.Products.Delete;

public record DeleteProductCommand(ProductId ProductId) : IRequest;

