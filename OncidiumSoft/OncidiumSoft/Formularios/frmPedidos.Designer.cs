namespace OncidiumSoft.Formularios
{
    partial class frmPedidos
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
            this.lblrealizacion = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblentrega = new System.Windows.Forms.Label();
            this.lblAnticipo = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNCliente = new System.Windows.Forms.TextBox();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DGVpedidos = new System.Windows.Forms.DataGridView();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVpedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblrealizacion
            // 
            this.lblrealizacion.AutoSize = true;
            this.lblrealizacion.Location = new System.Drawing.Point(42, 35);
            this.lblrealizacion.Name = "lblrealizacion";
            this.lblrealizacion.Size = new System.Drawing.Size(180, 13);
            this.lblrealizacion.TabIndex = 0;
            this.lblrealizacion.Text = "Fecha en la que se realizo el pedido:";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(42, 77);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(98, 13);
            this.lblcliente.TabIndex = 1;
            this.lblcliente.Text = "Nombre del cliente:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(42, 120);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(103, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Número de telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Domicilio";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(42, 206);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbldescripcion.TabIndex = 4;
            this.lbldescripcion.Text = "Descripción:";
            // 
            // lblentrega
            // 
            this.lblentrega.AutoSize = true;
            this.lblentrega.Location = new System.Drawing.Point(471, 35);
            this.lblentrega.Name = "lblentrega";
            this.lblentrega.Size = new System.Drawing.Size(91, 13);
            this.lblentrega.TabIndex = 5;
            this.lblentrega.Text = "Fecha de entrega";
            this.lblentrega.Click += new System.EventHandler(this.lblentrega_Click);
            // 
            // lblAnticipo
            // 
            this.lblAnticipo.AutoSize = true;
            this.lblAnticipo.Location = new System.Drawing.Point(480, 80);
            this.lblAnticipo.Name = "lblAnticipo";
            this.lblAnticipo.Size = new System.Drawing.Size(66, 13);
            this.lblAnticipo.TabIndex = 6;
            this.lblAnticipo.Text = "Anticipo :   $";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(480, 120);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(71, 13);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "SubTotal :   $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "TOTAL:   $";
            // 
            // txtNCliente
            // 
            this.txtNCliente.Location = new System.Drawing.Point(228, 74);
            this.txtNCliente.Name = "txtNCliente";
            this.txtNCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNCliente.TabIndex = 10;
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(568, 77);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(100, 20);
            this.txtAnticipo.TabIndex = 12;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(568, 120);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(568, 165);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(228, 117);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 15;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(228, 165);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(236, 20);
            this.txtDomicilio.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(125, 199);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(677, 35);
            this.txtDescripcion.TabIndex = 17;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(228, 29);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 20);
            this.txtFecha.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(581, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // DGVpedidos
            // 
            this.DGVpedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVpedidos.Location = new System.Drawing.Point(34, 256);
            this.DGVpedidos.Name = "DGVpedidos";
            this.DGVpedidos.Size = new System.Drawing.Size(819, 169);
            this.DGVpedidos.TabIndex = 20;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(278, 442);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(102, 36);
            this.btnAgregarP.TabIndex = 21;
            this.btnAgregarP.Text = "Agregar Pedido";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Location = new System.Drawing.Point(508, 442);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(102, 36);
            this.btnEliminarP.TabIndex = 22;
            this.btnEliminarP.Text = "Eliminar Pedido";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 520);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnAgregarP);
            this.Controls.Add(this.DGVpedidos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtAnticipo);
            this.Controls.Add(this.txtNCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblAnticipo);
            this.Controls.Add(this.lblentrega);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.lblrealizacion);
            this.Name = "frmPedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.DGVpedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrealizacion;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblentrega;
        private System.Windows.Forms.Label lblAnticipo;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNCliente;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView DGVpedidos;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnEliminarP;
    }
}