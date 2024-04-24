using StaffPortalAPI.Domain.Models.Users;
using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Domain.Models.Customers
{
    public sealed class TestCustomer : Entity
    {
        public TestCustomer(TestCustomerId id, Email email)
        {
            Id = id;
            FirstName = new Name(); 
            LastName = new Name(); 
            Email = email;
        }
        public TestCustomerId Id { get; private set; }
        public Name FirstName { get; private set; }
        public Name LastName { get; private set; }

      
        public Email Email { get; private set; }

        public static TestCustomer Create(Name firstName, Name lastName,  Email email)
        {
            var customer = new TestCustomer(new TestCustomerId(Guid.NewGuid()), email)
            {
                FirstName = firstName,
                LastName = lastName,
            };
            customer.Raise(new CustomerCreatedDomainEvent(customer.Id));
            

            return customer;
        }
    }
}

