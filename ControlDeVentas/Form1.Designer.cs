namespace ControlDeVentas
{
    partial class frmVentas
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
            this.lblVentas = new System.Windows.Forms.Label();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.lblTituloHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.gbDatosVenta = new System.Windows.Forms.GroupBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lblTituloCantidad = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTituloPrecio = new System.Windows.Forms.Label();
            this.cobProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.colProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescuento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTituloTotal = new System.Windows.Forms.Label();
            this.gbDatosCliente.SuspendLayout();
            this.gbDatosVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblVentas.Location = new System.Drawing.Point(240, 12);
            this.lblVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(436, 32);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "CONTROL DE VENTA DE PRODUCTOS";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.tbCliente);
            this.gbDatosCliente.Controls.Add(this.lblCliente);
            this.gbDatosCliente.Location = new System.Drawing.Point(14, 52);
            this.gbDatosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosCliente.Size = new System.Drawing.Size(459, 116);
            this.gbDatosCliente.TabIndex = 1;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "DATOS DEL CLIENTE";
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(8, 56);
            this.tbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(443, 25);
            this.tbCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 26);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 19);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CLIENTE";
            // 
            // lblTituloFecha
            // 
            this.lblTituloFecha.AutoSize = true;
            this.lblTituloFecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFecha.Location = new System.Drawing.Point(547, 65);
            this.lblTituloFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloFecha.Name = "lblTituloFecha";
            this.lblTituloFecha.Size = new System.Drawing.Size(72, 25);
            this.lblTituloFecha.TabIndex = 2;
            this.lblTituloFecha.Text = "FECHA";
            // 
            // lblTituloHora
            // 
            this.lblTituloHora.AutoSize = true;
            this.lblTituloHora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHora.Location = new System.Drawing.Point(699, 65);
            this.lblTituloHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloHora.Name = "lblTituloHora";
            this.lblTituloHora.Size = new System.Drawing.Size(66, 25);
            this.lblTituloHora.TabIndex = 3;
            this.lblTituloHora.Text = "HORA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(529, 106);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(84, 25);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "lblFecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(699, 105);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(79, 25);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "lblHora";
            // 
            // gbDatosVenta
            // 
            this.gbDatosVenta.Controls.Add(this.tbCantidad);
            this.gbDatosVenta.Controls.Add(this.lblTituloCantidad);
            this.gbDatosVenta.Controls.Add(this.btnRegistrar);
            this.gbDatosVenta.Controls.Add(this.btnCancel);
            this.gbDatosVenta.Controls.Add(this.lblPrecio);
            this.gbDatosVenta.Controls.Add(this.lblTituloPrecio);
            this.gbDatosVenta.Controls.Add(this.cobProducto);
            this.gbDatosVenta.Controls.Add(this.lblProducto);
            this.gbDatosVenta.Location = new System.Drawing.Point(14, 183);
            this.gbDatosVenta.Name = "gbDatosVenta";
            this.gbDatosVenta.Size = new System.Drawing.Size(891, 107);
            this.gbDatosVenta.TabIndex = 6;
            this.gbDatosVenta.TabStop = false;
            this.gbDatosVenta.Text = "DATOS DE LA VENTA";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(396, 64);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(143, 25);
            this.tbCantidad.TabIndex = 2;
            // 
            // lblTituloCantidad
            // 
            this.lblTituloCantidad.AutoSize = true;
            this.lblTituloCantidad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCantidad.Location = new System.Drawing.Point(414, 30);
            this.lblTituloCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCantidad.Name = "lblTituloCantidad";
            this.lblTituloCantidad.Size = new System.Drawing.Size(110, 25);
            this.lblTituloCantidad.TabIndex = 11;
            this.lblTituloCantidad.Text = "CANTIDAD";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(754, 62);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(126, 34);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(754, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(618, 54);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(90, 25);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "lblPrecio";
            // 
            // lblTituloPrecio
            // 
            this.lblTituloPrecio.AutoSize = true;
            this.lblTituloPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrecio.Location = new System.Drawing.Point(623, 30);
            this.lblTituloPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloPrecio.Name = "lblTituloPrecio";
            this.lblTituloPrecio.Size = new System.Drawing.Size(78, 25);
            this.lblTituloPrecio.TabIndex = 7;
            this.lblTituloPrecio.Text = "PRECIO";
            // 
            // cobProducto
            // 
            this.cobProducto.FormattingEnabled = true;
            this.cobProducto.Location = new System.Drawing.Point(11, 65);
            this.cobProducto.Name = "cobProducto";
            this.cobProducto.Size = new System.Drawing.Size(294, 25);
            this.cobProducto.TabIndex = 3;
            this.cobProducto.SelectedIndexChanged += new System.EventHandler(this.cobProducto_SelectedIndexChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(7, 30);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(114, 25);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "PRODUCTO";
            // 
            // lvRegistro
            // 
            this.lvRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal,
            this.colDescuento,
            this.colNeto});
            this.lvRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRegistro.GridLines = true;
            this.lvRegistro.HideSelection = false;
            this.lvRegistro.Location = new System.Drawing.Point(14, 308);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(891, 266);
            this.lvRegistro.TabIndex = 7;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            // 
            // colProducto
            // 
            this.colProducto.Text = "PRODUCTO";
            this.colProducto.Width = 150;
            // 
            // colCantidad
            // 
            this.colCantidad.Text = "CANTIDAD";
            this.colCantidad.Width = 150;
            // 
            // colPrecio
            // 
            this.colPrecio.Text = "PRECIO";
            this.colPrecio.Width = 150;
            // 
            // colSubtotal
            // 
            this.colSubtotal.Text = "SUBTOTAL";
            this.colSubtotal.Width = 150;
            // 
            // colDescuento
            // 
            this.colDescuento.Text = "DESCUENTO";
            this.colDescuento.Width = 150;
            // 
            // colNeto
            // 
            this.colNeto.Text = "NETO";
            this.colNeto.Width = 137;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(787, 586);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 21);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "lblTotal";
            // 
            // lblTituloTotal
            // 
            this.lblTituloTotal.AutoSize = true;
            this.lblTituloTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotal.Location = new System.Drawing.Point(651, 586);
            this.lblTituloTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloTotal.Name = "lblTituloTotal";
            this.lblTituloTotal.Size = new System.Drawing.Size(102, 21);
            this.lblTituloTotal.TabIndex = 8;
            this.lblTituloTotal.Text = "TOTAL NETO";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 627);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTituloTotal);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.gbDatosVenta);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTituloHora);
            this.Controls.Add(this.lblTituloFecha);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.lblVentas);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de ventas de producto";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.gbDatosVenta.ResumeLayout(false);
            this.gbDatosVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTituloFecha;
        private System.Windows.Forms.Label lblTituloHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.GroupBox gbDatosVenta;
        private System.Windows.Forms.ComboBox cobProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTituloPrecio;
        private System.Windows.Forms.ListView lvRegistro;
        private System.Windows.Forms.ColumnHeader colProducto;
        private System.Windows.Forms.ColumnHeader colCantidad;
        private System.Windows.Forms.ColumnHeader colPrecio;
        private System.Windows.Forms.ColumnHeader colSubtotal;
        private System.Windows.Forms.ColumnHeader colDescuento;
        private System.Windows.Forms.ColumnHeader colNeto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTituloTotal;
        private System.Windows.Forms.Label lblTituloCantidad;
        private System.Windows.Forms.TextBox tbCantidad;
    }
}

