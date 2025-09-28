using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaManzanilla.BE
{
    public class BEEmpleado
    {
        public string Error { get; set; }

        public int AgregarEmpleado(Empleados empleado)
        {
            DAL.EmpleadoDAL empleadoDAL = new DAL.EmpleadoDAL();
            try
            {
                return empleadoDAL.AgregarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return -1; // Indicar error
            }
        }
    }
}
