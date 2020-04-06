using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.txtNumero2.Text = "";
            this.TxtNumero1.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(TxtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
        }

        private static double Operar(string numero1,string numero2,string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            double resultado= Calculadora.Operar(num1,num2,operador);
            return resultado;
            
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero ABinario = new Numero(lblResultado.Text);

            lblResultado.Text= ABinario.DecimalBinario(lblResultado.Text).ToString();
            
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero ADecimal = new Numero(lblResultado.Text);

            lblResultado.Text = ADecimal.BinarioDecimal(lblResultado.Text).ToString();
        }
    }
}
