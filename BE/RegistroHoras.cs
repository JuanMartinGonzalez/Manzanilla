using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaManzanilla.BE
{
    public class RegistroHoras
    {
        public int IdRegistro { get; set; }
        public int IdEmpleado { get; set; }
        public DateOnly Fecha { get; set; }
        public int PrecioHora { get; set; }
        public int Descanso { get; set; }
        public bool FeriadoDomingo { get; set; }
        public RegistroHoras(int idRegistro, int idEmpleado, DateOnly fecha, int precioHora, int descanso, bool feriadoDomingo)
        {
            IdRegistro = idRegistro;
            IdEmpleado = idEmpleado;
            Fecha = fecha;
            PrecioHora = precioHora;
            Descanso = descanso;
            FeriadoDomingo = feriadoDomingo;
        }
    }
}
