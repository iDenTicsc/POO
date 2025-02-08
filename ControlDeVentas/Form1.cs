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

namespace ControlDeVentas
{
    public partial class frmVentas : Form
    {
        //Array inicial para combobox
        static string[] productos = { "Teclado", "Impresora", "Monitor", "Bocinas" };

        //Arraylist para el ComboBox
        ArrayList aProducto = new ArrayList(productos);
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            MostrarFecha();
            MostrarHora();
            LimpiarCampos();
            LlenarProductos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void cobProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void MostrarHora()
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void LimpiarCampos()
        {
            tbCliente.Clear();
            cobProducto.Text = "Seleccione un producto";
            lblPrecio.Text = "COP 0.00";
            tbCantidad.Clear();
            tbCliente.Focus();
        }

        private void LlenarProductos()
        {
            foreach(var p in aProducto)
            {
                cobProducto.Items.Add(p);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Desea salir?", "Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarCampos();
            }
        }       
    }
}
