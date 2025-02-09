using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados.Clases
{
    internal class EmpleadoTiempoParcial : Empleado
    {
        public int HorasTrabajadas {  get; set; }
        public double PagoPorHora { get; set; }

        public EmpleadoTiempoParcial(int id, string nombre, double salarioBase, int horasTrabajadas, double pagoPorHora) : base(id, nombre, salarioBase)
        {
            HorasTrabajadas = horasTrabajadas;
            PagoPorHora = pagoPorHora;
        }

        public override double CalcularSalarioBase()
        {
            return HorasTrabajadas * PagoPorHora;
        }
    }
}
