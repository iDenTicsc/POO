using GestionDeEmpleados.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados.Controladores
{
    internal class ControllerEmpleado
    {
        private List<Empleado> empleados = new List<Empleado>();

        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        } 

        public List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }
    }
}
