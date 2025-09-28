using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaManzanilla.BE
{
    public class BEPagos
    {
        public string Error { get; set; }
        public int AgregarPago(Pagos pago)
        {
            DAL.PagosDAL pagosDAL = new DAL.PagosDAL();
            try
            {
                return pagosDAL.InsertarPago(pago);
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return -1; // Indicar error
            }
        }
    }
}
