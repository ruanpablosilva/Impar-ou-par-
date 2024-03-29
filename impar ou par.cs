using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox1.Text, out int numero))
            {
                MessageBox.Show("Por favor, digite um número válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numero % 2 == 0)
            {
                lblResultado.Text = "O número é par.";
            }
            else
            {
                lblResultado.Text = "O número é ímpar.";
            }
        }

    }
}
//1 textbox funcional para por o numero, 1 button de comando e 2 label(1 de instrução e outro nomeando a página)