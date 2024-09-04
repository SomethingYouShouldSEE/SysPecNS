namespace SysPecNSDesk
{
    partial class FrmProduto
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
            txtId = new TextBox();
            lbId = new Label();
            txtCodigoBarras = new TextBox();
            txtValorUnit = new TextBox();
            txtUnidadeVenda = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDescricao = new TextBox();
            cmbCategoria = new ComboBox();
            txtDesconto = new TextBox();
            label5 = new Label();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            dgProdutos = new DataGridView();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnCodigoBarras = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnCategor = new DataGridViewTextBoxColumn();
            clnEstoqueMinimo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDataCadastro = new DataGridViewTextBoxColumn();
            label6 = new Label();
            lbCategoria = new Label();
            label7 = new Label();
            dmEstoqueMinimo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dmEstoqueMinimo).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(147, 95);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(64, 23);
            txtId.TabIndex = 0;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(147, 77);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 1;
            lbId.Text = "ID";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(147, 148);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(130, 23);
            txtCodigoBarras.TabIndex = 2;
            txtCodigoBarras.TextChanged += txtCodigoBarras_TextChanged;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(294, 148);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(100, 23);
            txtValorUnit.TabIndex = 3;
            txtValorUnit.TextChanged += txtValorUnitario_TextChanged;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(409, 148);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(100, 23);
            txtUnidadeVenda.TabIndex = 4;
            txtUnidadeVenda.TextChanged += txtUnidadeVenda_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 130);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 5;
            label1.Text = "Codigo De Barras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 130);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 6;
            label2.Text = "Valor Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 130);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 7;
            label3.Text = "Unidade Venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(538, 131);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 9;
            label4.Text = "Estoque Minimo";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(147, 191);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(130, 23);
            txtDescricao.TabIndex = 10;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(294, 192);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(313, 23);
            cmbCategoria.TabIndex = 11;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(147, 243);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(98, 23);
            txtDesconto.TabIndex = 12;
            txtDesconto.TextChanged += txtDesconto_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 225);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Desconto";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(274, 242);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(387, 242);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(489, 242);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsertar_Click;
            // 
            // dgProdutos
            // 
            dgProdutos.AllowUserToAddRows = false;
            dgProdutos.AllowUserToDeleteRows = false;
            dgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProdutos.Columns.AddRange(new DataGridViewColumn[] { clnCategoria, clnCodigoBarras, clnDescricao, clnValorUnit, clnUnidadeVenda, clnCategor, clnEstoqueMinimo, clnDesconto, clnDataCadastro });
            dgProdutos.Location = new Point(133, 272);
            dgProdutos.Name = "dgProdutos";
            dgProdutos.ReadOnly = true;
            dgProdutos.RowHeadersVisible = false;
            dgProdutos.Size = new Size(504, 166);
            dgProdutos.TabIndex = 17;
            dgProdutos.CellContentClick += dgProdutos_ContentClick;
            // 
            // clnCategoria
            // 
            clnCategoria.FillWeight = 50F;
            clnCategoria.HeaderText = "ID";
            clnCategoria.MinimumWidth = 8;
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            clnCategoria.Width = 30;
            // 
            // clnCodigoBarras
            // 
            clnCodigoBarras.HeaderText = "Codigo De Barras";
            clnCodigoBarras.Name = "clnCodigoBarras";
            clnCodigoBarras.ReadOnly = true;
            clnCodigoBarras.Width = 140;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descricão";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            // 
            // clnValorUnit
            // 
            clnValorUnit.HeaderText = "Valor Unitario";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Resizable = DataGridViewTriState.True;
            clnValorUnit.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.HeaderText = "Unidade Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Resizable = DataGridViewTriState.True;
            clnUnidadeVenda.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // clnCategor
            // 
            clnCategor.HeaderText = "Categoria";
            clnCategor.Name = "clnCategor";
            clnCategor.ReadOnly = true;
            clnCategor.Resizable = DataGridViewTriState.True;
            clnCategor.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // clnEstoqueMinimo
            // 
            clnEstoqueMinimo.HeaderText = "Estoque_Minimo";
            clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            clnEstoqueMinimo.ReadOnly = true;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnDataCadastro
            // 
            clnDataCadastro.HeaderText = "Data Cadastro";
            clnDataCadastro.Name = "clnDataCadastro";
            clnDataCadastro.ReadOnly = true;
            clnDataCadastro.Width = 130;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kristen ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(334, 32);
            label6.Name = "label6";
            label6.Size = new Size(114, 33);
            label6.TabIndex = 18;
            label6.Text = "Produto";
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(294, 174);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(58, 15);
            lbCategoria.TabIndex = 19;
            lbCategoria.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(147, 173);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 20;
            label7.Text = "Descrição";
            // 
            // dmEstoqueMinimo
            // 
            dmEstoqueMinimo.Location = new Point(564, 149);
            dmEstoqueMinimo.Name = "dmEstoqueMinimo";
            dmEstoqueMinimo.Size = new Size(43, 23);
            dmEstoqueMinimo.TabIndex = 21;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dmEstoqueMinimo);
            Controls.Add(label7);
            Controls.Add(lbCategoria);
            Controls.Add(label6);
            Controls.Add(dgProdutos);
            Controls.Add(btnConsultar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(label5);
            Controls.Add(txtDesconto);
            Controls.Add(cmbCategoria);
            Controls.Add(txtDescricao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUnidadeVenda);
            Controls.Add(txtValorUnit);
            Controls.Add(txtCodigoBarras);
            Controls.Add(lbId);
            Controls.Add(txtId);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dmEstoqueMinimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lbId;
        private TextBox txtCodigoBarras;
        private TextBox txtValorUnit;
        private TextBox txtUnidadeVenda;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDescricao;
        private ComboBox cmbCategoria;
        private TextBox txtDesconto;
        private Label label5;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnConsultar;
        private DataGridView dgProdutos;
        private Label label6;
        private Label lbCategoria;
        private Label label7;
        private NumericUpDown dmEstoqueMinimo;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnCodigoBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCategor;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDataCadastro;
    }
}