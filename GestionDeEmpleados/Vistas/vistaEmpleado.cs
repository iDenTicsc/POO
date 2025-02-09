using GestionDeEmpleados.Controladores;
using GestionDeEmpleados.Vistas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeEmpleados
{
    public partial class vistaEmpleado : Form
    {
        ControllerEmpleado _controllerEmpleado = new ControllerEmpleado();

        public vistaEmpleado()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarTipoEmpleado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea salir de la aplicación?", "Geje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarFormulario();
            }
        }

        private void LlenarTipoEmpleado()
        {
            string[] tipoEmpleado = { "Tiempo Completo", "Tiempo Parcial" };

            foreach (string s in tipoEmpleado)
            {
                cobTipoE.Items.Add(s);
            }
        }

        private void LimpiarFormulario()
        {
            tbNombreE.Text = string.Empty;
            cobTipoE.SelectedIndex = -1;
            tbSalarioBase.Text = string.Empty;
        }

        private void cobTipoE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cobTipoE.SelectedItem != null && cobTipoE.SelectedItem.ToString() == "Tiempo Completo")
            {
                vistaEmpleadoTiempoCompleto vTiempoCompleto = new vistaEmpleadoTiempoCompleto();
                vTiempoCompleto.Show();
            }
            if(cobTipoE.SelectedItem != null && cobTipoE.SelectedItem.ToString() == "Tiempo Parcial")
            {
                vistaEmpleadoTiempoParcial vTiempoParcial = new vistaEmpleadoTiempoParcial();
                vTiempoParcial.Show();
            }
        }
    }
}
