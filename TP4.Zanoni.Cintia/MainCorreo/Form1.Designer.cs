namespace MainCorreo
{
    partial class FormCorreo
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
            this.components = new System.ComponentModel.Container();
            this.lblIngresado = new System.Windows.Forms.Label();
            this.LblEnViaje = new System.Windows.Forms.Label();
            this.lblEntregado = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.LblTrackingID = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBoxEstado = new System.Windows.Forms.GroupBox();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.groupBoxPaquete = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxEstado.SuspendLayout();
            this.groupBoxPaquete.SuspendLayout();
            this.cmsListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngresado
            // 
            this.lblIngresado.AutoSize = true;
            this.lblIngresado.Location = new System.Drawing.Point(7, 40);
            this.lblIngresado.Name = "lblIngresado";
            this.lblIngresado.Size = new System.Drawing.Size(107, 25);
            this.lblIngresado.TabIndex = 1;
            this.lblIngresado.Text = "Ingresado";
            // 
            // LblEnViaje
            // 
            this.LblEnViaje.AutoSize = true;
            this.LblEnViaje.Location = new System.Drawing.Point(402, 40);
            this.LblEnViaje.Name = "LblEnViaje";
            this.LblEnViaje.Size = new System.Drawing.Size(92, 25);
            this.LblEnViaje.TabIndex = 2;
            this.LblEnViaje.Text = "En Viaje";
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.Location = new System.Drawing.Point(804, 40);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(111, 25);
            this.lblEntregado.TabIndex = 3;
            this.lblEntregado.Text = "Entregado";
            this.lblEntregado.Click += new System.EventHandler(this.lblEntregado_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 119);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(102, 25);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(333, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(183, 63);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // LblTrackingID
            // 
            this.LblTrackingID.AutoSize = true;
            this.LblTrackingID.Location = new System.Drawing.Point(6, 38);
            this.LblTrackingID.Name = "LblTrackingID";
            this.LblTrackingID.Size = new System.Drawing.Size(121, 25);
            this.LblTrackingID.TabIndex = 7;
            this.LblTrackingID.Text = "Tracking ID";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(333, 119);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(183, 70);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // groupBoxEstado
            // 
            this.groupBoxEstado.Controls.Add(this.lstEstadoEntregado);
            this.groupBoxEstado.Controls.Add(this.lstEstadoEnViaje);
            this.groupBoxEstado.Controls.Add(this.lstEstadoIngresado);
            this.groupBoxEstado.Controls.Add(this.lblIngresado);
            this.groupBoxEstado.Controls.Add(this.LblEnViaje);
            this.groupBoxEstado.Controls.Add(this.lblEntregado);
            this.groupBoxEstado.Location = new System.Drawing.Point(5, 12);
            this.groupBoxEstado.Name = "groupBoxEstado";
            this.groupBoxEstado.Size = new System.Drawing.Size(1197, 323);
            this.groupBoxEstado.TabIndex = 9;
            this.groupBoxEstado.TabStop = false;
            this.groupBoxEstado.Text = "Estado Paquetes";
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.ContextMenuStrip = this.cmsListas;
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.ItemHeight = 25;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(809, 83);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(364, 229);
            this.lstEstadoEntregado.TabIndex = 6;
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.ItemHeight = 25;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(407, 83);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(362, 229);
            this.lstEstadoEnViaje.TabIndex = 5;
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.ItemHeight = 25;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(12, 83);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(360, 229);
            this.lstEstadoIngresado.TabIndex = 4;
            // 
            // groupBoxPaquete
            // 
            this.groupBoxPaquete.Controls.Add(this.maskedTextBox1);
            this.groupBoxPaquete.Controls.Add(this.txtDireccion);
            this.groupBoxPaquete.Controls.Add(this.LblTrackingID);
            this.groupBoxPaquete.Controls.Add(this.lblDireccion);
            this.groupBoxPaquete.Controls.Add(this.btnMostrar);
            this.groupBoxPaquete.Controls.Add(this.btnAgregar);
            this.groupBoxPaquete.Location = new System.Drawing.Point(627, 355);
            this.groupBoxPaquete.Name = "groupBoxPaquete";
            this.groupBoxPaquete.Size = new System.Drawing.Size(575, 206);
            this.groupBoxPaquete.TabIndex = 10;
            this.groupBoxPaquete.TabStop = false;
            this.groupBoxPaquete.Text = "Paquetes";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(11, 66);
            this.maskedTextBox1.Mask = "000-###-####";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(258, 31);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(11, 147);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(258, 42);
            this.txtDireccion.TabIndex = 9;
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(17, 355);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(585, 206);
            this.rtbMostrar.TabIndex = 11;
            this.rtbMostrar.Text = "";
            // 
            // cmsListas
            // 
            this.cmsListas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.cmsListas.Name = "contextMenuStrip1";
            this.cmsListas.Size = new System.Drawing.Size(173, 42);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(172, 38);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // FormCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 573);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.groupBoxPaquete);
            this.Controls.Add(this.groupBoxEstado);
            this.Name = "FormCorreo";
            this.Text = "Correo UTN por Cintia.Zanoni.2°C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCorreo_FormClosing);
            this.groupBoxEstado.ResumeLayout(false);
            this.groupBoxEstado.PerformLayout();
            this.groupBoxPaquete.ResumeLayout(false);
            this.groupBoxPaquete.PerformLayout();
            this.cmsListas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIngresado;
        private System.Windows.Forms.Label LblEnViaje;
        private System.Windows.Forms.Label lblEntregado;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label LblTrackingID;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox groupBoxEstado;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.GroupBox groupBoxPaquete;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}

