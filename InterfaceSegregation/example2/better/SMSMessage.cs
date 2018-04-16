using System;
using System.Collections.Generic;

namespace InterfaceSegregation.example2.better
{
    public class SMSMessage : IMessage
    {
        public IList<string> SendTo { get; set; }
        public string MessageText { get; set; }

        public bool Send()
        {
            Console.WriteLine("sending message via sms");
            return true;
        }
    }
}
