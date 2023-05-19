using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaRota
{
    class Cuenta : Cliente
    {
        private string numeroCuenta;
        private string tipoCuenta;

        public Cuenta()
        {
        }

        public Cuenta(string numeroCuenta, string tipoCuenta)
        {
            this.NumeroCuenta = numeroCuenta;
            this.TipoCuenta = tipoCuenta;
        }

        public string NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }

        public void Deposito(int cantidad)
        {
            SaldoCliente += cantidad;
        }

        public bool Retiro(int cantidad)
        {
            if(SaldoCliente >= cantidad)
            {
                SaldoCliente -= cantidad;
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Saldo insuficiente" + "\n" +
                    "Operación Invalida");
                return false;
            }
        }
    }
}
