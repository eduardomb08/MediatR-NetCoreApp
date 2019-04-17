using MediatR;

namespace MediatR_NETCoreApp
{
    public class SomeEvent : INotification, IRequest<string>
    {
        public string Message { get; private set; }

        public SomeEvent(string msg)
        {
            Message = msg;
        }
    }
}
