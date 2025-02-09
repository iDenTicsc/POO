using GestionDeEmpleados.Clases;
using GestionDeEmpleados.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeEmpleados.Vistas
{
    public partial class vistaEmpleadoTiempoCompleto : Form
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string TipoEmpleado {  get; set; }
        public double SalarioBase { get; set; }

        private vistaEmpleado vEmpleado;

        ControllerEmpleado _controllerEmpleado = new ControllerEmpleado();
        public vistaEmpleadoTiempoCompleto(vistaEmpleado vEmpleado)
        {
            InitializeComponent();
            this.vEmpleado = vEmpleado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double bono = double.Parse(tbBono.Text);
            _controllerEmpleado.AgregarEmpleado(new EmpleadoTiempoCompleto(id, Nombre, TipoEmpleado, SalarioBase, bono));
            tbBono.Clear();
            vEmpleado.ActualizarLista();
            DialogResult result = MessageBox.Show("Empleado agregado exitosamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            vEmpleado.LimpiarFormulario();
            this.Close();

        }
    }
}
