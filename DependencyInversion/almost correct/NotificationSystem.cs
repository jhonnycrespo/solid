// What can we do to make it loosely coupled?
// We can introduce an interface IMessenger.

namespace DependencyInversion.almost_correct
{
    public class NotificationSystem
    {
        private readonly IMessenger _messenger;

        // But still Notification class depends on Email class.
        public NotificationSystem()
        {
            _messenger = new Email();
        }

        public void Notify()
        {
            _messenger.SendMessage();
        }
    }
}
