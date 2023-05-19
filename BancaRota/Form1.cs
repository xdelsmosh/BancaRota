using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancaRota
{
    public partial class Form1 : Form
    {
        Cuenta objCuenta = new Cuenta();
        public Form1()
        {
            InitializeComponent();
            limpiar();
        }

        public void limpiar()
        {
            txtNumeroCuenta.Text = "";
            txtNomCliente.Clear();
            rbCorriente.Checked = false;
            rbVista.Checked = false;
            gbTransacciones.Visible = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            gbTransacciones.Visible = true;
            string tipoCuenta = "";
            if (rbVista.Checked == true)
            {
                tipoCuenta = "Cuenta Vista";
            }

            else if(rbCorriente.Checked == true)
            {
                tipoCuenta = "Cuenta Corriente";
            }

            objCuenta.NumeroCuenta = txtNumeroCuenta.Text;
            objCuenta.NombreCliente = txtNomCliente.Text;
            objCuenta.TipoCuenta = tipoCuenta;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtDeposito.Text);
            objCuenta.Deposito(cantidad);
            lbTransacciones.Items.Add("N° Cuenta: " + objCuenta.NumeroCuenta + ", MONTO DEPOSITADO: $" + cantidad + " CLP.");
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtRetiro.Text);
            if (objCuenta.Retiro(cantidad))
            {
                lbTransacciones.Items.Add("N° Cuenta: " + objCuenta.NumeroCuenta + ", MONTO RETIRADO: $" + cantidad + " CLP.");
            }
            else 
            {
                lbTransacciones.Items.Add("N° Cuenta: " + objCuenta.NumeroCuenta + "--/ OPERACIÓN NO VALIDA /-- (SALDO INSUFICIENTE).");
            }

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("E S T A D O  D E  C U E N T A" + "\n" +
                "N° Cuenta: " + objCuenta.NumeroCuenta + "\n" +
                "Cliente: " + objCuenta.NombreCliente + "\n" +
                "Tipo Cuenta: " + objCuenta.TipoCuenta + "\n" +
                "Saldo: " + objCuenta.SaldoCliente.ToString() + " CLP.\n" +
                DateTime.Now.ToString());
        }
    }
}