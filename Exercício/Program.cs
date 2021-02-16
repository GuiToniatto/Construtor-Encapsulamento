using System;
using System.Globalization;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o valor de depósito inicial. " +
                "Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação.");

            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcaoDeposito = char.Parse(Console.ReadLine());

            if (opcaoDeposito == 's' || opcaoDeposito == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valorDepositado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, nome, valorDepositado);
            }
            else
                conta = new ContaBancaria(numeroConta, nome);

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depóstio: ");
            conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
