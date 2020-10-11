using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UsefulPatterns.AdvancedMediator
{
    public class Mediator : IMediator
    {
        public async Task PublishAsync<TRequest>(TRequest request, CancellationToken cancellationToken)
            where TRequest : INotification
        {
            var handlers = NotificationHandlers(request);

            foreach (var handler in handlers)
            {
                if (handler != null)
                {
                    await handler.HandleAsync(request, cancellationToken).ConfigureAwait(false);
                }
            }
        }

        private static IEnumerable<INotificationHandler<TRequest>> NotificationHandlers<TRequest>(TRequest request)
            where TRequest : INotification
        {
            var requestType = request.GetType();
            var handlerConcreteType = typeof(INotificationHandler<>).MakeGenericType(requestType);

            var requestHandlerTypes = typeof(Mediator).Assembly.GetTypes()
                .Where(t => handlerConcreteType.IsAssignableFrom(t))
                .ToList();

            var handlers =
                requestHandlerTypes.Select(x => Activator.CreateInstance(x) as INotificationHandler<TRequest>);

            return handlers;
        }
    }
}