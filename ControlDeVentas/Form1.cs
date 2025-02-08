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
        static string[] productos = { "Teclado", "Impresora", "Monitor", "Bocinas", "Mouse"};

        //Arraylist para el ComboBox
        ArrayList aProducto = new ArrayList(productos);

        //Objeto de la clase ventas
        Ventas objVenta = new Ventas();

        //Acumulador para total
        double total;

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

            lblTotal.Text = "0.00";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Enviar datos a la clase ventas
            objVenta.Producto = cobProducto.Text;
            objVenta.Cantidad = int.Parse(tbCantidad.Text);

            //Imprimir resultado
            ListViewItem Fila = new ListViewItem(objVenta.Producto);
            Fila.SubItems.Add(objVenta.Cantidad.ToString());
            Fila.SubItems.Add(objVenta.AsignacionPrecio().ToString("C"));
            Fila.SubItems.Add(objVenta.CalcularSubtotal().ToString("C"));
            Fila.SubItems.Add(objVenta.CalcularDescuento().ToString("C"));
            Fila.SubItems.Add(objVenta.CalcularNeto().ToString("C"));

            //Agregar resultados a la lista del formulario
            lvRegistro.Items.Add(Fila);

            //Suma de productos total
            total += objVenta.CalcularNeto();

            //Imprimir totales
            lblTotal.Text = total.ToString();

            //Limpiamos los campos
            LimpiarCampos();
        }

        private void cobProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            objVenta.Producto = cobProducto.Text;
            lblPrecio.Text = objVenta.AsignacionPrecio().ToString("C");
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
            lblPrecio.Text = "0.00";
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
