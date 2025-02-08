namespace GestionDeEmpleados
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cobTipoE = new System.Windows.Forms.ComboBox();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.lvMostrarE = new System.Windows.Forms.ListView();
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.colTipoE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSalario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DE EMPLEADOS";
            // 
            // tbNombreE
            // 
            this.tbNombreE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreE.Location = new System.Drawing.Point(43, 136);
            this.tbNombreE.Name = "tbNombreE";
            this.tbNombreE.Size = new System.Drawing.Size(185, 29);
            this.tbNombreE.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DE EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(311, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "TIPO DE EMPLEADO";
            // 
            // cobTipoE
            // 
            this.cobTipoE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobTipoE.FormattingEnabled = true;
            this.cobTipoE.Location = new System.Drawing.Point(313, 136);
            this.cobTipoE.Name = "cobTipoE";
            this.cobTipoE.Size = new System.Drawing.Size(185, 29);
            this.cobTipoE.TabIndex = 4;
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregarE.Location = new System.Drawing.Point(178, 181);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(182, 41);
            this.btnAgregarE.TabIndex = 5;
            this.btnAgregarE.Text = "Agregar empleado";
            this.btnAgregarE.UseVisualStyleBackColor = true;
            // 
            // lvMostrarE
            // 
            this.lvMostrarE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNombre,
            this.colTipoE,
            this.colSalario});
            this.lvMostrarE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMostrarE.GridLines = true;
            this.lvMostrarE.HideSelection = false;
            this.lvMostrarE.Location = new System.Drawing.Point(12, 241);
            this.lvMostrarE.Name = "lvMostrarE";
            this.lvMostrarE.Size = new System.Drawing.Size(540, 239);
            this.lvMostrarE.TabIndex = 6;
            this.lvMostrarE.UseCompatibleStateImageBehavior = false;
            this.lvMostrarE.View = System.Windows.Forms.View.Details;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 180;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalir.Location = new System.Drawing.Point(178, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(182, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // colTipoE
            // 
            this.colTipoE.Text = "Tipo Empleado";
            this.colTipoE.Width = 180;
            // 
            // colSalario
            // 
            this.colSalario.Text = "Salario";
            this.colSalario.Width = 176;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 539);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvMostrarE);
            this.Controls.Add(this.btnAgregarE);
            this.Controls.Add(this.cobTipoE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombreE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobTipoE;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.ListView lvMostrarE;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader colTipoE;
        private System.Windows.Forms.ColumnHeader colSalario;
    }
}

