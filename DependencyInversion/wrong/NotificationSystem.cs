// https://www.codeproject.com/Tips/1033646/SOLID-Principle-with-Csharp-Example

// This principle tells you not to write any tightly coupled code
// because that is a nightmare to maintain when the application is
// growing bigger and bigger.

// If a class depends on another class, then we need to change one
// class if something changes in that dependent class. We should
// always try to write loosely coupled class.

namespace DependencyInversion.wrong
{
    // Suppose there is one notification system after saving
    // some details into database.

    // Now NotificationSystem class totally depends on Email class, because
    // it only sends one type of notification. If we want to introduce
    // any other like SMS then? We need to change the notification
    // system also. And this is called tightly coupled.
    public class NotificationSystem
    {
        private readonly Email _email;

        public NotificationSystem()
        {
            _email = new Email();
        }

        public void PromotionalNotification()
        {
            _email.SendEmail();
        }
    }
}
