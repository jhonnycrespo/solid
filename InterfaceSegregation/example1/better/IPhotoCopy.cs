using InterfaceSegregation.example1.bad;
using System.Collections.Generic;

namespace InterfaceSegregation.example1.better
{
    interface IPhotoCopy
    {
        void Copy(List<Item> Items);
    }
}
