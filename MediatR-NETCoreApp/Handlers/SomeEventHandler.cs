using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_NETCoreApp.Handlers
{
    public class SomeEventHandler : INotificationHandler<SomeEvent>
    {
        public async Task Handle(SomeEvent notification, CancellationToken cancellationToken)
        {
            await Console.Out.WriteLineAsync($"Message {notification.Message} received!");
        }
    }

    public class AnotherSomeEventHandler : INotificationHandler<SomeEvent>
    {
        public async Task Handle(SomeEvent notification, CancellationToken cancellationToken)
        {
            await Console.Out.WriteLineAsync($"I also received the message: {notification.Message}");
        }
    }
}
