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
    public partial class FrmPedidoNovo : Form
    {
        public FrmPedidoNovo()
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
                Cliente.ObeterPorId(int.Parse(txtIdCliente.Text)), 0
                );
            txtIdPedido.Text = pedido.Id.ToString();

            //grbItens.Enable = true;
            //grbIdentificacao.Enabled = false;
            //txtCodbar.Focus();


        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodbar_Leave()
        {
           //  if (txtCodbar_Leave.TextLenght>0)
           // {
           //     var produto = Produto.ObterPorId(txtCodbar.Text); // Sobrecarga com String
           //     txtDescricao.Text = produto.Descricao;
           //     txtValorUnit.Text = produto.ValorUnit.ToString();
           //     txtValorUnit.ReadOnly = true;
           //     txtQuantidade.Focus();
           //
           //     
           // }

        }
   
    }
}
