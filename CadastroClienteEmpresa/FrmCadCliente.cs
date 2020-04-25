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
    public partial class FrmCadCliente : Form
    {
        int rg = 0;
        public FrmCadCliente()
        {
            InitializeComponent();
        }
        
        public void clearDados()
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtCidade.Text = "";
            txtEst.Text = "";
            txtEnd.Text = "";
            txtRg.Text = "";
            txtTel.Text = "";
            txtCpf.Text = "";
            txtIdade.Text = "";
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clearDados();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            condicao();
        }

        private void condicao()
        {
            if (txtNome.Text == "" || txtIdade.Text == "" || txtCidade.Text == "" ||txtEst.Text == "" ||txtEnd.Text == "" || txtRg.Text == ""|| txtTel.Text == ""||txtCpf.Text == ""||txtIdade.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            } else
            {
                String nome = txtNome.Text;
                String cidade = txtCidade.Text;
                String estado = txtEst.Text;
                String endereco = txtEnd.Text;
                String sexo = txbSexo.Text;
                rg = Convert.ToInt32(txtRg.Text);
                int cpf = Convert.ToInt32(txtCpf.Text);
                int tel = Convert.ToInt32(txtTel.Text);
                int idade = Convert.ToInt32(txtIdade.Text);
                MessageBox.Show("Nome: " + nome + "\nSexo: " + sexo + "\nIdade: " + idade + "\nRG: " + rg + "\nCPF: " + cpf + "\nTelefone: " + tel + "\nEndereco: " + endereco + "\nCidade: " + cidade + "\nEstado: " + estado);
            }
        }
    }
}
