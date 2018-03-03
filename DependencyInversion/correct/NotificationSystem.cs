using DependencyInversion.almost_correct;

// Now, we can use dependency injection so that we can make it
// loosely coupled. There are 3 types to DI, Constructor injection,
// Property injection and method injection.

namespace DependencyInversion.correct
{
    // Constructor Injection
    public class NotificationSystem
    {
        private readonly IMessenger _messenger;
        public NotificationSystem(IMessenger messenger)
        {
            _messenger = messenger;
        }
        public void Notify()
        {
            _messenger.SendMessage();
        }
    }
}
