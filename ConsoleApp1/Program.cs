using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculaMaster;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Calculator:\n");

            Console.WriteLine("num1: ");
            string num1 = Console.ReadLine();

            Console.WriteLine("num2: ");
            string num2 = Console.ReadLine();

            Console.WriteLine("---------------");

            Console.WriteLine("Suma result: " + calc.sumar(num1,num2));
            Console.WriteLine("Resta result: " + calc.restar(num1,num2));
            Console.ReadKey();
        }
    }
}
