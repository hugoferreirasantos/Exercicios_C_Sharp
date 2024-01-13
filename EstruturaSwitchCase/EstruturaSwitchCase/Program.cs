﻿using System;
using System.Globalization;

namespace EstruturaSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura Switch - Case

            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda - feira";
                    break;
                case 3:
                    dia = "Terça - feira";
                    break;
                case 4:
                    dia = "Quarta - feira";
                    break;
                case 5:
                    dia = "Quinta - feira";
                    break;
                case 6:
                    dia = "Sexta - feira";
                    break;
                case 7:
                    dia = "Sábado";
                    break;
                default:
                    dia = "Dia inválido";
                    break;
            }

            Console.WriteLine($"Dia da semana: {dia}");

        }
    }
}