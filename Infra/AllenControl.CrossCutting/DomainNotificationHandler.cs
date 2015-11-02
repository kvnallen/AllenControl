using System.Collections.Generic;
using System.Linq;
using DomainNotificationHelper;
using DomainNotificationHelper.Events;

namespace AllenControl.CrossCutting
{
    public class DomainNotificationHandler : IHandler<DomainNotification>
    {
        private IList<DomainNotification> _notifications;

        public DomainNotificationHandler()
        {
            _notifications = new List<DomainNotification>();
        }

        public void Handle(DomainNotification args) => _notifications.Add(args);

        public IEnumerable<DomainNotification> Notify() => _notifications.Distinct();

        public bool HasNotifications() => _notifications.Any();

        public void Dispose() => _notifications = new List<DomainNotification>();
    }
}