﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.functions
{
    class Calculadora
    {
        public int Sumar(string num1, string num2)
        {
            short n1 = short.Parse(num1);
            short n2 = short.Parse(num2);
            int suma = n1 + n2;
            return suma;
        }
        public int Restar(string num1, string num2)
        {
            short n1 = short.Parse(num1);
            short n2 = short.Parse(num2);
            int resta = n1 - n2;
            return resta;
        }
    }
}
