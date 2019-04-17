using MediatR.Pipeline;
using System;
using System.Threading.Tasks;

namespace MediatR_NETCoreApp.PostProcessors
{
    public class SomeEventPostProcessor : IRequestPostProcessor<SomeEvent, string>
    {
        public async Task Process(SomeEvent request, string response)
        {
            await Console.Out.WriteLineAsync("Post processing...");
        }
    }
}
