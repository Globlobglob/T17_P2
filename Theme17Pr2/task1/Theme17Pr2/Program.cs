using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr2
{
    class Program
    {

        static void Main(string[] args)
        {
            //List<Employee> empl = new List<Employee>();
            //empl.Add(new Employee("","",1234, 2));
            //empl.Add(new Engineer("","",10000, 2, 15));
            //foreach (var num in empl)
            //{
            //    num.Output();
            //    Console.WriteLine();
            //}
            try
            {
                Engineer eng1 = new Engineer("", "", 10000, 2, 25);
                eng1.Output();
            }


            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }

            Console.ReadKey();
        }
    }
}