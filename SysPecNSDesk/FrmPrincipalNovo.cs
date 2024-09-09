using SysPecNSLib;
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
    public partial class FrmPrincipalNovo : Form
    {
        public FrmPrincipalNovo()
        {
            InitializeComponent();
        }

        private void FrmPrincipalNovo_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsarioLogado.Id + " - " + Program.UsarioLogado.Nome;
        }

        private void btnInseriPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
                Program.UsarioLogado,
                Cliente.ObeterPorId(int.Parse(txtIdCliente.Text)),0
                );
            txtIdPedido.Text = pedido.Id;
            MessageBox.Show($"Novo pedido criado - {pedido.Id}");
        }
    }
}
