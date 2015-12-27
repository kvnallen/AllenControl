using AllenControl.Infra.Transaction;
using DomainNotificationHelper;
using DomainNotificationHelper.Events;

namespace AllenControl.ApplicationService
{
    public class ServiceBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHandler<DomainNotification> _notifications;

        public ServiceBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
        }

        public void Commit()
        {
            if (!_notifications.HasNotifications())
                _unitOfWork.Commit();
        }
    }
}