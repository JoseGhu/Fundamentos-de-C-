using System;
using System.Collections.Generic;
using System.Text;


namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Àrea é " + area);

            //Tipos Internos:

            bool estachovendo = true;
            Console.WriteLine("Esta chovendo " + estachovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Saláro " + salario);

            int menorValorInt = int.MinValue; //Mais usados nos inteiros
            Console.WriteLine("Menor Int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long " + menorValorLong);

            ulong populacaoMundal = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundal);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço do computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000; //Mais usados dos reais
            Console.WriteLine("Valor de Mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Dstãncia entre as estrelas " + distanciaEntreAsEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);

        }
    }
}
