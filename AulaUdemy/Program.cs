﻿using System;
using System.Globalization;

namespace AulaUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque seu nome:  ");

            string nome = Console.ReadLine();
            Console.WriteLine("Sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("................................................................");
            Console.WriteLine("Seu nome:  " +nome +" Voce tem  " +idade + " anos de idade");

            
        }
    }
}
