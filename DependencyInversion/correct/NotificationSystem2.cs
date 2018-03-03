// Now, we can use dependency injection so that we can make it
// loosely coupled. There are 3 types to DI, Constructor injection,
// Property injection and method injection.

namespace DependencyInversion.correct
{
    // Method Injection
    public class Notification2
    {
        public void Notify(IMessenger messenger)
        {
            messenger.SendMessage();
        }
    }
}
