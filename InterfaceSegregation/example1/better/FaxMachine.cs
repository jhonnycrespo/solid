using InterfaceSegregation.example1.bad;
using System;
using System.Collections.Generic;

namespace InterfaceSegregation.example1.better
{
    class FaxMachine : IFax
    {
        public void Fax(List<Item> Items)
        {
            foreach (var item in Items)
                Console.WriteLine("sending fax");
        }
    }
}
