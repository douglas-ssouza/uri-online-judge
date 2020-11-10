using System;

namespace SenhaFixa
{
    class Program
    {
        static void main(string[] args)
        {
            int senha;

            do{
                senha = Convert.ToInt32(Console.ReadLine());

                if (senha == 2002){
                    Console.WriteLine("Acesso Permitido");
                }else{
                    Console.WriteLine("Senha Invalida");
                }
            }while(senha != 2002);
        }
    }
}