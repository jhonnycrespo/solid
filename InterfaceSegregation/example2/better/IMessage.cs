using System.Collections.Generic;

namespace InterfaceSegregation.example2.better
{
    public interface IMessage
    {
        IList<string> SendTo { get; set; }
        string MessageText { get; set; }
        bool Send();
    }
}
