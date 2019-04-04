using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp1.functions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Calc = new Calculadora();
            Printer PrintFrom = new Printer();

            Console.WriteLine("Program:\n");

            Console.WriteLine("num1: ");
            string num1 = Console.ReadLine();

            Console.WriteLine("num2: ");
            string num2 = Console.ReadLine();

            Console.WriteLine("---------------\n");

            string res;
            PrintFrom.PrintSomething(out res);

            Console.WriteLine(res + "\n");
            Console.WriteLine("Suma result: " + Calc.Sumar(num1,num2));
            Console.WriteLine("Resta result: " + Calc.Restar(num1,num2));
            Console.ReadKey();
        }
    }
}
