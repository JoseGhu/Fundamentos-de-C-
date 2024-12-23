﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double.TryParse(Console.ReadLine(), out nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota Inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota Inválida? {0}", nota < 0.0);
            Console.WriteLine("Perfeita? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou na média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);

           
        }
    }
}
