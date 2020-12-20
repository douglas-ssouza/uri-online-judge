using System;

namespace SequenciaIJ4
{
    class Program
    {
        static void Main(string[] args){

            for (double i = 0; i <= 2; i += 0.2){
            for (double j = i + 1, c = 0; c < 3; j++, c++){
                if( i==0 || (i>0.9 && i<1.1) || (i>1.9 && i<2.1) || (i>2.9 && i<3.1) ){
                    Console.WriteLine("I=" + i + " J=" + j);
                }else{
                    Console.WriteLine("I={0} J={1}", i.ToString("0.0"), j.ToString("0.0"));
                }
            }
        }

        }
    }
}