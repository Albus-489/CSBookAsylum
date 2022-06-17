using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Domain.Common
{
    public class EntityNeeds
    {
        public int Id { get; set; }

        private readonly List<EventBase> _domainEvents = new();

        [NotMapped]
        public IReadOnlyCollection<EventBase> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(EventBase domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public void RemoveDomainEvent(EventBase domainEvent)
        {
            _domainEvents.Remove(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

    }
}
