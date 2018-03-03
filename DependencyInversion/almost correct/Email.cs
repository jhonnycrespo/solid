using System;

namespace DependencyInversion.almost_correct
{
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("sending email");
        }
    }
}
