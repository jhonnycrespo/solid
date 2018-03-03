using System;

namespace DependencyInversion.almost_correct
{
    public class Sms : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("sending sms");
        }
    }
}
