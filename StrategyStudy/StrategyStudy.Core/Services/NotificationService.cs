using StrategyStudy.Core.Entities.Strategy;
using StrategyStudy.Core.Enums;
using StrategyStudy.Core.Interfaces.Services;
using StrategyStudy.Core.Interfaces.Strategy;

namespace StrategyStudy.Core.Services
{
    public class NotificationService : INotificationService
    {
        public INotificationStrategy _notification;

        public NotificationService(INotificationStrategy notification)
        {
            _notification = notification;
        }

        public void Notify(NotificationTypeEnum notificationType)
        {
            if (notificationType == NotificationTypeEnum.SMS) _notification = new SMSNotificationStrategy();
            if (notificationType == NotificationTypeEnum.Email) _notification = new EmailNotificationStrategy();
            if (notificationType == NotificationTypeEnum.Database) _notification = new DatabaseNotificationStrategy();

            _notification.NotifyAboutSomething();
        }
    }
}
