using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr2
{
    class Engineer : Employee
    {
        int n;

        public int N { get => n; set => n = value; }
        public Engineer(string surname,string name, int p, int k, int n) : base(surname,name,p,k)
        {
            this.n = n;
        }
        public new double Income()
        {
            if (n > 10)
            {
                return base.Income() * (n / 10);

            }
            else { return base.Income(); } 
            
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Кол-во разработанных проэктов - {n}\nКонечный доход - {Income()}");
        }

    }
}
