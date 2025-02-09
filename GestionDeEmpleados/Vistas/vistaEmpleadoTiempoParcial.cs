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
    public partial class vistaEmpleadoTiempoParcial : Form
    {
        public int id {  get; set; }
        public string Nombre {  get; set; }
        public double SalarioBase { get; set; }
        public vistaEmpleadoTiempoParcial()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
