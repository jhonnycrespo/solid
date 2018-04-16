using System.Collections.Generic;

namespace InterfaceSegregation.example2.better
{
    public interface IEmailMessage
    {
        IList<string> CCTo { get; set; }
        IList<string> BCCTo { get; set; }
        IList<string> AttachementFilePaths { get; set; }
        string Subject { get; set; }
    }
}
