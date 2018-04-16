using InterfaceSegregation.example1.bad;
using System;
using System.Collections.Generic;

namespace InterfaceSegregation.example1.better
{
    class Machine : IMachine
    {
        private IPrinter Printer { get; set; }
        private IFax Faxer { get; set; }
        private IScan Scanner { get; set; }
        private IPhotoCopy Photocopy { get; set; }
        private IStaple Stapler { get; set; }

        // Notice how the dependencies are injected through constructor (constructor dependency injection)
        public Machine(IPrinter printer, IFax fax, IScan scan, IPhotoCopy photocopy, IStaple staple)
        {
            this.Printer = printer;
            this.Faxer = fax;
            this.Scanner = scan;
            this.Photocopy = photocopy;
            this.Stapler = staple;
        }

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

        public void Copy(List<Item> item)
        {
            // Xerox the items.
            Console.WriteLine("All Items Photo copied" + item.Count);
        }
    }
}
