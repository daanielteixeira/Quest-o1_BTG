using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string resp = "s";
            
            while (resp == "s" || resp == "S")
            { 
                Console.WriteLine("Notas Disponíveis: R$ 100,00; R$ 50,00; R$ 20,00 e R$ 10,00 \n");
                Console.WriteLine("Digite o valor que deseja sacar: \n");

                CalculaEImprime();
            
                Console.WriteLine("\nDeseja realizar um novo saque? S/N \n");
                
                resp = Console.ReadLine();
                Console.WriteLine();

                if(resp == "N" || resp == "n")
                {
                    Console.WriteLine("O programa será encerrado.");
                    Console.ReadLine();
                }

        }       
                
            
            

        }
        static void CalculaEImprime()
        {
            int notas10 = 20;
            int notas20 = 20;
            int notas50 = 20;
            int notas100 = 20;
            int valor = 0;
            int total10 = 20;
            int total20 = 20;
            int total50 = 20;
            int total100 = 20;
            


            var valorStr = Console.ReadLine();

            if ((int.TryParse(valorStr.ToString(), out valor)))

                if (valor % 10 != 0 || valor > 3600)
                {

                    Console.WriteLine("\nNão existem notas disponíveis para esta operação");
                }
                else
                {


                    while (valor >= 100)
                    {
                        if (notas100 > 0)
                        {
                            notas100 = notas100 - 1;
                            valor = valor - 100;
                        }
                        else
                        {
                            break;
                        }
                    }

                    while (valor >= 50)
                    {
                        if (notas50 > 0)
                        {
                            notas50 = notas50 - 1;
                            valor = valor - 50;
                        }
                        else
                        {
                            break;
                        }
                    }

                    while (valor >= 20)
                    {
                        if (notas20 > 0)
                        {
                            notas20 = notas20 - 1;
                            valor = valor - 20;
                        }
                        else
                        {
                            break;
                        }
                    }

                    while (valor >= 10)
                    {
                        if (notas10 > 0)
                        {
                            notas10 = notas10 - 1;
                            valor = valor - 10;
                        }
                        else
                        {
                            break;
                        }
                    }


                    Console.WriteLine("\nSaque total: \n" +
                    (total100 - notas100) + " nota(s) de 100 \n" +
                    (total50 - notas50) + " nota(s) de 50 \n" +
                    (total20 - notas20) + " nota(s) de 20 \n" +
                    (total10 - notas10) + " nota(s) de 10");

                    total100 = notas100;
                    total50 = notas50;
                    total20 = notas20;
                    total10 = notas10;
                }
        }
        
    }
}
