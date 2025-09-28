using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaManzanilla.BE
{
    public class RegistroHorasDetalle
    {
        public int IdRegistro { get; set; }
        public TimeOnly HoraIngreso { get; set; }
        public TimeOnly HoraSalida { get; set; }
        public RegistroHorasDetalle(int idRegistro, TimeOnly horaIngreso, TimeOnly horaSalida)
        {
            IdRegistro = idRegistro;
            HoraIngreso = horaIngreso;
            HoraSalida = horaSalida;
        }
    }
}
