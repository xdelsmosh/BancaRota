using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaRota
{
    class Cliente
    {
        private string nombreCliente;
        private int saldoCliente;

        public Cliente()
        {
        }

        public Cliente(string nombreCliente, int saldoCliente)
        {
            this.NombreCliente = nombreCliente;
            this.SaldoCliente = saldoCliente;
        }

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public int SaldoCliente { get => saldoCliente; set => saldoCliente = value; }
    }
}
