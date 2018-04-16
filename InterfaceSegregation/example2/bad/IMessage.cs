using System;
using System.Collections.Generic;

namespace InterfaceSegregation.example2.bad
{
    public interface IMessage
    {
        IList<string> SendToAddress { get; set; }
        string Subject { get; set; }
        string MessageText { get; set; }

        // 4. It can get worse if the team decides to add CCToAddress.
        IList<string> CCToAddress { get; set; }

        // 6. It would get even worse with BCCToAddress and email attachments.

        bool Send();
    }

    public class EmailMessage : IMessage
    {
        public IList<string> SendToAddress { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }
        public IList<string> CCToAddress { get; set; }

        public bool Send()
        {
            Console.WriteLine("sending message via email");
            return true;
        }
    }

    // 2. The team now needs to also send SMS or text messages and decides to
    // leverage the existing interface.

    public class SMSMessage : IMessage
    {
        public IList<string> SendToAddress { get; set; }
        public string MessageText { get; set; }

        // 3. Because SMS doesn’t have a Subject, an exception is thrown.
        public string Subject
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        // 5.
        public IList<string> CCToAddress
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public bool Send()
        {
            Console.WriteLine("sending message via sms");
            return true;
        }
    }
}
