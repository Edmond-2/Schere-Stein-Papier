using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welches kleine Einmaleins möchtest du sehen?");
            int zahl = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                int ergebnis = zahl * i;
                Console.WriteLine($"{zahl} x {i} = {ergebnis}");
            }

            Console.ReadLine();
        }
    }
}
