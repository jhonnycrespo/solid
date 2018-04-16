using InterfaceSegregation.example1.bad;
using System.Collections.Generic;

namespace InterfaceSegregation.example1.better
{
    interface IFax
    {
        void Fax(List<Item> Items);
    }
}
