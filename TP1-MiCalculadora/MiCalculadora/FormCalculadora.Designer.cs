﻿namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(781, 23);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(169, 45);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // cmbOperador
            // 
            this.cmbOperador.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperador.Location = new System.Drawing.Point(393, 93);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(190, 75);
            this.cmbOperador.TabIndex = 1;
            this.cmbOperador.Text = "Operador";
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero1.Location = new System.Drawing.Point(34, 93);
            this.TxtNumero1.Multiline = true;
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(336, 79);
            this.TxtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(613, 89);
            this.txtNumero2.Multiline = true;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(337, 79);
            this.txtNumero2.TabIndex = 2;
            // 
            // btnOperar
            // 
            this.btnOperar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.ForeColor = System.Drawing.Color.Red;
            this.btnOperar.Location = new System.Drawing.Point(34, 209);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(336, 73);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Red;
            this.btnLimpiar.Location = new System.Drawing.Point(393, 209);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(190, 73);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(613, 209);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(337, 73);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirABinario.ForeColor = System.Drawing.Color.Red;
            this.btnConvertirABinario.Location = new System.Drawing.Point(34, 319);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(442, 87);
            this.btnConvertirABinario.TabIndex = 6;
            this.btnConvertirABinario.Text = "Convertir a binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = true;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirADecimal.ForeColor = System.Drawing.Color.Red;
            this.btnConvertirADecimal.Location = new System.Drawing.Point(508, 319);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(442, 87);
            this.btnConvertirADecimal.TabIndex = 7;
            this.btnConvertirADecimal.Text = "Convertir a decimal";
            this.btnConvertirADecimal.UseVisualStyleBackColor = true;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 447);
            this.Controls.Add(this.btnConvertirADecimal);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.TxtNumero1);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.lblResultado);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Cintia Zanoni del curso 2°C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirADecimal;
    }
}

