using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha;
            int papel, senha;

            while (true)
            {
                linha = Console.ReadLine();

                if (string.IsNullOrEmpty(linha))
                {
                    break;
                }

                papel = Convert.ToInt32(linha);
                senha = papel - 1;

                Console.WriteLine(senha);
            }
        }
    }
}
