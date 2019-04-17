using MediatR.Pipeline;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_NETCoreApp.PreProcessors
{
    public class SomeEventPreProcessor : IRequestPreProcessor<SomeEvent>
    {
        public async Task Process(SomeEvent request, CancellationToken cancellationToken)
        {
            await Console.Out.WriteLineAsync("Pre processing request...");
        }
    }
}
