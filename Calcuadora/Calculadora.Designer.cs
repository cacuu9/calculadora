namespace Calcuadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.cboResultados = new System.Windows.Forms.ComboBox();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.chkResultados = new System.Windows.Forms.CheckBox();
            this.chkFondoAmarillo = new System.Windows.Forms.CheckBox();
            this.gbCientificas = new System.Windows.Forms.GroupBox();
            this.btnLogaritmo = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbCientifica = new System.Windows.Forms.RadioButton();
            this.rbEstandar = new System.Windows.Forms.RadioButton();
            this.gbCientificas.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(51, 48);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(200, 44);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(51, 109);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(200, 44);
            this.txtNum2.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(51, 170);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(200, 44);
            this.lblResultado.TabIndex = 2;
            // 
            // btnSuma
            // 
            this.btnSuma.AutoSize = true;
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnSuma.Location = new System.Drawing.Point(274, 26);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(53, 56);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.AutoSize = true;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnDivision.Location = new System.Drawing.Point(274, 219);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(53, 56);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnResta
            // 
            this.btnResta.AutoSize = true;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnResta.Location = new System.Drawing.Point(274, 88);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(53, 56);
            this.btnResta.TabIndex = 5;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.AutoSize = true;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnMultiplicacion.Location = new System.Drawing.Point(274, 157);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(53, 56);
            this.btnMultiplicacion.TabIndex = 6;
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // cboResultados
            // 
            this.cboResultados.FormattingEnabled = true;
            this.cboResultados.Location = new System.Drawing.Point(356, 247);
            this.cboResultados.Name = "cboResultados";
            this.cboResultados.Size = new System.Drawing.Size(299, 21);
            this.cboResultados.TabIndex = 7;
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(356, 57);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(299, 160);
            this.lstResultados.TabIndex = 8;
            // 
            // chkResultados
            // 
            this.chkResultados.AutoSize = true;
            this.chkResultados.Location = new System.Drawing.Point(51, 235);
            this.chkResultados.Name = "chkResultados";
            this.chkResultados.Size = new System.Drawing.Size(112, 17);
            this.chkResultados.TabIndex = 9;
            this.chkResultados.Text = "Mostrar resultados";
            this.chkResultados.UseVisualStyleBackColor = true;
            this.chkResultados.CheckedChanged += new System.EventHandler(this.chkResultados_CheckedChanged);
            // 
            // chkFondoAmarillo
            // 
            this.chkFondoAmarillo.AutoSize = true;
            this.chkFondoAmarillo.Location = new System.Drawing.Point(51, 258);
            this.chkFondoAmarillo.Name = "chkFondoAmarillo";
            this.chkFondoAmarillo.Size = new System.Drawing.Size(94, 17);
            this.chkFondoAmarillo.TabIndex = 10;
            this.chkFondoAmarillo.Text = "Fondo amarillo";
            this.chkFondoAmarillo.UseVisualStyleBackColor = true;
            this.chkFondoAmarillo.CheckedChanged += new System.EventHandler(this.chkFondoAmarillo_CheckedChanged);
            // 
            // gbCientificas
            // 
            this.gbCientificas.Controls.Add(this.btnLogaritmo);
            this.gbCientificas.Controls.Add(this.btnPotencia);
            this.gbCientificas.Controls.Add(this.btnRaiz);
            this.gbCientificas.Location = new System.Drawing.Point(51, 419);
            this.gbCientificas.Name = "gbCientificas";
            this.gbCientificas.Size = new System.Drawing.Size(245, 213);
            this.gbCientificas.TabIndex = 12;
            this.gbCientificas.TabStop = false;
            this.gbCientificas.Text = "Cientifica";
            // 
            // btnLogaritmo
            // 
            this.btnLogaritmo.AutoSize = true;
            this.btnLogaritmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnLogaritmo.Location = new System.Drawing.Point(41, 152);
            this.btnLogaritmo.Name = "btnLogaritmo";
            this.btnLogaritmo.Size = new System.Drawing.Size(159, 50);
            this.btnLogaritmo.TabIndex = 6;
            this.btnLogaritmo.Text = "Logaritmo";
            this.btnLogaritmo.UseVisualStyleBackColor = true;
            this.btnLogaritmo.Click += new System.EventHandler(this.btnLogaritmo_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.AutoSize = true;
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnPotencia.Location = new System.Drawing.Point(55, 99);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(130, 47);
            this.btnPotencia.TabIndex = 5;
            this.btnPotencia.Text = "Potencia";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.AutoSize = true;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnRaiz.Location = new System.Drawing.Point(76, 46);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(80, 47);
            this.btnRaiz.TabIndex = 4;
            this.btnRaiz.Text = "Raiz";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbCientifica);
            this.gbTipo.Controls.Add(this.rbEstandar);
            this.gbTipo.Location = new System.Drawing.Point(51, 299);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(245, 100);
            this.gbTipo.TabIndex = 13;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // rbCientifica
            // 
            this.rbCientifica.AutoSize = true;
            this.rbCientifica.Location = new System.Drawing.Point(21, 60);
            this.rbCientifica.Name = "rbCientifica";
            this.rbCientifica.Size = new System.Drawing.Size(68, 17);
            this.rbCientifica.TabIndex = 1;
            this.rbCientifica.TabStop = true;
            this.rbCientifica.Text = "Cientifica";
            this.rbCientifica.UseVisualStyleBackColor = true;
            this.rbCientifica.CheckedChanged += new System.EventHandler(this.rbCientifica_CheckedChanged);
            // 
            // rbEstandar
            // 
            this.rbEstandar.AutoSize = true;
            this.rbEstandar.Location = new System.Drawing.Point(21, 37);
            this.rbEstandar.Name = "rbEstandar";
            this.rbEstandar.Size = new System.Drawing.Size(67, 17);
            this.rbEstandar.TabIndex = 0;
            this.rbEstandar.TabStop = true;
            this.rbEstandar.Text = "Estandar";
            this.rbEstandar.UseVisualStyleBackColor = true;
            this.rbEstandar.CheckedChanged += new System.EventHandler(this.rbEstandar_CheckedChanged);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(667, 660);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.gbCientificas);
            this.Controls.Add(this.chkFondoAmarillo);
            this.Controls.Add(this.chkResultados);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.cboResultados);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.gbCientificas.ResumeLayout(false);
            this.gbCientificas.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.ComboBox cboResultados;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.CheckBox chkResultados;
        private System.Windows.Forms.CheckBox chkFondoAmarillo;
        private System.Windows.Forms.GroupBox gbCientificas;
        private System.Windows.Forms.Button btnLogaritmo;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbCientifica;
        private System.Windows.Forms.RadioButton rbEstandar;
    }
}

