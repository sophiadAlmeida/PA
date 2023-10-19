using System;

namespace Aula_19_10_2023_while_ex03
{
    class Program
    {
            static void Main(string[] args)
        
            {   
                int fator;
                int numeroFinal;


                Console.WriteLine("Informe o Fator: ");
                fator = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o número Final: ");
                numeroFinal = int.Parse(Console.ReadLine());

                //2 x 1 = 2
                int contador = 1;
                while (contador <= numeroFinal)
                {
                    Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                    //contador = contador + 1;
                    contador++;

                }
                Console.WriteLine("*** FIM DA TABUADA***");
            }
    }
}
