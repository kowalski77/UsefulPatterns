using System.Threading;
using System.Threading.Tasks;

namespace UsefulPatterns.AdvancedMediator
{
    public class AdvancedMediatorStarter
    {
        public async Task RunAsync()
        {
            var mediator = new Mediator();
            var testRequest = new TestNotification
            {
                Name = "test"
            };

            await mediator.PublishAsync(testRequest, CancellationToken.None).ConfigureAwait(false);
        }
    }
}