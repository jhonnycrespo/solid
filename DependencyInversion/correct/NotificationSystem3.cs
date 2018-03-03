// Now, we can use dependency injection so that we can make it
// loosely coupled. There are 3 types to DI, Constructor injection,
// Property injection and method injection.

namespace DependencyInversion.correct
{

    // Property Injection
    public class Notification3
    {
        private IMessenger _messenger;

        public Notification3()
        {
        }

        public IMessenger MessageService
        {
            set => _messenger = value;
        }

        public void DoNotify()
        {
            _messenger.SendMessage();
        }
    }
}
