using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Touristsbus:Autobus
    {
        int costgid;

        public int Costgid { get => costgid; set => costgid = value; }

        public Touristsbus(string mark,int countseats,int cost,int costgid):base(mark,countseats,cost) {

            this.costgid = costgid;
        }

         public  int FinalCost()
         {
            return Allsumm() + (countseats * costgid);
         }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"CostGid {costgid}\n{FinalCost()}");
        }
    }
}
