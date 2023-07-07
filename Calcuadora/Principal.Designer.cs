namespace Calcuadora
{
    partial class Principal
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuAplicaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngreso = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAplicaciones,
            this.menuIngreso});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(662, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuAplicaciones
            // 
            this.menuAplicaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuProveedores,
            this.menuCalculadora});
            this.menuAplicaciones.Enabled = false;
            this.menuAplicaciones.Name = "menuAplicaciones";
            this.menuAplicaciones.Size = new System.Drawing.Size(86, 20);
            this.menuAplicaciones.Text = "Aplicaciones";
            this.menuAplicaciones.Click += new System.EventHandler(this.menuAplicaciones_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(180, 22);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(180, 22);
            this.menuProveedores.Text = "Proveedores";
            // 
            // menuCalculadora
            // 
            this.menuCalculadora.Name = "menuCalculadora";
            this.menuCalculadora.Size = new System.Drawing.Size(180, 22);
            this.menuCalculadora.Text = "Calculadora";
            this.menuCalculadora.Click += new System.EventHandler(this.menuCalculadora_Click);
            // 
            // menuIngreso
            // 
            this.menuIngreso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuSalir});
            this.menuIngreso.Name = "menuIngreso";
            this.menuIngreso.Size = new System.Drawing.Size(58, 20);
            this.menuIngreso.Text = "Ingreso";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(180, 22);
            this.menuLogin.Text = "Login";
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(180, 22);
            this.menuSalir.Text = "Salir";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuCalculadora;
        private System.Windows.Forms.ToolStripMenuItem menuIngreso;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        public System.Windows.Forms.ToolStripMenuItem menuAplicaciones;
        public System.Windows.Forms.ToolStripMenuItem menuLogin;
        public System.Windows.Forms.ToolStripMenuItem menuClientes;
        public System.Windows.Forms.ToolStripMenuItem menuProveedores;
    }
}