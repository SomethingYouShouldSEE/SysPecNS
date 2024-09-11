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
    public partial class FrmPedidosNovo : Form
    {
        public FrmPedidosNovo()
        {
            InitializeComponent();
        }

        private void FrmPedidosNovo_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsarioLogado.Id + " - " + Program.UsarioLogado.Nome;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserirPedido_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnInserirPedido_Click_1(object sender, EventArgs e)
        {
            Pedido pedido = new(
                Program.UsarioLogado,
                Cliente.ObeterPorId(int.Parse(txtIdCliente.Text)), 0
                );
            txtIdPedido.Text = pedido.Id.ToString();

            grbItens.Enabled = true;
            grbIdentificacao.Enabled = false;
            txtCodbar.Focus();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Produto produto = new();
            ItemPedido item = new(
                int.Parse(txtIdPedido.Text),
                produto,
                produto.ValorUnit,
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
            );


        }

        private void PreencherGridItens()
        {
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));
            int linha = 0;
            dgvItensPedido.Rows.Clear();
            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = item.Id;
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBar;
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit;
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade;
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Desconto;
                dgvItensPedido.Rows[linha].Cells[4].Value = item.ValorUnit * item.Quantidade - item.Desconto;
                linha++;
                //total += item.ValorUnit * item.Quantidade - item.Desconto;


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
