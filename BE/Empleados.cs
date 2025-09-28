using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaManzanilla.BE
{
    public class Empleados
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public int SueldoHora { get; set; }
        public bool Inactivo { get; set; }

        public Empleados(int idEmpleado, string nombre, string apellido, string dni, string telefono, int sueldoHora, bool inactivo)
        {
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            SueldoHora = sueldoHora;
            Inactivo = inactivo;
        }
    }
}
