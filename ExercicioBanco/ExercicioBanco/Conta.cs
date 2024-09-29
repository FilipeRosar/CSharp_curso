using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    class Conta
    {
        public int Numero { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titularConta)
        {
            Numero = numero;
            TitularConta = titularConta;
        }

        public Conta(int numero, string titularConta, double depositoInicial) : this(numero, titularConta)
        {
            Deposito(depositoInicial);
        }
        public void Deposito(double qtd)
        {
            Saldo += qtd;
        }
        public void Saque(double qtd)
        {
            Saldo -= (qtd + 5.0);
        }


        public override string ToString()
        {
            return $"Conta: {Numero}, " +
                   $"Titular: {TitularConta}, " +
                   $"Saldo: $ {Saldo.ToString("F2")}";
        }
    }
}
