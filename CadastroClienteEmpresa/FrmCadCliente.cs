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
    public partial class FrmCadCliente : Form
    {
        Thread td;
        public FrmCadCliente()
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
            String nome = textBox1.Text;
            int rg = Convert.ToInt32(textBox2.Text);
            int cpf = Convert.ToInt32(textBox3.Text);
            int telefone = Convert.ToInt32(textBox4.Text);
            String end = textBox5.Text;
            String est = comboBox1.Text;
            MessageBox.Show("Nome: " + nome + "\nRG: " + rg + "\nCPF: " + cpf + "\nTelefone: " + telefone + "\nEndereço: " + end + "\nEstado: " + est);
        }
    }
}
