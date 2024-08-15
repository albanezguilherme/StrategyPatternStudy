using StrategyStudy.Core.Interfaces.Strategy;

namespace StrategyStudy.Core.Entities.Strategy
{
    public class EmailNotificationStrategy : INotificationStrategy
    {
        public void NotifyAboutSomething()
        {
            //Code about sending a notification by email
        }
    }
}
