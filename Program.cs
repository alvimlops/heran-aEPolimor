using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using atividadeHerançaPolimo.entities;
using System.Threading.Tasks;
using System.Globalization;

namespace atividadeHerançaPolimo
{
    class Program
    {
        private static int hours;

        public static double valuePerHours { get; private set; }

        static void Main(string[] args)
        {
            List<employee> list = new List<employee>();

            Console.Write("enter the number og employess: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"employee #{i} data:");
                Console.Write("outsourced (Y/N)?:");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Hours : ");
                int hr = int.Parse(Console.ReadLine());
                Console.Write("Value Per HOurs: ");
                double value = double.Parse(Console.ReadLine()); 
                if (ch == 'y')
                {
                    Console.Write("additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutssourceEmploye(name, hours, valuePerHours, additionalCharge));
                }
                else
                {
                    list.Add(new employee(name, hours, valuePerHours));
                }


           }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }




























        }
    }
}
