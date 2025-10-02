using Microsoft.Extensions.DistributedMessage4RabbitMQ;
using DistributedMessage4RabbitMQ.Shared;

namespace DistributedMessage4RabbitMQ.Consumer
{
    public class DistributedEventWrapperHandler : IDistributedEventHandler<DistributedEventWrapper<WrappedData>>
    {
        public async Task HandleAsync(DistributedEventWrapper<WrappedData> eventData, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            Console.WriteLine("DistributedEventWrapper");
        }
    }
}
