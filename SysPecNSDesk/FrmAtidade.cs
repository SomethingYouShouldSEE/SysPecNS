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
    public partial class FrmAtidade : Form
    {

        public FrmAtidade()
        {
            InitializeComponent();
        }

        private void FrmAtidade_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            // preenchendo datagrid com os usuarios

            var lista = Estoque.ObterList();
            int cont = 0;
            //var test = Cliente
            //var testee = Produto.ObterSóId(int.Parse(txtProdID.Text));


            dgvEstoque.Rows.Clear();
            foreach (var row in lista)
            {
                dgvEstoque.Rows.Add(); // Adiciona linha
                dgvEstoque.Rows[cont].Cells[0].Value = row.Id; // Cells = Coluna
                dgvEstoque.Rows[cont].Cells[1].Value = row.Quantidade;
                dgvEstoque.Rows[cont].Cells[2].Value = row.Data_Movimento;

                cont++;
            }
        }

        private void txtQuant_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtProdID.Text == "" || mskQuantAdd.Text == "")
            {
                MessageBox.Show("Para Adionar um Produto Adione \n Um ID Para Verificação e Quantidade Inicial");
            }
            else
            {

               // var testee = Produto.ObterSóId(int.Parse(txtProdID.Text));
               // if(txtProdID.Text == testee)
              
                // Armazenando valor do grid
                Estoque estoque_add = new(
                    Produto.ObterPorId(int.Parse(txtProdID.Text)),
                    decimal.Parse(mskQuantAdd.Text)
                    );
               

                estoque_add.Estoque_Insert();


                //txtProdID.Clear;
                //txtQuantAdd.Clear;
                //Message
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {


            var GetCell = dgvEstoque.CurrentCell.Value; // Pega valor do cell selecionado no grid
            var posicaoLinha = dgvEstoque.Rows[0];

        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
