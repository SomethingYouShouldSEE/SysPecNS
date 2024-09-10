using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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

        private void btnAdditem_Click()
        {

            ItemPedido item = new(
                int.Parce(txtIdPedido.Text),
                produto,
                produto.ValorUnit,
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
                );

            Item.Inserir();
            produto = new();
            txtDescontoItem.Text = "0";
            txtDescricao.Clear();
            txtValorUnit.Text = "0";
            txtCodbar.Clear();
            txtCodbar.Focus();

            private void PreencherGridItens() 
            {
                var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));
                int linha = 0
                dgvItensPedido.Rows.Clear();
                foreach(var item in itens)
                {
                    dgvItensPedido.Rows.Add();
                    dgvItensPedido.Rows[linha].Cells[0].Value = item.Id;
                    dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBar;
                    dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                    dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit;
                    dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade;
                    dgvItensPedido.Rows[linha].Cells[4].Value = item.Desconto;
                    dgvItensPedido.Rows[linha].Cells[4].Value = item.ValorUnit * item.Quantidade - item.Desconto;
                    linha++
                    total += item.ValorUnit * item.Quantidade - item.Desconto;
                }



            }


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
