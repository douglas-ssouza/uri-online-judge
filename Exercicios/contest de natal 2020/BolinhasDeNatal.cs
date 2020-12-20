using System;

namespace BolinhasDeNatal
{
    class Program
    {
        static void Main(string[] args){

            int bolinhas, galhos, minimo, diferença;

            bolinhas = Convert.ToInt32(Console.ReadLine());
            galhos = Convert.ToInt32(Console.ReadLine());

            minimo = galhos / 2;

            if (bolinhas >= minimo){
                Console.WriteLine("Amelia tem todas bolinhas!");
            }else{
                diferença = minimo - bolinhas;
                Console.WriteLine("Faltam " + diferença + " bolinha(s)");
            }

        }
    }
}