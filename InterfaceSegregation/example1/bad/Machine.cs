// Scenario
// Let us say a company, Xerox had created a new all in one printer system. The printer
// system could do a wide variety of jobs like printing, scanning, stapling, faxing, etc.

// Xerox hired developers to develop software for that printer machine. Soon the
// software was developed and printer machine was working great.

// But when the time progressed, maintaining the software became difficult and further
// development was a nightmare. Why? Well, we will see that in a short span of time.

using System;
using System.Collections.Generic;

namespace InterfaceSegregation.example1.bad
{
    class Machine : IMachine
    {
        public void Print(List<Item> item)
        {
            // Print the items.
            Console.WriteLine("All Items printed" + item.Count);
        }

        public void Staple(List<Item> item)
        {
            // Staple the items.
            Console.WriteLine("Items stapled" + item.Count);
        }

        public void Fax(List<Item> item)
        {
            // Fax the items.
            Console.WriteLine("All Items Faxed" + item.Count);
        }

        public void Scan(List<Item> item)
        {
            // Scan the items.
            Console.WriteLine("All Items Scanned" + item.Count);
        }

        public void PhotoCopy(List<Item> item)
        {
            // Xerox the items.
            Console.WriteLine("All Items Photo copied" + item.Count);
        }
    }
}
