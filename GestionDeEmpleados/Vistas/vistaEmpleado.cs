﻿using GestionDeEmpleados.Clases;
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
            DialogResult r = MessageBox.Show("Desea salir de la aplicación?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        public void LimpiarFormulario()
        {
            tbNombreE.Text = string.Empty;
            cobTipoE.SelectedIndex = -1;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            int id = 0;

            if(cobTipoE.SelectedItem != null && cobTipoE.SelectedItem.ToString() == "Tiempo Completo")
            {
                vistaEmpleadoTiempoCompleto vTiempoCompleto = new vistaEmpleadoTiempoCompleto(this);
                vTiempoCompleto.id = id;
                vTiempoCompleto.Nombre = tbNombreE.Text;
                vTiempoCompleto.TipoEmpleado = cobTipoE.SelectedItem.ToString();
                vTiempoCompleto.Show();
            }
            if (cobTipoE.SelectedItem != null && cobTipoE.SelectedItem.ToString() == "Tiempo Parcial")
            {
                vistaEmpleadoTiempoParcial vTiempoParcial = new vistaEmpleadoTiempoParcial(this);
                vTiempoParcial.id = id;
                vTiempoParcial.Nombre = tbNombreE.Text;
                vTiempoParcial.TipoEmpleado = cobTipoE.SelectedItem.ToString();
                vTiempoParcial.Show();
            }
        }

        public void ActualizarLista(List<Empleado> empleados)
        {
            foreach (var emp in empleados)
            {
                ListViewItem Fila = new ListViewItem(emp.Nombre);
                Fila.SubItems.Add(emp.TipoEmpleado);
                Fila.SubItems.Add(emp.CalcularSalario().ToString("C"));
                lvMostrarE.Items.Add(Fila);
            }
            
        }       
    }
}
