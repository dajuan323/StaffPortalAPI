using MediatR;
using MediatR.Pipeline;
using StaffPortalAPI.Application.Abstractions.Messaging;
using StaffPortalAPI.Domain.Models.Customers;
using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Application.Customers.Create
{
    internal sealed class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;   
        }

        public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var emailResult = Email.Create(request.Email);
   

            var newCustomer = TestCustomer.Create(
                new Name(request.FirstName),
                new Name(request.LastName),
                emailResult.Value);

            _customerRepository.Add(newCustomer);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
