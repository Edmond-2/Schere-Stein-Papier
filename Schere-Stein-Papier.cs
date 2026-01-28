using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schere_stein_Papier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int auswahl;
            int Computer;

            Console.WriteLine("Im Schere-Stein-Papier Spiel kannst du drei verschiedene Zahlen waehlen");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("1. Schere, 2. Stein, 3. Papier");
            Console.WriteLine("------------------------------");


            
            
                Console.Write("Waehle jetzt eine Zahl:");
            if (int.TryParse(Console.ReadLine(), out auswahl))

                if (auswahl == 1)
                {
                    Console.WriteLine("Schere");
                }
                else if (auswahl == 2)
                {
                    Console.WriteLine("Stein");
                }
                else if (auswahl == 3)
                {
                    Console.WriteLine("Papier");
                }
                else if (auswahl > 3)
                {
                    Console.WriteLine("Ungueltige Zahl");
                }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Jetzt waehlt der Computer");
            Console.WriteLine("-------------------------");
            Random rnd = new Random();
            Computer = rnd.Next(1, 4);

            if (Computer == 1)
            {
                Console.WriteLine("Computer waehlt Schere");
            }
            else if (Computer == 2)
            {
                Console.WriteLine("Computer waehlt Stein");
            }
            else if (Computer == 3)
            {
                Console.WriteLine("Computer waehlt Papier");
            }

            if (auswahl == Computer)
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Unentschieden");
            }
            else
            {
                if (auswahl == 1)
                {
                    if (Computer == 2) Console.WriteLine("Computer gewinnt: Stein schlaegt Schere!");
                    else Console.WriteLine("Sieg: Schere schlaegt Papier!");
                }
                else if (auswahl == 2)
                {
                    if (Computer == 3) Console.WriteLine("Computer gewinnt: Papier schlaegt Stein!");
                    else Console.WriteLine("Sieg: Stein schlaegt Schere!");
                }
                else if (auswahl == 3)
                {
                    if (Computer == 1) Console.WriteLine("Computer gewinnt: Schere schlaegt Papier!");
                    else Console.WriteLine("Sieg: Papier schlaegt Stein!");
                }
                Console.ReadLine();
            }   
        } 
    }
}
