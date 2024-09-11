namespace SysPecNSDesk
{
    partial class FrmPedidosNovo
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
            grbIdentificacao = new GroupBox();
            btnInserirPedido = new Button();
            label3 = new Label();
            label1 = new Label();
            txtIdCliente = new TextBox();
            txtCliente = new TextBox();
            txtUsuario = new TextBox();
            btnFechar = new Button();
            grbItens = new GroupBox();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label9 = new Label();
            label14 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnAddItem = new Button();
            txtValorUnit = new TextBox();
            txtQuantidade = new TextBox();
            txtDescricao = new TextBox();
            txtCodbar = new TextBox();
            txtDescontoItem = new TextBox();
            label2 = new Label();
            txtIdPedido = new TextBox();
            label4 = new Label();
            txtSubtotal = new TextBox();
            label10 = new Label();
            txtDescontoItens = new TextBox();
            label11 = new Label();
            txtDescontoPedido = new TextBox();
            label12 = new Label();
            txtTotal = new TextBox();
            label13 = new Label();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(btnInserirPedido);
            grbIdentificacao.Controls.Add(label3);
            grbIdentificacao.Controls.Add(label1);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(txtCliente);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Location = new Point(28, 32);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(551, 141);
            grbIdentificacao.TabIndex = 0;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            // 
            // btnInserirPedido
            // 
            btnInserirPedido.Location = new Point(433, 58);
            btnInserirPedido.Name = "btnInserirPedido";
            btnInserirPedido.Size = new Size(75, 32);
            btnInserirPedido.TabIndex = 3;
            btnInserirPedido.Text = "Abrir";
            btnInserirPedido.TextImageRelation = TextImageRelation.TextAboveImage;
            btnInserirPedido.UseVisualStyleBackColor = true;
            btnInserirPedido.Click += btnInserirPedido_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 87);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 43);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(88, 84);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(67, 23);
            txtIdCliente.TabIndex = 1;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(161, 84);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(254, 23);
            txtCliente.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(88, 40);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(327, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(681, 392);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 32);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // grbItens
            // 
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(label14);
            grbItens.Controls.Add(textBox6);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(txtCodbar);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Enabled = false;
            grbItens.Location = new Point(28, 179);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(607, 259);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens de Pedidos";
            grbItens.Enter += groupBox2_Enter;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDesconto, clnTotalItem });
            dgvItensPedido.Location = new Point(19, 71);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(573, 145);
            dgvItensPedido.TabIndex = 5;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Codigo";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant.";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(451, 23);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 4;
            label8.Text = "Desconto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(391, 24);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 4;
            label9.Text = "Quant.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.Location = new Point(418, 223);
            label14.Name = "label14";
            label14.Size = new Size(58, 19);
            label14.TabIndex = 5;
            label14.Text = "Total R$";
            label14.Click += label14_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(482, 222);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(110, 23);
            textBox6.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(322, 23);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 4;
            label7.Text = "Valor Unit.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 24);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 4;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 24);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 4;
            label5.Text = "Codigo de Barras";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(517, 42);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "&Adicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(322, 42);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(63, 23);
            txtValorUnit.TabIndex = 1;
            txtValorUnit.TextChanged += textBox5_TextChanged;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(391, 42);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(54, 23);
            txtQuantidade.TabIndex = 1;
            txtQuantidade.TextChanged += textBox5_TextChanged;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(139, 42);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(177, 23);
            txtDescricao.TabIndex = 0;
            txtDescricao.TextChanged += textBox6_TextChanged;
            // 
            // txtCodbar
            // 
            txtCodbar.Location = new Point(19, 42);
            txtCodbar.Name = "txtCodbar";
            txtCodbar.Size = new Size(114, 23);
            txtCodbar.TabIndex = 0;
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(451, 42);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(60, 23);
            txtDescontoItem.TabIndex = 0;
            txtDescontoItem.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(316, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Pedido Novo";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(634, 9);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(129, 23);
            txtIdPedido.TabIndex = 1;
            txtIdPedido.TextChanged += textBox5_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(577, 13);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 2;
            label4.Text = "Número";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(663, 216);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(110, 23);
            txtSubtotal.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(663, 198);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 5;
            label10.Text = "Sub Total";
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(663, 260);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.Size = new Size(110, 23);
            txtDescontoItens.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(663, 242);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 5;
            label11.Text = "Desconto Itens";
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(663, 304);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(110, 23);
            txtDescontoPedido.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(663, 286);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 5;
            label12.Text = "Desconto R$";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(663, 348);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(110, 23);
            txtTotal.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(663, 330);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 5;
            label13.Text = "Total";
            // 
            // FrmPedidosNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtTotal);
            Controls.Add(txtDescontoPedido);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtSubtotal);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificacao);
            Name = "FrmPedidosNovo";
            Text = "FrmPedidosNovo";
            Load += FrmPedidosNovo_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
        private GroupBox grbItens;
        private TextBox txtIdCliente;
        private TextBox txtCliente;
        private TextBox txtUsuario;
        private TextBox txtQuantidade;
        private TextBox txtDescontoItem;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btnFechar;
        private TextBox txtValorUnit;
        private TextBox txtCodbar;
        private TextBox txtIdPedido;
        private Label label4;
        private Label label5;
        private Button btnAddItem;
        private TextBox txtDescricao;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label6;
        private DataGridView dgvItensPedido;
        private TextBox txtSubtotal;
        private Label label10;
        private TextBox txtDescontoItens;
        private Label label11;
        private TextBox txtDescontoPedido;
        private Label label14;
        private Label label12;
        private TextBox txtTotal;
        private Label label13;
        private TextBox textBox6;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnTotalItem;
        private Button btnInserirPedido;
    }
}