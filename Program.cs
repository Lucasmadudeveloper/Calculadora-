using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Simples \n");
                Console.WriteLine("Escolha uma operação");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Sua escolha: ");

                int escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 5)
                    break;

                Console.WriteLine("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado ;

                switch (escolha) {
                    case 1:
                        resultado = Adicao(num1, num2);
                        Console.WriteLine($"resultado: {num1} + {num2} = {resultado}");
                        break;

                    case 2: resultado = Subtracao(num1, num2);
                        Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                        break;

                    case 3: resultado = Multiplicacao(num1, num2);
                        Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            resultado = Divisao(num1, num2);
                            Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                        }

                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida");
                        }
                        break;
                    default:
                        Console.WriteLine("Escolha invalida. Tente novamente");
                        break;

                }

                Console.WriteLine("Pressione Qual quer tecla para continuar...");
                Console.ReadKey();
            }
             double Adicao(double a, double b) => a + b;

             double Subtracao(double a, double b) => a - b;

             double Multiplicacao(double a, double b) => a * b;

             double Divisao(double a, double b) => a / b;
        }
    } 
}

        

