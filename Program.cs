using System.Globalization;
using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora c1 = new Calculadora();
            Console.WriteLine("Digite um valor");
            double _valor1 = Convert.ToDouble(Console.ReadLine()); //convertendo para double
            //c1.Valor1 = Convert.ToDouble(Console.ReadLine()); //chamando um objeto caso não tenha o método contrutor

            Console.WriteLine("Digite um operador (*) Multiplicação) | (/) Dividisão) | (+) Soma) | (-) Diminuição)");
            string _operador = Console.ReadLine();
            //c1.Operador = Console.ReadLine();

            Console.WriteLine("Digite um valor");
            double _valor2 = Convert.ToDouble(Console.ReadLine());
            //c1.Valor2 = Convert.ToDouble(Console.ReadLine());

            Calculadora c1;
            c1 = new Calculadora(_valor1, _operador, _valor2);

            Console.Write("Resultado de: " + c1.Valor1 + c1.Operador + c1.Valor2 + " = " +c1.Resultado);
            
        }
    }
}

