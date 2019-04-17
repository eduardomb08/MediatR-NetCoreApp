using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using MediatR_NETCoreApp.PipelineBehaviors;

namespace MediatR_NETCoreApp
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            Console.WriteLine("Type a message to send:");
            var msg = new SomeEvent(Console.ReadLine());

            SetupDI();

            var mediator = _serviceProvider.GetRequiredService<IMediator>();

            mediator.Publish(msg);

            var response = mediator.Send(msg)
                .GetAwaiter()
                .GetResult();

            Console.WriteLine($"And the response was: {response}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void SetupDI()
        {
            var services = new ServiceCollection();
            services.AddMediatR();
            services.AddTransient(typeof(IPipelineBehavior<SomeEvent,string>), typeof(SomeEventPipelineBehavior));

            _serviceProvider = services
                .BuildServiceProvider();
        }
    }
}
