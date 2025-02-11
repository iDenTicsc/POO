using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados.Clases
{
    public class EmpleadoTiempoCompleto : Empleado
    {
        public double SalarioBase { get; set; }
        public double Bono {  get; set; }

        public EmpleadoTiempoCompleto(int id, string nombre, string tipoEmpleado, double salarioBase, double bono) : base(id, nombre, tipoEmpleado)
        {
            SalarioBase = salarioBase;
            Bono = bono;
        }

        public override double CalcularSalario()
        {
            return SalarioBase + Bono;
        }
    }
}
