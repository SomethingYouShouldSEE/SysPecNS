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
    public partial class FrmProduto : Form // Tudo que há em Form sera herado para FrmProduto, pode ser usado para outra classe acessar qualquer coisa da outra / classe não podera ser estatica
    {
        public FrmProduto()
        {
            InitializeComponent();
        }



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(txtCodigoBarras.Text,
                txtDescricao.Text,
                double.Parse(txtUnidadeVenda.Text), // Transformando string em double com parse
                txtUnidadeVenda.Text, 
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)dmEstoqueMinimo.Value,double.Parse(txtDesconto.Text)
                );

            produto.Inserir();
            
               
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                int.Parse(txtId.Text),
                txtCodigoBarras.Text, txtDescricao.Text,
                double.Parse(txtValorUnit.Text),
                txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)dmEstoqueMinimo.Value,
                double.Parse(txtDesconto.Text),
                null,
                null
                );
            produto.Atualizar();
            MessageBox.Show($"Produto {produto.Id} - {produto.Descricao} atualizado");
            btnEditar.Enabled = false;
            txtId.ReadOnly = true;
            btnConsultar.Text = "&Consultar";
            LimpaControles();
            FrmProduto_Load(sender, e);
   
        }

        private void LimpaControles()
        {
            txtCodigoBarras.Clear();
            txtValorUnit.Clear();
            txtDescricao.Clear();
            txtDesconto.Clear();
        }

        private void btnConsertar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtCodigoBarras.Clear();
                txtValorUnit.Clear();
                txtDescricao.Clear();
                txtDesconto.Clear();
                dmEstoqueMinimo.Value = 0;
                btnConsultar.Text = "&ObterPorId";
                txtId.Focus();

            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Produto produto = Produto.ObterPorId(int.Parse(txtId.Text));
                    txtCodigoBarras.Text = produto.CodBar;
                    txtValorUnit.Text = Convert.ToString(produto.ValorUnit);
                    txtDescricao.Text = produto.Descricao;
                    txtDesconto.Text = produto.ClasseDesconto.ToString();
                    txtUnidadeVenda.Text = produto.UnidadeVenda;
                    cmbCategoria.SelectedIndex = cmbCategoria.FindString(produto.Categoria.Nome);
                    btnEditar.Enabled = true;
                }
            }
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Produto.ObterLista();
            dgProdutos.Rows.Clear();
            int cont = 0;


            foreach (var produto in lista)
            {

                dgProdutos.Rows.Add();
                dgProdutos.Rows[cont].Cells[0].Value = produto.Id;
                dgProdutos.Rows[cont].Cells[1].Value = produto.CodBar;
                dgProdutos.Rows[cont].Cells[2].Value = produto.Descricao;
                dgProdutos.Rows[cont].Cells[3].Value = produto.ValorUnit;
                dgProdutos.Rows[cont].Cells[4].Value = produto.UnidadeVenda;
                dgProdutos.Rows[cont].Cells[5].Value = produto.Categoria;
                dgProdutos.Rows[cont].Cells[6].Value = produto.EstoqueMinimo;
                dgProdutos.Rows[cont].Cells[7].Value = produto.ClasseDesconto;
                dgProdutos.Rows[cont].Cells[8].Value = produto.DataCad;

                cont++;
            }

        }





        private void FrmProduto_Load(object sender, EventArgs e)
        {
            var categoria = Categoria.ObterLista();
            cmbCategoria.DataSource = categoria;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
            CarregaGrid();
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
