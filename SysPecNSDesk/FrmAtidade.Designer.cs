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
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtEstoqueId
            // 
            txtEstoqueId.Location = new Point(50, 65);
            txtEstoqueId.Name = "txtEstoqueId";
            txtEstoqueId.Size = new Size(66, 23);
            txtEstoqueId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 47);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // dgvEstoque
            // 
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Location = new Point(50, 247);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.Size = new Size(592, 191);
            dgvEstoque.TabIndex = 2;
            // 
            // FrmAtidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}