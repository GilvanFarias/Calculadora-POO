using System.Globalization;
using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora();
            Console.WriteLine("Digite um valor");
            c1.Valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um operador (*) | (/) | (+) | (-)");
            c1.Operador = Console.ReadLine();

            Console.WriteLine("Digite um valor");
            c1.Valor2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Resultado de: " + c1.Valor1 + c1.Operador + c1.Valor2 + " = " +c1.Resultado);
            
        }
    }
}

