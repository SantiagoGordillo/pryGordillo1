namespace pryGordillo1
{
    partial class frmConsulta
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
            this.grlConsulta = new System.Windows.Forms.DataGridView();
            this.dgvLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvToneladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grlConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // grlConsulta
            // 
            this.grlConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLocalidad,
            this.dgvCultivo,
            this.dgvToneladas});
            this.grlConsulta.Location = new System.Drawing.Point(4, 18);
            this.grlConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grlConsulta.Name = "grlConsulta";
            this.grlConsulta.RowHeadersWidth = 62;
            this.grlConsulta.Size = new System.Drawing.Size(650, 318);
            this.grlConsulta.TabIndex = 0;
            this.grlConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvLocalidad
            // 
            this.dgvLocalidad.HeaderText = "Localidad";
            this.dgvLocalidad.MinimumWidth = 8;
            this.dgvLocalidad.Name = "dgvLocalidad";
            this.dgvLocalidad.ReadOnly = true;
            this.dgvLocalidad.Width = 150;
            // 
            // dgvCultivo
            // 
            this.dgvCultivo.HeaderText = "Cultivo";
            this.dgvCultivo.MinimumWidth = 8;
            this.dgvCultivo.Name = "dgvCultivo";
            this.dgvCultivo.ReadOnly = true;
            this.dgvCultivo.Width = 150;
            // 
            // dgvToneladas
            // 
            this.dgvToneladas.HeaderText = "Tonelada";
            this.dgvToneladas.MinimumWidth = 8;
            this.dgvToneladas.Name = "dgvToneladas";
            this.dgvToneladas.ReadOnly = true;
            this.dgvToneladas.Width = 150;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(492, 346);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(162, 45);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(666, 426);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.grlConsulta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.grlConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grlConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCultivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvToneladas;
        private System.Windows.Forms.Button cmdConsultar;
    }
}