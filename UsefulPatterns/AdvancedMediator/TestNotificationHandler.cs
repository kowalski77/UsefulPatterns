using System;
using System.Threading;
using System.Threading.Tasks;

namespace UsefulPatterns.AdvancedMediator
{
    public class TestNotificationHandler : INotificationHandler<TestNotification>
    {
        public Task HandleAsync(TestNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Notification received in handler one with name: {notification.Name}");

            return Task.CompletedTask;
        }
    }
}