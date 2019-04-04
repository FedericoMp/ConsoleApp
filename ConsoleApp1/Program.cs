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
            SuperStrings SuperStr = new SuperStrings();

            Console.WriteLine("- ConsoleTest -");
            Console.WriteLine($"at time: {Convert.ToString(SuperStr.RetornaFecha())}");

            Console.WriteLine("---------------\n");

            Console.WriteLine("Calcular:");

            //Calculadora take numbers
            Console.WriteLine("num1: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("num2: ");
            string num2 = Console.ReadLine();

            //Calculadora
            Console.WriteLine("\nSuma result: " + Calc.Sumar(num1, num2));
            Console.WriteLine("Resta result: " + Calc.Restar(num1, num2) + "\n");

            Console.WriteLine("---------------\n");

            //Print methods
            string resOut;
            PrintFrom.PrintOut(out resOut);
            string resRef = "";
            PrintFrom.PrintRef(ref resRef);

            Console.WriteLine("Imprime datos:");
            //Printer
            Console.WriteLine(resOut);
            Console.WriteLine(resRef + "\n");

            Console.WriteLine("---------------\n");

            Console.WriteLine("Ingresar cadena de texto:");
            string cadena = Console.ReadLine();
            Console.WriteLine(SuperStr.MutaCadena(cadena));

            //End of program
            Console.ReadKey();
        }
    }
}
