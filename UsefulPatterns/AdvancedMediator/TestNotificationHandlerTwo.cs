using System;
using System.Threading;
using System.Threading.Tasks;

namespace UsefulPatterns.AdvancedMediator
{
    public class TestNotificationHandlerTwo : INotificationHandler<TestNotification>
    {
        public Task HandleAsync(TestNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Notification received in handler two with name: {notification.Name}");

            return Task.CompletedTask;
        }
    }
}