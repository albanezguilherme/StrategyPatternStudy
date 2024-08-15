using StrategyStudy.Core.Enums;

namespace StrategyStudy.Core.Interfaces.Services
{
    public interface INotificationService
    {
        void Notify(NotificationTypeEnum notificationType);
    }
}
