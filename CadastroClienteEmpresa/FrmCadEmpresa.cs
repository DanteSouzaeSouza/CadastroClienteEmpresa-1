using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CadastroClienteEmpresa
{
    public partial class FrmCadEmpresa : Form
    {
        Thread td;
        public FrmCadEmpresa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            td = new Thread(telaInicial);
            td.SetApartmentState(ApartmentState.STA);
            td.Start();
        }
        private void telaInicial()
        {
            Application.Run(new FrmPrincipal());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String rSocial = textBox1.Text;
            String nFantasia = textBox2.Text;
            dynamic cnpj = Convert.ToInt32(textBox3.Text);
            dynamic telefone = Convert.ToInt32(textBox4.Text);
            String end = textBox5.Text;
            String est = comboBox1.Text;
            MessageBox.Show("Razão Social: " + rSocial + "\nNome Fantasia: " + nFantasia + "\nCNPJ: " + cnpj + "\nTelefone: " + telefone + "\nEndereço: " + end + "\nEstado: " + est);
        }
    }
}
