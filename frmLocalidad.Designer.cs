namespace pryGordillo1
{
    partial class frmLocalidad
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
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lstLocalidades = new System.Windows.Forms.ComboBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(31, 16);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(96, 25);
            this.lblLocalidad.TabIndex = 3;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(264, 60);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(108, 35);
            this.cmdCargar.TabIndex = 5;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lstLocalidades
            // 
            this.lstLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidades.FormattingEnabled = true;
            this.lstLocalidades.Items.AddRange(new object[] {
            "Buenos Aires",
            "Ciudad Autónoma de Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego, Antártida e Islas del Atlántico Sur",
            "Tucumán"});
            this.lstLocalidades.Location = new System.Drawing.Point(152, 17);
            this.lstLocalidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLocalidades.Name = "lstLocalidades";
            this.lstLocalidades.Size = new System.Drawing.Size(220, 28);
            this.lstLocalidades.TabIndex = 6;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(152, 60);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(108, 35);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(397, 114);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.lstLocalidades);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.lblLocalidad);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLocalidad";
            this.Text = "Localidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.ComboBox lstLocalidades;
        private System.Windows.Forms.Button cmdEliminar;
    }
}