using System;
using DependencyInversion.correct;

namespace DependencyInversion.correct
{
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("sending email");
        }
    }
}
