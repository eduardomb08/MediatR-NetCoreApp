using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_NETCoreApp.Handlers
{
    public class SomeRequestHandler : IRequestHandler<SomeEvent, string>
    {
        public async Task<string> Handle(SomeEvent request, CancellationToken cancellationToken)
        {
            await Console.Out.WriteLineAsync($"I received a request: {request.Message}");
            return "Some response";
        }
    }
}
