using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c = new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            c.NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            c.Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string sN = Console.ReadLine();

            if (sN == "s")
            {
                Console.Write("Entre o valor de depósito inicial:");
                c.DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine("Conta " + c.NumeroConta + ", " + "Titular: " + c.Nome + ", " + "Saldo: $ " + c.DepositoInicial.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("Entre um valor para depósito: ");
                c.Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Dados da conta atualizados");
                Console.WriteLine("Conta " + c.NumeroConta + ", " + "Titular: " + c.Nome + ", " + "Saldo: $ " + c.calculoDeposito().ToString("F2", CultureInfo.InvariantCulture));

                Console.Write("Entre um valor para saque: ");
                c.Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Dados da conta atualizados");
                Console.WriteLine("Conta " + c.NumeroConta + ", " + "Titular: " + c.Nome + ", " + "Saldo: $ " + c.calculoSaque().ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Dados da conta:");
                Console.WriteLine("Conta " + c.NumeroConta + ", " + "Titular: " + c.Nome + ", " + "Saldo: " + "R$ 0.00");
                Console.Write("Entre um valor para depósito: ");
                c.Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Dados da conta atualizados");
                Console.WriteLine("Conta " + c.NumeroConta + ", " + "Titular: " + c.Nome + ", " + "Saldo: $ " + c.calculoDeposito().ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("Entre um valor para saque: ");
                c.Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Dados da conta atualizados");
                Console.WriteLine("Conta " + c.NumeroConta + ", " + "Titular: " + c.Nome + ", " + "Saldo: $ " + c.calculoSaque().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
