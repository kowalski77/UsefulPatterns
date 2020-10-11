using System.Threading;
using System.Threading.Tasks;

namespace UsefulPatterns.Mediator
{
    public interface INotificationHandler<in TNotification> where TNotification : INotification
    {
        Task HandleAsync(TNotification notification, CancellationToken cancellationToken);
    }
}