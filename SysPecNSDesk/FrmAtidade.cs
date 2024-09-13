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

        }

        private void CarregaGrid()
        {
            // preenchendo datagrid com os usuarios

            var lista = Estoque.ObterList();
            int cont = 0;
            //var test = Cliente

            dgvEstoque.Rows.Clear();
            foreach (var row in lista)
            {


                dgvEstoque.Rows.Add(); // Adiciona linha
                dgvEstoque.Rows[cont].Cells[0].Value = row.Id; // Cells = Coluna
                dgvEstoque.Rows[cont].Cells[1].Value = row.Nome;
                dgvEstoque.Rows[cont].Cells[2].Value = row.CPF;

                cont++;
            }
        }

        private void txtQuant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
