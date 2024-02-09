using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr2
{
    class Employee
    {
        string surname;
        string name;
        int p;
        int k;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public int P { get => p; set => p = value; }
        public int K { get => k; set => k = value; }
        public Employee() { }
        public Employee(string surname, string name, int p, int k)
        {
            this.surname = surname;
            this.name = name;
            this.p = p;
            this.k = k;
        }
        public double Income()
        {
            return p * k;
        }
        virtual public void Output()
        {
            Console.WriteLine($"Фамилия - {surname}\nИмя - {name}\nМинимальная зп - {p} р.\nПовышающий коэффициент - {k}");
        }
    }
}
