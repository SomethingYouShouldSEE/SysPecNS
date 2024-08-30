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
            groupBox1 = new GroupBox();
            teb = new TabControl();
            tabPageCliente = new TabPage();
            tabPageEnderecos = new TabPage();
            groupBox1.SuspendLayout();
            teb.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(teb);
            groupBox1.Location = new Point(122, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // teb
            // 
            teb.Controls.Add(tabPageCliente);
            teb.Controls.Add(tabPageEnderecos);
            teb.Location = new Point(6, 22);
            teb.Name = "teb";
            teb.SelectedIndex = 0;
            teb.Size = new Size(369, 134);
            teb.TabIndex = 0;
            // 
            // tabPageCliente
            // 
            tabPageCliente.Location = new Point(4, 24);
            tabPageCliente.Name = "tabPageCliente";
            tabPageCliente.Padding = new Padding(3);
            tabPageCliente.Size = new Size(361, 106);
            tabPageCliente.TabIndex = 0;
            tabPageCliente.Text = "Dados Clientes";
            tabPageCliente.UseVisualStyleBackColor = true;
            // 
            // tabPageEnderecos
            // 
            tabPageEnderecos.Location = new Point(4, 24);
            tabPageEnderecos.Name = "tabPageEnderecos";
            tabPageEnderecos.Padding = new Padding(3);
            tabPageEnderecos.Size = new Size(192, 72);
            tabPageEnderecos.TabIndex = 1;
            tabPageEnderecos.Text = "Enderecos";
            tabPageEnderecos.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            groupBox1.ResumeLayout(false);
            teb.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl teb;
        private TabPage tabPageCliente;
        private TabPage tabPageEnderecos;
    }
}