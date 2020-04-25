using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClienteEmpresa
{
    public partial class FrmCadEmpresa : Form
    {
        public FrmCadEmpresa()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            String rSocial = textBox1.Text;
            String nFantasia = textBox2.Text;
            int cnpj = Convert.ToInt32(textBox3.Text);
            int tel = Convert.ToInt32(textBox4.Text);
            String end = textBox5.Text;
            String cid = textBox6.Text;
            String est = comboBox1.Text;
            MessageBox.Show("Razão Social: " + rSocial + "\nNome Fantasia: " + nFantasia + "\nCNPJ: " + cnpj + "\nTelefone: " + tel + "\nEndereço: " + end + "\nCidade: " + cid + "\nEstado: " + est);
        }
    }
}
