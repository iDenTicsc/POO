namespace GestionDeEmpleados.Vistas
{
    partial class vistaEmpleadoTiempoCompleto
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
            this.tbBono = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbSalarioBase = new System.Windows.Forms.TextBox();
            this.lbTituloSalarioB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE EL BONO DEL EMPELADO";
            // 
            // tbBono
            // 
            this.tbBono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBono.Location = new System.Drawing.Point(41, 129);
            this.tbBono.Name = "tbBono";
            this.tbBono.Size = new System.Drawing.Size(252, 29);
            this.tbBono.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(62, 168);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 34);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(184, 168);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbSalarioBase
            // 
            this.tbSalarioBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalarioBase.Location = new System.Drawing.Point(41, 52);
            this.tbSalarioBase.Name = "tbSalarioBase";
            this.tbSalarioBase.Size = new System.Drawing.Size(252, 29);
            this.tbSalarioBase.TabIndex = 11;
            // 
            // lbTituloSalarioB
            // 
            this.lbTituloSalarioB.AutoSize = true;
            this.lbTituloSalarioB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbTituloSalarioB.Location = new System.Drawing.Point(98, 9);
            this.lbTituloSalarioB.Name = "lbTituloSalarioB";
            this.lbTituloSalarioB.Size = new System.Drawing.Size(142, 25);
            this.lbTituloSalarioB.TabIndex = 10;
            this.lbTituloSalarioB.Text = "SALARIO BASE";
            // 
            // vistaEmpleadoTiempoCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 212);
            this.Controls.Add(this.tbSalarioBase);
            this.Controls.Add(this.lbTituloSalarioB);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbBono);
            this.Controls.Add(this.label1);
            this.Name = "vistaEmpleadoTiempoCompleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado Tiempo Completo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBono;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbSalarioBase;
        private System.Windows.Forms.Label lbTituloSalarioB;
    }
}