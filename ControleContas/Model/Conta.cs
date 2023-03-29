using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Conta
    {

        private string _numero;
        private decimal _saldo;
        private static decimal _saldoTotal;
        private static string _contaMaiorSaldo;
        private static decimal _MaiorSaldo;


        //Polimorfismo de sobrecarga
        public Conta(string numero)
        {
            _numero = numero;
        }

        public Conta(string numero, decimal saldo, Cliente titular)
        {
            _saldo = saldo;
            _numero = numero;
            _saldoTotal += saldo;
            Titular = titular;
            if
                (_saldo > _MaiorSaldo)
            {
                _MaiorSaldo = _saldo;

                _contaMaiorSaldo = _numero;
            }


        }

        public Conta(string numero, Cliente titular)
        {

            _numero = numero;

            Titular = titular;
        }

        public string Numero
        {
            get => _numero;
            private set => _numero = value;
        }
        public decimal Saldo
        {
            get => _saldo;
            private set => _saldo = value;
        }
        public decimal SaldoTotal { get => _saldoTotal; private set => _saldoTotal = value; }

        public string ContaMaiorSaldo
        {

            get => _contaMaiorSaldo;
        }

        public Cliente Titular { get; set; }

        public void Deposito(decimal valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }

        }


        public decimal Saque(decimal valorSaque)
        {
            if (valorSaque > _saldo)
            {
                throw new ArgumentException("O valor do saque não podera deixar a conta negativa");
            }
            
            _saldo -= valorSaque;
            return _saldo;
        }

        public Conta(int numero)
        {

        }

    }
}


       
           

