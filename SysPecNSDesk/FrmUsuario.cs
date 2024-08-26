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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var lista = Usuario.ObterLista();
            dgvUsuarios.Rows.Clear();
            int cont = 0;
            foreach (var usuario in lista)
            {
                // carregando o combobox de niveis
                var niveis = Nivel.ObterLista();
                cmbNivel.DataSource = niveis; // Pega dados do niveis source aqui
                cmbNivel.DisplayMember = "Nome";
                cmbNivel.ValueMember = "Id";

                // preenchendo datagrid com os usuarios

                dgvUsuarios.Rows.Add(); // Adiciona linha
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id; // Cells = Coluna
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[cont].Cells[4].Value = usuario.Ativo;


                cont++; //
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbNivel.SelectedValue.ToString());
            Usuario usuario = new();

        }
    }
}
