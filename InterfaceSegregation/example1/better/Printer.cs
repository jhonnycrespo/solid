using InterfaceSegregation.example1.bad;
using System;
using System.Collections.Generic;

namespace InterfaceSegregation.example1.better
{
    class Printer : IPrinter
    {
        public void Print(List<Item> Items)
        {
            foreach (var item in Items)
                Console.WriteLine("printing");
        }
    }
}
