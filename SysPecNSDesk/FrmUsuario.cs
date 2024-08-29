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
            CarregaGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(cmbNivel.SelectedValue.ToString()); Mostra Nivel na tela
            Usuario usuario = new(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                txtId.Text = usuario.Nome;
                MessageBox.Show($"O usuario {usuario.Nome}, foi gravado com sucesso com o ID {usuario.Id}");
                txtNome.Clear();
                txtEmail.Clear(); // Limpa as partes da tabela de inserir
                txtConfSenha.Clear();
                txtSenha.Clear();
                txtNome.Focus();

                FrmUsuario_Load(sender, e); // Recarega o usuario assim que for inserido
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar");
            }

        }

        private void txtBusca_TextChanged(object sender, EventArgs e) // Quando mudar faça
        {
            if (txtBusca.Text.Length > 0) // Se em txtBusca for maior de 0 taca o carregaGrid em txtBusca
            {
                CarregaGrid(txtBusca.Text);
            }
            else
            {
                CarregaGrid(); // txtBusca Pode voltar vazio 
            }
        }

        private void CarregaGrid(string nome = "")
        {
            // preenchendo datagrid com os usuarios

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



                dgvUsuarios.Rows.Add(); // Adiciona linha
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id; // Cells = Coluna
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[cont].Cells[4].Value = usuario.Ativo;


                cont++; //
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarControler())
            {
                var msg = MessageBox.Show("Deseja continuar a edição", "Confirmação de Saída",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (msg == DialogResult.No) this.Close(); // Botão 'MessageBoxButtons.YesNo'                                                           // Messsage Box Usando MessageBox, Buttons, Warnings
            }
            else
            {
                Close();
            }


            //this.Close();
        }

        private bool VerificarControler()
        {
            if (txtNome.Text != string.Empty
                || txtEmail.Text != string.Empty
                || txtSenha.Text != string.Empty
                || txtConfSenha.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
