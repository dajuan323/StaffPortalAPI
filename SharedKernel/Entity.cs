using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.SharedKernel
{
    public abstract class Entity
    {
        private readonly List<IDomainEvent> _domainEvents = new();

        public List<IDomainEvent> DomainEvents => _domainEvents.ToList();

        protected void Raise(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}


