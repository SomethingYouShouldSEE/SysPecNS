namespace SysPecNSDesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfima = new Button();
            txtNumero1 = new TextBox();
            lstResultado = new ListBox();
            cmbOperacao = new ComboBox();
            txtNumero2 = new TextBox();
            label = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnConfima
            // 
            btnConfima.Enabled = false;
            btnConfima.Location = new Point(400, 65);
            btnConfima.Name = "btnConfima";
            btnConfima.Size = new Size(75, 24);
            btnConfima.TabIndex = 0;
            btnConfima.Text = "&Confirma";
            btnConfima.UseVisualStyleBackColor = true;
            btnConfima.Click += btnConfima_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(188, 65);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 1;
            txtNumero1.TextChanged += textBox1_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(61, 94);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(181, 94);
            lstResultado.TabIndex = 2;
            lstResultado.SelectedIndexChanged += list_SelectedIndexChanged;
            // 
            // cmbOperacao
            // 
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiblicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Radiciação", "Logaritmos" });
            cmbOperacao.Location = new Point(61, 65);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(121, 23);
            cmbOperacao.TabIndex = 3;
            cmbOperacao.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(294, 65);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 4;
            txtNumero2.TextChanged += txtNumero2_TextChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(90, 47);
            label.Name = "label";
            label.Size = new Size(58, 15);
            label.TabIndex = 5;
            label.Text = "Operação";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 44);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 44);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Valor 2";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(txtNumero2);
            Controls.Add(cmbOperacao);
            Controls.Add(lstResultado);
            Controls.Add(txtNumero1);
            Controls.Add(btnConfima);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfima;
        private TextBox txtNumero1;
        private ListBox lstResultado;
        private ComboBox cmbOperacao;
        private TextBox txtNumero2;
        private Label label;
        private Label label1;
        private Label label2;
    }
}
