﻿using System;
using System.Globalization;

namespace At08
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorImposto;
            if (salario <= 2000.0)
            {
                valorImposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                valorImposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                valorImposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                valorImposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (valorImposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}