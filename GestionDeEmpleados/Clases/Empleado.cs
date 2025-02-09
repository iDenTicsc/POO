using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados.Clases
{
    public abstract class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoEmpleado {  get; set; }
        public double SalarioBase { get; set; }

        public Empleado(int id, string nombre, string tipoEmpleado, double salarioBase)
        {
            Id = id;
            Nombre = nombre;
            TipoEmpleado = tipoEmpleado;
            SalarioBase = salarioBase;
        }

        //Metodo abstracto para polimorfismo
        public abstract double CalcularSalario();
    }
}
