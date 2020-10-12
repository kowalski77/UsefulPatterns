using System.Threading;
using System.Threading.Tasks;

namespace UsefulPatterns.MediatorAdvanced
{
    public interface IMediator
    {
        Task PublishAsync<TRequest>(TRequest request, CancellationToken cancellationToken)
            where TRequest : INotification;
    }
}