using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_NETCoreApp.PipelineBehaviors
{
    public class SomeEventPipelineBehavior : IPipelineBehavior<SomeEvent, string>
    {
        public async Task<string> Handle(SomeEvent request, CancellationToken cancellationToken, RequestHandlerDelegate<string> next)
        {
            await Console.Out.WriteLineAsync("Pipeline start:");
            var response = await next();
            await Console.Out.WriteLineAsync("Pipeline end;");
            return response;
        }
    }
}
