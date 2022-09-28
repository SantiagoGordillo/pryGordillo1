namespace pryGordillo1
{
    partial class frmCultivos
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
            this.txtCultivos = new System.Windows.Forms.TextBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCultivos
            // 
            this.lblCultivos.AutoSize = true;
            this.lblCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivos.Location = new System.Drawing.Point(18, 18);
            this.lblCultivos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCultivos.Name = "lblCultivos";
            this.lblCultivos.Size = new System.Drawing.Size(82, 25);
            this.lblCultivos.TabIndex = 8;
            this.lblCultivos.Text = "Cultivos";
            // 
            // txtCultivos
            // 
            this.txtCultivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCultivos.Location = new System.Drawing.Point(112, 17);
            this.txtCultivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(214, 26);
            this.txtCultivos.TabIndex = 6;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(230, 57);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(99, 35);
            this.cmdCargar.TabIndex = 9;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(112, 57);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(99, 35);
            this.cmdEliminar.TabIndex = 10;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 111);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.lblCultivos);
            this.Controls.Add(this.txtCultivos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCultivos";
            this.Text = "Cultivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCultivos;
        private System.Windows.Forms.TextBox txtCultivos;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Button cmdEliminar;
    }
}