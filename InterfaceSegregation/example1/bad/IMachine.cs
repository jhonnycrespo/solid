// Scenario
// Let us say a company, Xerox had created a new all in one printer system. The printer
// system could do a wide variety of jobs like printing, scanning, stapling, faxing, etc.

// Xerox hired developers to develop software for that printer machine. Soon the
// software was developed and printer machine was working great.

// But when the time progressed, maintaining the software became difficult and further
// development was a nightmare. Why? Well, we will see that in a short span of time.

using System.Collections.Generic;

namespace InterfaceSegregation.example1.bad
{
    interface IMachine
    {
        void Print(List<Item> item);
        void Staple(List<Item> item);
        void Fax(List<Item> item);
        void Scan(List<Item> item);
        void PhotoCopy(List<Item> item);
    }
}
