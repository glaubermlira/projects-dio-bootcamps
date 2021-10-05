using System;

namespace Desafios.DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeiros desafios Matemáticos em C#
            
            // 1.Calcular a soma de dosi numeros:

            //Declare Variables
            // int A = Convert.ToInt32(Console.ReadLine());
            // int B = Convert.ToInt32(Console.ReadLine());

            //Insira as variaveis de acordo com o solicitado
            // int SOMA = A+B;

            //Print
            // Console.WriteLine("SOMA = {0}", SOMA);


            // 2.Leia um número inteiro que representa um código de DDD para discagem interurbana. Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:
            
            // int ddd = Convert.ToInt32(Console.ReadLine());

            // switch (ddd)
            // {
            //     case 61:
            //         Console.WriteLine("Brasilia");
            //         break;
            //     case 71:                             //complete os DDD's corretamente
            //         Console.WriteLine("Salvador");
            //         break;
            //     case 11:
            //         Console.WriteLine("Sao Paulo");
            //         break;
            //     case 21:
            //         Console.WriteLine("Rio de Janeiro");
            //         break;
            //     case 32:
            //         Console.WriteLine("Juiz de Fora");
            //         break;
            //     case 19:
            //         Console.WriteLine("Campinas");
            //         break;
            //     case 27:
            //         Console.WriteLine("Vitoria");
            //         break;
            //     case 31:
            //         Console.WriteLine("Belo Horizonte");
            //         break;
            //     default:
            //         Console.WriteLine("DDD nao cadastrado");
            //         break;

            // Introdução a Resolução de Desafios com C#
            // 1 / 4 - Múltiplos

                string[] valores = Console.ReadLine().Split(' ');
                int A = int.Parse(Console.ReadLine());
                int B = int.Parse(Console.ReadLine());

                if (A % B == 0 || B % A == 0 ) {
                    Console.WriteLine("Sao Multiplos");
                }
                else {
                    Console.WriteLine("Nao sao Multiplos");
                }                
            }
        }
    }
}
