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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_ContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void CarregaGrid(string nome = "")
        {
            // preenchendo datagrid com os usuarios

            var lista = Cliente.ObterLista();
            int cont = 0;
            foreach (var row in lista)
            {

                dgvClientes.Rows.Add(); // Adiciona linha
                dgvClientes.Rows[cont].Cells[0].Value = row.Id; // Cells = Coluna
                dgvClientes.Rows[cont].Cells[1].Value = row.Nome;
                dgvClientes.Rows[cont].Cells[2].Value = row.CPF;
                dgvClientes.Rows[cont].Cells[3].Value = row.Telefone;
                dgvClientes.Rows[cont].Cells[4].Value = row.Email;
                dgvClientes.Rows[cont].Cells[5].Value = row.DataNasc;
                dgvClientes.Rows[cont].Cells[6].Value = row.TimeStamp;
                dgvClientes.Rows[cont].Cells[7].Value = row.Ativo;


                cont++;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            Cliente cliente = new(
                txtClienteNome.Text,
                txtEmail.Text,
                mskCPF.Text,
                txtTelefone.Text,
                DateTime.Parse(mskDataNasc.Text) // Convertento Text para date time

                );

                

        }
    }
}
