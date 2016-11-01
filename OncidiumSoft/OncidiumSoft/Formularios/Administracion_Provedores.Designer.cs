namespace OncidiumSoft.Formularios
{
    partial class Administracion_Provedores
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
            this.dGVProductos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVProductos
            // 
            this.dGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProductos.Location = new System.Drawing.Point(12, 97);
            this.dGVProductos.Name = "dGVProductos";
            this.dGVProductos.Size = new System.Drawing.Size(650, 288);
            this.dGVProductos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(360, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(297, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Administración de Provedores.";
            // 
            // Administracion_Provedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 462);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dGVProductos);
            this.Name = "Administracion_Provedores";
            this.Text = "Administracion_Provedores";
            ((System.ComponentModel.ISupportInitialize)(this.dGVProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVProductos;
        private System.Windows.Forms.Label lblTitulo;
    }
}