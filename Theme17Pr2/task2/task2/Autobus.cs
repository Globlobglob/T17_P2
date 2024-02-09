using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Autobus
    {
        string mark;
        protected int countseats;
        int cost;

        public string Mark { get => mark; set => mark = value; }
        public int Countseats { get => countseats; set => countseats = value; }
        public int Cost { get => cost; set => cost = value; }

        public Autobus() { }
        public Autobus(string mark,int countseats,int cost) {

            this.mark = mark;
            this.countseats = countseats;
            this.cost = cost;
        }

        public int Allsumm()
        {
            return countseats * cost;
        }

        virtual public void Print()
        {
            Console.WriteLine($"Mark {Mark}\nCountseats {Countseats}\nCost {Cost}");
        }

    }
}
