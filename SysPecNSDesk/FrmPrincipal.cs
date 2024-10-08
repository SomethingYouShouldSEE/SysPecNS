﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadatrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new();
            //frmLogin.MdiParent = this; Tirando o FrmPrincipal como Pai para FrmLogin ter Patencia sobre o FrmPrincipal
            //frmLogin.Show();
            frmLogin.ShowDialog(); //Usado par

            Text += $"({Program.UsarioLogado.Email})"; // Bota o email na parte superior da Tela

            toolStripStatusLabel1.Text = $"{Program.UsarioLogado.Nome} - {Program.UsarioLogado.Nivel.Nome}"; // Pega o informações de Classe usuario e colocaca aqui + Nivel
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            frmUsuario.MdiParent = this; // Indicando a tabela que este comando esta 
            frmUsuario.Show(); // na hora que clicar em mostra tabela usuario

            //frmUsuario.ShowDialog(); --
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmCliente frmCliente = new();
            //frmCliente.MdiParent = this
            //frmCliente.Show();
        }

        private void operaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(VerificarControles())
            //{
            //
            //}

            var msg = MessageBox.Show("Deseja", "Confirmação de Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes) Application.Exit(); // Botão 'MessageBoxButtons.YesNo'
            // Messsage Box Usando MessageBox, Buttons, Warnings

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmcliente = new();
            frmcliente.MdiParent = this;
            frmcliente.Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduto frmproduto = new();
            frmproduto.MdiParent = this;
            frmproduto.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmEndereco frmendereco = new();
            //frmEndereco.MdiParent = this;
            //frmEndereco.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidosNovo frmPedido = new();
            frmPedido.MdiParent = this;
            frmPedido.Show();
        }

        // private void 
        // {
        //     FrmPedidosNovo frmPedido = new();
        //     frmpedido.MdiParent = this;
        //     frmpedido.Show();
        // }

    }
}
