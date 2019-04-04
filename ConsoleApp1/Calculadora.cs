using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaMaster
{
    class Calculadora
    {
        public Int32 sumar(string num1, string num2)
        {
            Int16 n1 = Int16.Parse(num1);
            Int16 n2 = Int16.Parse(num2);
            Int32 suma = n1 + n2;
            return suma;
        }
        public Int32 restar(string num1, string num2)
        {
            Int16 n1 = Int16.Parse(num1);
            Int16 n2 = Int16.Parse(num2);
            Int32 resta = n1 - n2;
            return resta;
        }
    }
}
