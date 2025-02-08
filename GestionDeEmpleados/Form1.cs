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
    public partial class Form1 : Form
    {       
        public Form1()
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
        }
        private void btnAgregarE_Click(object sender, EventArgs e)
        { 
            //TO DO: Agregar empleados desde sus clases

            LimpiarFormulario();
        }

        private void LlenarTipoEmpleado()
        {
            string[] tipoEmpleado = { "Tiempo Completo", "Medio Tiempo" };

            foreach (string s in tipoEmpleado)
            {
                cobTipoE.Items.Add(s);
            }
        }

        private void LimpiarFormulario()
        {
            tbNombreE.Text = string.Empty;
            cobTipoE.SelectedIndex = -1;
        }

    }
}
