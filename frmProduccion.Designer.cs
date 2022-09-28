namespace pryGordillo1
{
    partial class frmProduccion
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
            this.lblCultivos = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblIngresoToneladas = new System.Windows.Forms.Label();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.lstCultivo = new System.Windows.Forms.ComboBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.txtToneladas = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCultivos
            // 
            this.lblCultivos.AutoSize = true;
            this.lblCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivos.Location = new System.Drawing.Point(27, 114);
            this.lblCultivos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCultivos.Name = "lblCultivos";
            this.lblCultivos.Size = new System.Drawing.Size(82, 25);
            this.lblCultivos.TabIndex = 9;
            this.lblCultivos.Text = "Cultivos";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(27, 58);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(96, 25);
            this.lblLocalidad.TabIndex = 8;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblIngresoToneladas
            // 
            this.lblIngresoToneladas.AutoSize = true;
            this.lblIngresoToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoToneladas.Location = new System.Drawing.Point(80, 9);
            this.lblIngresoToneladas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngresoToneladas.Name = "lblIngresoToneladas";
            this.lblIngresoToneladas.Size = new System.Drawing.Size(202, 25);
            this.lblIngresoToneladas.TabIndex = 5;
            this.lblIngresoToneladas.Text = "Ingreso de Toneladas";
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToneladas.Location = new System.Drawing.Point(27, 172);
            this.lblToneladas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(105, 25);
            this.lblToneladas.TabIndex = 10;
            this.lblToneladas.Text = "Toneladas";
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(156, 58);
            this.lstLocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(212, 28);
            this.lstLocalidad.TabIndex = 11;
            // 
            // lstCultivo
            // 
            this.lstCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(156, 115);
            this.lstCultivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(212, 28);
            this.lstCultivo.TabIndex = 12;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(285, 211);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(90, 35);
            this.cmdCargar.TabIndex = 14;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(156, 211);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(90, 35);
            this.cmdEliminar.TabIndex = 15;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // txtToneladas
            // 
            this.txtToneladas.Location = new System.Drawing.Point(156, 173);
            this.txtToneladas.Mask = "99999999";
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(212, 26);
            this.txtToneladas.TabIndex = 16;
            this.txtToneladas.ValidatingType = typeof(int);
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(388, 255);
            this.Controls.Add(this.txtToneladas);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblCultivos);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblIngresoToneladas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProduccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCultivos;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblIngresoToneladas;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.ComboBox lstCultivo;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.MaskedTextBox txtToneladas;
    }
}