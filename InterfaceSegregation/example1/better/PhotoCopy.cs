using InterfaceSegregation.example1.bad;
using System;
using System.Collections.Generic;

namespace InterfaceSegregation.example1.better
{
    class PhotoCopy : IPhotoCopy
    {
        public void Copy(List<Item> Items)
        {
            foreach (var item in Items)
                Console.WriteLine("copying");
        }
    }
}
