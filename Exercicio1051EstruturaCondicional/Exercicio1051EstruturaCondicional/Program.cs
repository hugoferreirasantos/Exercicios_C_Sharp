﻿using System;
using System.Globalization;

namespace Exercicio1051EstruturaCondicional
{
    class Program
    { 
        static void Main(string[] args)
        {
            double salario, imposto;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Verificação Condicional do Imposto: 
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }


            //Condicional de emissão:
            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }

}
