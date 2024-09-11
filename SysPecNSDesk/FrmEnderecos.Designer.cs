namespace SysPecNSDesk
{
    partial class FrmEnderecos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            clnEndercoID = new DataGridViewTextBoxColumn();
            clnClienteID = new DataGridViewTextBoxColumn();
            clnCEP = new DataGridViewTextBoxColumn();
            clnEnderecoNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUF = new DataGridViewTextBoxColumn();
            dgvClientes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnEndercoID, clnClienteID, clnCEP, clnEnderecoNumero, clnComplemento, clnBairro, clnCidade, clnUF });
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_ContentClick;
            // 
            // clnEndercoID
            // 
            clnEndercoID.Frozen = true;
            clnEndercoID.HeaderText = "ID";
            clnEndercoID.Name = "clnEndercoID";
            clnEndercoID.ReadOnly = true;
            clnEndercoID.Width = 50;
            // 
            // clnClienteID
            // 
            clnClienteID.Frozen = true;
            clnClienteID.HeaderText = "Cliente";
            clnClienteID.Name = "clnClienteID";
            clnClienteID.ReadOnly = true;
            // 
            // clnCEP
            // 
            clnCEP.Frozen = true;
            clnCEP.HeaderText = "Logradouro";
            clnCEP.Name = "clnCEP";
            clnCEP.ReadOnly = true;
            // 
            // clnEnderecoNumero
            // 
            clnEnderecoNumero.Frozen = true;
            clnEnderecoNumero.HeaderText = "Número";
            clnEnderecoNumero.Name = "clnEnderecoNumero";
            clnEnderecoNumero.ReadOnly = true;
            // 
            // clnComplemento
            // 
            clnComplemento.Frozen = true;
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.Frozen = true;
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            // 
            // clnCidade
            // 
            clnCidade.Frozen = true;
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            clnCidade.Width = 110;
            // 
            // clnUF
            // 
            clnUF.Frozen = true;
            clnUF.HeaderText = "Tipo Endereço";
            clnUF.Name = "clnUF";
            clnUF.ReadOnly = true;
            clnUF.Width = 120;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnTelefone, clnEmail, clnAtivo });
            dgvClientes.Location = new Point(93, 114);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(612, 150);
            dgvClientes.TabIndex = 2;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 240;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            clnTelefone.Width = 130;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Data Nasc";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 130;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 60;
            // 
            // FrmEnderecos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClientes);
            Controls.Add(dataGridView1);
            Name = "FrmEnderecos";
            Text = "FrmEnderecos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnAtivo;
        private DataGridViewTextBoxColumn clnEndercoID;
        private DataGridViewTextBoxColumn clnClienteID;
        private DataGridViewTextBoxColumn clnCEP;
        private DataGridViewTextBoxColumn clnEnderecoNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUF;
    }
}