using System;
using System.Linq;

namespace UsefulPatterns.AdvancedMediator
{
    public class Mediator : IMediator
    {
        public void Publish<TRequest>(TRequest request) where TRequest : IRequest
        {
            var requestType = request.GetType();
            var handlerConcreteType = typeof(IRequestHandler<>).MakeGenericType(requestType);

            var requestHandlerTypes = typeof(Mediator).Assembly.GetTypes()
                .Where(t => handlerConcreteType.IsAssignableFrom(t))
                .ToList();

            foreach (var handler in requestHandlerTypes.Select(requestHandlerType =>
                Activator.CreateInstance(requestHandlerType) as IRequestHandler<TRequest>))
            {
                handler?.Handle(request);
            }
        }
    }
}