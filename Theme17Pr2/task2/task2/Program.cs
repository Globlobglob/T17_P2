using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Autobus a1 = new Touristsbus("Bus",25,5,25);
            a1.Print();
            Console.ReadKey();
        }
    }
}
