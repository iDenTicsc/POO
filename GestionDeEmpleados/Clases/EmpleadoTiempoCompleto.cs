using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados.Clases
{
    public class EmpleadoTiempoCompleto : Empleado
    {
        public double Bono {  get; set; }

        public EmpleadoTiempoCompleto(int id, string nombre, double salarioBase, double bono) : base(id, nombre, salarioBase)
        {
            Bono = bono;
        }

        public override double CalcularSalarioBase()
        {
            return SalarioBase + Bono;
        }
    }
}
