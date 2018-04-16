using InterfaceSegregation.example1.bad;
using System.Collections.Generic;

namespace InterfaceSegregation.example1.better
{
    interface IStaple
    {
        void Staple(List<Item> Items);
    }
}
