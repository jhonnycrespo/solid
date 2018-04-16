using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitution.example_1.bad;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            // using the bad example

            Rectangle r = new Square();
            r.SetWidth(7);
            r.SetHeight(3);

            var area = r.GetArea();

            Console.WriteLine(area);

            // using the better example
        }
    }
}
