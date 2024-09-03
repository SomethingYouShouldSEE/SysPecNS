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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(txtCodigoBarras.Text,txtDescricao.Text,
                double.Parse(txtUnidadeVenda.Text),txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)dmEstoqueMinimo.Value,double.Parse(txtDesconto.Text)
                );

            produto.Inserir();
        
            if (produto.Id>0)
            {

            }
            
                
                
                );
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsertar_Click(object sender, EventArgs e)
        {

        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Produto.ObterLista();
            dgProdutos.Rows.Clear();
            int cont = 0;

            var produtos = Produto.ObterLista();
            cmbCategoria.DataSource = produtos;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";

            foreach (var produto in lista)
            {


                dgProdutos.Rows.Add();
                dgProdutos.Rows[cont].Cells[0].Value = produto.Id;
                dgProdutos.Rows[cont].Cells[1].Value = produto.CodBar;
                dgProdutos.Rows[cont].Cells[2].Value = produto.Descricao;
                dgProdutos.Rows[cont].Cells[3].Value = produto.ValorUnit;
                dgProdutos.Rows[cont].Cells[4].Value = produto.UnidadeVenda;
                dgProdutos.Rows[cont].Cells[5].Value = produto.Categoria.Nome;
                dgProdutos.Rows[cont].Cells[6].Value = produto.EstoqueMinimo;
                dgProdutos.Rows[cont].Cells[7].Value = produto.ClasseDesconto;
                dgProdutos.Rows[cont].Cells[8].Value = produto.DataCad;

                cont++;
            }

        }





        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dgProdutos_ContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnidadeVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
