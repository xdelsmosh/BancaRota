namespace BancaRota
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCorriente = new System.Windows.Forms.RadioButton();
            this.rbVista = new System.Windows.Forms.RadioButton();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.gbTransacciones = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.txtRetiro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTransacciones = new System.Windows.Forms.ListBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbTransacciones.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.rbCorriente);
            this.groupBox1.Controls.Add(this.rbVista);
            this.groupBox1.Controls.Add(this.txtNomCliente);
            this.groupBox1.Controls.Add(this.txtNumeroCuenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // rbCorriente
            // 
            this.rbCorriente.AutoSize = true;
            this.rbCorriente.Location = new System.Drawing.Point(439, 110);
            this.rbCorriente.Name = "rbCorriente";
            this.rbCorriente.Size = new System.Drawing.Size(96, 22);
            this.rbCorriente.TabIndex = 6;
            this.rbCorriente.TabStop = true;
            this.rbCorriente.Text = "Corriente";
            this.rbCorriente.UseVisualStyleBackColor = true;
            // 
            // rbVista
            // 
            this.rbVista.AutoSize = true;
            this.rbVista.Location = new System.Drawing.Point(169, 112);
            this.rbVista.Name = "rbVista";
            this.rbVista.Size = new System.Drawing.Size(63, 22);
            this.rbVista.TabIndex = 5;
            this.rbVista.TabStop = true;
            this.rbVista.Text = "Vista";
            this.rbVista.UseVisualStyleBackColor = true;
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(169, 69);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(366, 24);
            this.txtNomCliente.TabIndex = 4;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(169, 26);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(366, 24);
            this.txtNumeroCuenta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Cuenta Bancaria";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Info;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.Image = global::BancaRota.Properties.Resources._430088_circle_close_delete_remove_icon;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(586, 96);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(174, 51);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.Info;
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrear.Image = global::BancaRota.Properties.Resources._925890_account_add_create_new_profile_icon;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.Location = new System.Drawing.Point(586, 23);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(174, 51);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // gbTransacciones
            // 
            this.gbTransacciones.Controls.Add(this.btnConsulta);
            this.gbTransacciones.Controls.Add(this.lbTransacciones);
            this.gbTransacciones.Controls.Add(this.groupBox4);
            this.gbTransacciones.Controls.Add(this.groupBox3);
            this.gbTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTransacciones.Location = new System.Drawing.Point(12, 191);
            this.gbTransacciones.Name = "gbTransacciones";
            this.gbTransacciones.Size = new System.Drawing.Size(775, 247);
            this.gbTransacciones.TabIndex = 1;
            this.gbTransacciones.TabStop = false;
            this.gbTransacciones.Text = "Transacciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDepositar);
            this.groupBox3.Controls.Add(this.txtDeposito);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Depositar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monto $";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(106, 35);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(165, 21);
            this.txtDeposito.TabIndex = 1;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(160, 71);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(111, 23);
            this.btnDepositar.TabIndex = 2;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRetirar);
            this.groupBox4.Controls.Add(this.txtRetiro);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Retirar";
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(160, 71);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(111, 23);
            this.btnRetirar.TabIndex = 2;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtRetiro
            // 
            this.txtRetiro.Location = new System.Drawing.Point(106, 35);
            this.txtRetiro.Name = "txtRetiro";
            this.txtRetiro.Size = new System.Drawing.Size(165, 21);
            this.txtRetiro.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto $";
            // 
            // lbTransacciones
            // 
            this.lbTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransacciones.FormattingEnabled = true;
            this.lbTransacciones.HorizontalScrollbar = true;
            this.lbTransacciones.ItemHeight = 15;
            this.lbTransacciones.Location = new System.Drawing.Point(314, 23);
            this.lbTransacciones.Name = "lbTransacciones";
            this.lbTransacciones.Size = new System.Drawing.Size(455, 154);
            this.lbTransacciones.TabIndex = 4;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.SpringGreen;
            this.btnConsulta.Location = new System.Drawing.Point(355, 184);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(378, 51);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consultar estado de cuenta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbTransacciones);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Banca Rota";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTransacciones.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCorriente;
        private System.Windows.Forms.RadioButton rbVista;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox gbTransacciones;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.TextBox txtRetiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ListBox lbTransacciones;
    }
}

