using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double argument1, argument2,wynik;
            char operator1;
            string wpisanyZnak;
            while (true)
            {
                Console.Write("Podaj argument #1: ");
                argument1 = Convert.ToDouble(Console.ReadLine());
                do
                {
                    Console.Write("Podaj operator: ");
                    wpisanyZnak = Console.ReadLine();

                } while (wpisanyZnak != "+" && wpisanyZnak != "-" && wpisanyZnak != "*" && wpisanyZnak != "/");

                operator1 = Convert.ToChar(wpisanyZnak);
                
                Console.Write("Podaj argument #2: ");
                argument2 = Convert.ToDouble(Console.ReadLine());

                if (operator1 == '/' && argument2 == 0) Console.WriteLine("Dzielenie przez 0!");
                else
                {
                    wynik = kalkulator(argument1, argument2, operator1);
                    Console.WriteLine("Wynik to: {0}", wynik);
                }
            }

            Console.ReadKey();
        }

        private static double kalkulator(double liczba1, double liczba2, char znak)
        {    
            switch (znak)
            {
                case '+':
                    return liczba1 + liczba2;
                case '-':
                    return liczba1 - liczba2;
                case '*':
                    return liczba1 * liczba2;
                case '/':
                    return liczba1 / liczba2;
                default:
                    return 0;                   
            }
        }
    }
}
