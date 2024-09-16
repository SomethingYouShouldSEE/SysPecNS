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
            clnID = new DataGridViewTextBoxColumn();
            clnProdID = new DataGridViewTextBoxColumn();
            clnDataMov = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtProdID = new TextBox();
            label3 = new Label();
            btnAdicionar = new Button();
            btnAtualizar = new Button();
            gbAdd = new GroupBox();
            gbUpt = new GroupBox();
            label4 = new Label();
            mskQuantUpt = new MaskedTextBox();
            mskQuantAdd = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            gbAdd.SuspendLayout();
            gbUpt.SuspendLayout();
            SuspendLayout();
            // 
            // txtEstoqueId
            // 
            txtEstoqueId.Location = new Point(66, 48);
            txtEstoqueId.Name = "txtEstoqueId";
            txtEstoqueId.Size = new Size(42, 23);
            txtEstoqueId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 30);
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
            dgvEstoque.CellContentClick += dgvEstoque_CellContentClick;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 76);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantidade";
            // 
            // txtProdID
            // 
            txtProdID.Location = new Point(63, 48);
            txtProdID.Name = "txtProdID";
            txtProdID.Size = new Size(42, 23);
            txtProdID.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 30);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "Produto ID";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(50, 148);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(51, 149);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 7;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // gbAdd
            // 
            gbAdd.Controls.Add(mskQuantAdd);
            gbAdd.Controls.Add(btnAdicionar);
            gbAdd.Controls.Add(label2);
            gbAdd.Controls.Add(label3);
            gbAdd.Controls.Add(txtProdID);
            gbAdd.Location = new Point(50, 28);
            gbAdd.Name = "gbAdd";
            gbAdd.Size = new Size(171, 187);
            gbAdd.TabIndex = 8;
            gbAdd.TabStop = false;
            // 
            // gbUpt
            // 
            gbUpt.Controls.Add(mskQuantUpt);
            gbUpt.Controls.Add(btnAtualizar);
            gbUpt.Controls.Add(label4);
            gbUpt.Controls.Add(txtEstoqueId);
            gbUpt.Controls.Add(label1);
            gbUpt.Location = new Point(229, 28);
            gbUpt.Name = "gbUpt";
            gbUpt.Size = new Size(171, 187);
            gbUpt.TabIndex = 9;
            gbUpt.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 76);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 4;
            label4.Text = "Quantidade";
            // 
            // mskQuantUpt
            // 
            mskQuantUpt.Location = new Point(38, 94);
            mskQuantUpt.Mask = "0,00";
            mskQuantUpt.Name = "mskQuantUpt";
            mskQuantUpt.Size = new Size(100, 23);
            mskQuantUpt.TabIndex = 8;
            mskQuantUpt.TextAlign = HorizontalAlignment.Center;
            // 
            // mskQuantAdd
            // 
            mskQuantAdd.Location = new Point(36, 94);
            mskQuantAdd.Name = "mskQuantAdd";
            mskQuantAdd.Size = new Size(100, 23);
            mskQuantAdd.TabIndex = 8;
            // 
            // FrmAtidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(448, 450);
            Controls.Add(gbUpt);
            Controls.Add(gbAdd);
            Controls.Add(dgvEstoque);
            Name = "FrmAtidade";
            Text = "FrmAtidade";
            Load += FrmAtidade_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            gbAdd.ResumeLayout(false);
            gbAdd.PerformLayout();
            gbUpt.ResumeLayout(false);
            gbUpt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtEstoqueId;
        private Label label1;
        private DataGridView dgvEstoque;
        private Label label2;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnProdID;
        private DataGridViewTextBoxColumn clnDataMov;
        private TextBox txtProdID;
        private Label label3;
        private Button btnAdicionar;
        private Button btnAtualizar;
        private GroupBox gbAdd;
        private GroupBox gbUpt;
        private Label label4;
        private MaskedTextBox mskQuantAdd;
        private MaskedTextBox mskQuantUpt;
    }
}