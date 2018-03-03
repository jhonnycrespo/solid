// Now, we can use dependency injection so that we can make it
// loosely coupled. There are 3 types to DI, Constructor injection,
// Property injection and method injection.

namespace DependencyInversion.correct
{
    public interface IMessenger
    {
        void SendMessage();
    }
}
