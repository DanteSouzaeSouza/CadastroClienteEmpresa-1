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
        Thread td;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (rdBtnCliente.Checked)
            {
                td = new Thread(cliente);
                td.SetApartmentState(ApartmentState.STA);
                td.Start();
            } else if (rdBtnEmpresa.Checked)
            {
                td = new Thread(empresa);
                td.SetApartmentState(ApartmentState.STA);
                td.Start();
            }
            
        }
        private void cliente(object obj)
        {
            Application.Run(new FrmCadCliente());
        }
        private void empresa(object obj)
        {
            Application.Run(new FrmCadEmpresa());
        }
    }
}
