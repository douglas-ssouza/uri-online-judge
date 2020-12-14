using System;

namespace Media3
{
    class Program
    {
        static void Main(string[] args){

            string linha = Console.ReadLine();
            string[] notas = linha.Split(' ');

            double nota1 = Convert.ToDouble(notas[0]);
            double nota2 = Convert.ToDouble(notas[1]);
            double nota3 = Convert.ToDouble(notas[2]);
            double nota4 = Convert.ToDouble(notas[3]);
            double exame;
            double media = (nota1 * 2 + nota2 * 3 + nota3 * 4 + nota4 * 1) / 10;

            Console.WriteLine("Media: {0}", Math.Round(media, 1).ToString("0.0"));

            if (media >= 7.0){
                Console.WriteLine("Aluno aprovado.");
            }else if (media < 5.0){
                Console.WriteLine("Aluno reprovado.");
            }else{
                Console.WriteLine("Aluno em exame.");
                exame = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nota do exame: {0}", Math.Round(exame, 1).ToString("0.0"));
                media = (media + exame) / 2;
                if (media >= 5.0){
                    Console.WriteLine("Aluno aprovado.");
                }else{
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: {0}", Math.Round(media, 1).ToString("0.0"));
            }

        }
    }
}