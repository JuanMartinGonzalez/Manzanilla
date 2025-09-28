using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaManzanilla.BE
{
    public class BERegistroHorasDetalle
    {
        public string Error { get; set; }
        public int AgregarDetalle(RegistroHorasDetalle registroDetalle)
        {
            DAL.RegistroHorasDetalleDAL registroDAL = new DAL.RegistroHorasDetalleDAL();
            try
            {
                return registroDAL.InsertarDetalle(registroDetalle);
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return -1; // Indicar error
            }
        }
    }
}
