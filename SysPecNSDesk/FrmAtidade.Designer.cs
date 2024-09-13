namespace SysPecNSDesk
{
    partial class FrmAtidade
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
            txtEstoqueId = new TextBox();
            label1 = new Label();
            dgvEstoque = new DataGridView();
            txtQuant = new TextBox();
            label2 = new Label();
            txtProdID = new TextBox();
            clnID = new DataGridViewTextBoxColumn();
            clnProdID = new DataGridViewTextBoxColumn();
            clnDataMov = new DataGridViewTextBoxColumn();
            label3 = new Label();
            btnAdicionar = new Button();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtEstoqueId
            // 
            txtEstoqueId.Location = new Point(50, 46);
            txtEstoqueId.Name = "txtEstoqueId";
            txtEstoqueId.Size = new Size(42, 23);
            txtEstoqueId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 28);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { clnID, clnProdID, clnDataMov });
            dgvEstoque.Location = new Point(50, 221);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.Size = new Size(350, 191);
            dgvEstoque.TabIndex = 2;
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(50, 138);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(100, 23);
            txtQuant.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 120);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantidade";
            // 
            // txtProdID
            // 
            txtProdID.Location = new Point(50, 92);
            txtProdID.Name = "txtProdID";
            txtProdID.Size = new Size(100, 23);
            txtProdID.TabIndex = 5;
            // 
            // clnID
            // 
            clnID.Frozen = true;
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 50;
            // 
            // clnProdID
            // 
            clnProdID.Frozen = true;
            clnProdID.HeaderText = "Produto ID";
            clnProdID.Name = "clnProdID";
            clnProdID.ReadOnly = true;
            // 
            // clnDataMov
            // 
            clnDataMov.Frozen = true;
            clnDataMov.HeaderText = "Data de Movimento";
            clnDataMov.Name = "clnDataMov";
            clnDataMov.ReadOnly = true;
            clnDataMov.Width = 200;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 74);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "Produto ID";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(115, 192);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(265, 192);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // FrmAtidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(448, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(btnAdicionar);
            Controls.Add(label3);
            Controls.Add(txtProdID);
            Controls.Add(label2);
            Controls.Add(txtQuant);
            Controls.Add(dgvEstoque);
            Controls.Add(label1);
            Controls.Add(txtEstoqueId);
            Name = "FrmAtidade";
            Text = "FrmAtidade";
            Load += FrmAtidade_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEstoqueId;
        private Label label1;
        private DataGridView dgvEstoque;
        private TextBox txtQuant;
        private Label label2;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnProdID;
        private DataGridViewTextBoxColumn clnDataMov;
        private TextBox txtProdID;
        private Label label3;
        private Button btnAdicionar;
        private Button btnAtualizar;
    }
}