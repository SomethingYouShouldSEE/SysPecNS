namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            groupBox1 = new GroupBox();
            btnInseriPedido = new Button();
            label4 = new Label();
            txtIdCliente = new TextBox();
            textBox3 = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtIdPedido = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInseriPedido);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(64, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identificação";
            // 
            // btnInseriPedido
            // 
            btnInseriPedido.Location = new Point(377, 72);
            btnInseriPedido.Name = "btnInseriPedido";
            btnInseriPedido.Size = new Size(75, 23);
            btnInseriPedido.TabIndex = 3;
            btnInseriPedido.Text = "Abrir";
            btnInseriPedido.UseVisualStyleBackColor = true;
            btnInseriPedido.Click += btnInseriPedido_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 72);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 2;
            label4.Text = "Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(77, 69);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(48, 23);
            txtIdCliente.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 23);
            textBox3.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(80, 28);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(291, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 31);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(64, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 160);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Items do Pedido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(276, 14);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 10F);
            txtIdPedido.Location = new Point(601, 8);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(162, 25);
            txtIdPedido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(491, 9);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 4;
            label2.Text = "Numero Pedido";
            // 
            // FrmPrincipalNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtIdPedido);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPrincipalNovo";
            Text = "FrmPrincipalNovo";
            Load += FrmPrincipalNovo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label1;
        private TextBox txtIdPedido;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox textBox3;
        private Label label4;
        private Button btnInseriPedido;
        private TextBox txtIdCliente;
    }
}