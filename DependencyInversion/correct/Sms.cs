using System;
using DependencyInversion.correct;

namespace DependencyInversion.correct
{
    public class Sms : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("sending sms");
        }
    }
}
