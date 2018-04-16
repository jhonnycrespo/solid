using InterfaceSegregation.example1.bad;
using System;
using System.Collections.Generic;

namespace InterfaceSegregation.example1.better
{
    class Scanner : IScan
    {
        public void Scan(List<Item> Items)
        {
            foreach (var item in Items)
                Console.WriteLine("scanning");
        }
    }
}
