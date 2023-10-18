using System;

namespace Aula_17_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que recebe dois números e o tipo do operador (Soma(+), 
            //Subtração(-), Multiplicação(*) e Divisão(/)) e com base no operador devemos realizar a
            //operação e mostrar o resultado. 

            float num1, num2, resultado;
            string operador;

            Console.Write("Digite um numero: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("\nDigite outro numero: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("SOMA(+)");
            Console.WriteLine("SUBTRAÇÃO(-)");
            Console.WriteLine("MULTIPLICAÇÃO (*)");
            Console.WriteLine("DIVISÃO (/)");

            Console.Write("Digite um operador que deseja para realizar a conta: ");
            operador = (Console.ReadLine());

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.Write("\nO resultado é: " + resultado);
                    break;

                case "-":
                    resultado = num1 - num2;
                    Console.Write("\nO resultado é: " + resultado);
                    break;

                case "*":
                    resultado = num1 * num2;
                    Console.Write("\nO resultado é: " + resultado);
                    break;

                case "/":
                    resultado = num1 / num2;
                    Console.Write("\nO resultado é: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operador inválido");
                    break;

            }


        }
    }
}
