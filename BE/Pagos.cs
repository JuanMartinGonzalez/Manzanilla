using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaManzanilla.BE
{
    public class Pagos
    {
        public int IdPago { get; set; }
        public int IdEmpleado { get; set; }
        public int Importe { get; set; }
        public DateTime FechaPago { get; set; }
        public Pagos(int idPago, int idEmpleado, int importe, DateTime fechaPago) 
        {
            IdPago = idPago;
            IdEmpleado = idEmpleado;
            Importe = importe;
            FechaPago = fechaPago;
        }
    }
}
