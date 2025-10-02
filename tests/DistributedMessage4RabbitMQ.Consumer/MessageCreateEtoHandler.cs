using Microsoft.Extensions.DistributedMessage4RabbitMQ;
using DistributedMessage4RabbitMQ.Shared;

namespace DistributedMessage4RabbitMQ.Consumer
{
    public class MessageCreateEtoHandler : IDistributedEventHandler<MessageCreateEto>
    {
        public async Task HandleAsync(MessageCreateEto eventData, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
        }
    }
}
