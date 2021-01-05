using System;
using System.Linq;

namespace ConverterParaHexadecimal
{
    class Program
    {
        static void Main(string[] args){

            int valor = Convert.ToInt32(Console.ReadLine());
            string hexa = "";

            if (valor > 0 && valor < 10){
                hexa += Convert.ToString(valor);
            }else if (valor < 16){
                switch (valor){
                    case 10:
                        hexa += "A";
                        break;
                    case 11:
                        hexa += "B";
                        break;
                    case 12:
                        hexa += "C";
                        break;
                    case 13:
                        hexa += "D";
                        break;
                    case 14:
                        hexa += "E";
                        break;
                    case 15:
                        hexa += "F";
                        break;
                }
            }else{
                while (valor >= 16){
                    if ((valor % 16 >= 10) && (valor % 16 <= 15)){
                        switch (valor){
                            case 10:
                                hexa += "A";
                                break;
                            case 11:
                                hexa += "B";
                                break;
                            case 12:
                                hexa += "C";
                                break;
                            case 13:
                                hexa += "D";
                                break;
                            case 14:
                                hexa += "E";
                                break;
                            case 15:
                                hexa += "F";
                                break;
                        }
                    }else if (valor % 16 > 0){
                        hexa += Convert.ToString(valor % 16);
                    }

                    valor = valor / 16;

                    if (valor < 16){
                        hexa += Convert.ToString(valor / 16);
                    }

                }                   
            }
            

            Console.WriteLine(hexa);

        }
    }
}