namespace pryGordillo1
{
    partial class frmAgricultura
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
            this.msOpciones = new System.Windows.Forms.MenuStrip();
            this.tsmMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocalidad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCultivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // msOpciones
            // 
            this.msOpciones.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msOpciones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMantenimiento,
            this.tsmConsultas});
            this.msOpciones.Location = new System.Drawing.Point(0, 0);
            this.msOpciones.Name = "msOpciones";
            this.msOpciones.Size = new System.Drawing.Size(368, 36);
            this.msOpciones.TabIndex = 0;
            this.msOpciones.Text = "msMenu";
            // 
            // tsmMantenimiento
            // 
            this.tsmMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLocalidad,
            this.tsmiCultivo,
            this.tsmiProduccion,
            this.tsmiSalir});
            this.tsmMantenimiento.Name = "tsmMantenimiento";
            this.tsmMantenimiento.Size = new System.Drawing.Size(148, 32);
            this.tsmMantenimiento.Text = "Mantenimiento";
            // 
            // tsmiLocalidad
            // 
            this.tsmiLocalidad.Name = "tsmiLocalidad";
            this.tsmiLocalidad.Size = new System.Drawing.Size(203, 34);
            this.tsmiLocalidad.Text = "Localidad";
            this.tsmiLocalidad.Click += new System.EventHandler(this.localidadToolStripMenuItem_Click);
            // 
            // tsmiCultivo
            // 
            this.tsmiCultivo.Name = "tsmiCultivo";
            this.tsmiCultivo.Size = new System.Drawing.Size(203, 34);
            this.tsmiCultivo.Text = "Cultivos";
            this.tsmiCultivo.Click += new System.EventHandler(this.cultivosToolStripMenuItem_Click);
            // 
            // tsmiProduccion
            // 
            this.tsmiProduccion.Name = "tsmiProduccion";
            this.tsmiProduccion.Size = new System.Drawing.Size(203, 34);
            this.tsmiProduccion.Text = "Produccion";
            this.tsmiProduccion.Click += new System.EventHandler(this.producionToolStripMenuItem_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(203, 34);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tsmConsultas
            // 
            this.tsmConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConsulta});
            this.tsmConsultas.Name = "tsmConsultas";
            this.tsmConsultas.Size = new System.Drawing.Size(105, 32);
            this.tsmConsultas.Text = "Consultas";
            // 
            // tsmiConsulta
            // 
            this.tsmiConsulta.Name = "tsmiConsulta";
            this.tsmiConsulta.Size = new System.Drawing.Size(188, 34);
            this.tsmiConsulta.Text = "Consulta ";
            this.tsmiConsulta.Click += new System.EventHandler(this.consultaLocalidadesToolStripMenuItem_Click);
            // 
            // frmAgricultura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(368, 212);
            this.Controls.Add(this.msOpciones);
            this.MainMenuStrip = this.msOpciones;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAgricultura";
            this.msOpciones.ResumeLayout(false);
            this.msOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsmMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalidad;
        private System.Windows.Forms.ToolStripMenuItem tsmiCultivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiProduccion;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultas;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsulta;
    }
}

