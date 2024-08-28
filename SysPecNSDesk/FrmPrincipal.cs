using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadatrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            frmUsuario.MdiParent = this; // Indicando a tabela que este comando esta 
            frmUsuario.Show(); // na hora que clicar em mostra tabela usuario

            //frmUsuario.ShowDialog(); --
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmCliente frmCliente = new();
            //frmCliente.MdiParent = this
            //frmCliente.Show();
        }
    }
}
