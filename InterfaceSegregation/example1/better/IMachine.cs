using InterfaceSegregation.example1.bad;
using System.Collections.Generic;

namespace InterfaceSegregation.example1.better
{
    interface IMachine : IPrinter, IFax, IScan, IPhotoCopy, IStaple
    {
        void Print(List<Item> item);
        void Staple(List<Item> item);
        void Fax(List<Item> item);
        void Scan(List<Item> item);
        void Copy(List<Item> item);
    }
}
