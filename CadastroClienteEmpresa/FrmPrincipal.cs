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
    public partial class FrmPrincipal : Form
    {
        Thread nt;
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadCliente cliente = new FrmCadCliente();
            FrmCadEmpresa empresa = new FrmCadEmpresa();

            if (rdBtnCliente.Checked)
            {
                this.Close();
                nt = new Thread(cadastroCliente);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else if (rdBtnEmpresa.Checked)
            {
                this.Close();
                nt = new Thread(cadastroEmpresa);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }

        private void cadastroEmpresa()
        {
            Application.Run(new FrmCadEmpresa());
        }

        private void cadastroCliente()
        {
            Application.Run(new FrmCadCliente());
        }
    }
}
