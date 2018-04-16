using System;
using System.Collections.Generic;

namespace InterfaceSegregation.example2.better
{
    public class EmailMessage : IMessage, IEmailMessage
    {
        public IList<string> SendTo { get; set; }
        public IList<string> CCTo { get; set; }
        public IList<string> BCCTo { get; set; }
        public IList<string> AttachementFilePaths { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }

        public bool Send()
        {
            Console.WriteLine("sending message via email");
            return true;
        }
    }
}
