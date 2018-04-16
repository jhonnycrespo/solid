using InterfaceSegregation.example1.bad;
using System.Collections.Generic;

namespace InterfaceSegregation.example1.better
{
    interface IScan
    {
        void Scan(List<Item> Items);
    }
}
