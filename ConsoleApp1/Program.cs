using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleTest.functions;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of functions
            Calculadora Calc = new Calculadora();
            Printer PrintFrom = new Printer();

            Console.WriteLine("Program:\n");

            //take numbers
            Console.WriteLine("num1: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("num2: ");
            string num2 = Console.ReadLine();

            Console.WriteLine("---------------\n");

            //Printer()
            string resOut;
            PrintFrom.PrintOut(out resOut);
            string resRef = "";
            PrintFrom.PrintRef(ref resRef);

            //Print all
            Console.WriteLine(resOut);
            Console.WriteLine(resRef + "\n");
            Console.WriteLine("Suma result: " + Calc.Sumar(num1,num2));
            Console.WriteLine("Resta result: " + Calc.Restar(num1,num2) + "\n");

            //End of program
            Console.ReadKey();
        }
    }
}
