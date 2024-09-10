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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text!=string.Empty && txtSenha.Text!=string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text); 
                if (usuario.Id > 0)
                {
                    if (usuario.Ativo)
                    {
                        Program.UsarioLogado = usuario; // Bota logado no sistema
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Seu usuário esta Inativo. \n Procure Gêrencia"); // \n pula linha
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou senha Invalidos \n Procure Gerencia"); // Se estiver Vazio vai para os debaixo

                }

            }
             else
            {
                MessageBox.Show("Preencha Algo");
                Application.Exit();
            }

        }
       
        


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Application.Exit(); // Encerra to a aplicação e formas
        }
    } // Fim do Entrar Click
}
