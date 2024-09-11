namespace SysPecNSDesk
{
    partial class FrmCliente
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
            txtIdCliente = new TextBox();
            dgvClientes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            txtClienteNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            chkAtivo = new CheckBox();
            mskCPF = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            mskDataNasc = new MaskedTextBox();
            label7 = new Label();
            btnInserir = new Button();
            btnUpdate = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(129, 68);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(61, 23);
            txtIdCliente.TabIndex = 0;
            txtIdCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnTelefone, clnEmail, clnAtivo });
            dgvClientes.Location = new Point(98, 288);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(612, 150);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellContentClick += dgvClientes_ContentClick;
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
            // txtClienteNome
            // 
            txtClienteNome.Location = new Point(196, 68);
            txtClienteNome.Name = "txtClienteNome";
            txtClienteNome.Size = new Size(250, 23);
            txtClienteNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(129, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(537, 68);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(140, 23);
            txtTelefone.TabIndex = 0;
            txtTelefone.TextChanged += textBox7_TextChanged;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(233, 202);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 2;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(452, 68);
            mskCPF.Mask = "000.000.000.00";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(79, 23);
            mskCPF.TabIndex = 3;
            mskCPF.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(129, 46);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(196, 48);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(452, 46);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 6;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(537, 46);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 7;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(129, 114);
            label5.Name = "label5";
            label5.Size = new Size(41, 19);
            label5.TabIndex = 8;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(129, 178);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 8;
            label6.Text = "Data Nasc";
            label6.Click += label5_Click;
            // 
            // mskDataNasc
            // 
            mskDataNasc.Location = new Point(129, 200);
            mskDataNasc.Mask = "0000-00-00";
            mskDataNasc.Name = "mskDataNasc";
            mskDataNasc.Size = new Size(98, 23);
            mskDataNasc.TabIndex = 3;
            mskDataNasc.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(370, 9);
            label7.Name = "label7";
            label7.Size = new Size(76, 22);
            label7.TabIndex = 9;
            label7.Text = "Cliente";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(267, 238);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 36);
            btnInserir.TabIndex = 10;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(370, 238);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 36);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(469, 238);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 36);
            btnRemover.TabIndex = 10;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemover);
            Controls.Add(btnUpdate);
            Controls.Add(btnInserir);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mskDataNasc);
            Controls.Add(mskCPF);
            Controls.Add(chkAtivo);
            Controls.Add(dgvClientes);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtClienteNome);
            Controls.Add(txtIdCliente);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdCliente;
        private DataGridView dgvClientes;
        private TextBox txtClienteNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private CheckBox chkAtivo;
        private MaskedTextBox mskCPF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox mskDataNasc;
        private Label label7;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnAtivo;
        private Button btnInserir;
        private Button btnUpdate;
        private Button btnRemover;
    }
}