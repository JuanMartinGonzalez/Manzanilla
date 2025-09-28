using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaManzanilla.BE;
using Microsoft.Data.SqlClient;
using static EmpresaManzanilla.FormPadre;

namespace EmpresaManzanilla.DAL
{
    public class PagosDAL
    {
        public string Error { get; set; }
        private readonly ConexionBD _conexion;
        public PagosDAL()
        {
            _conexion = new ConexionBD();
        }
        public int InsertarPago(Pagos pago)
        {
            try
            {
                string query = @"INSERT INTO Pagos
                                (idEmpleado, importe, fechaPago)
                                VALUES (@idEmpleado, @importe, GETDATE());
                                SELECT SCOPE_IDENTITY();";

                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idEmpleado", pago.IdEmpleado);
                        cmd.Parameters.AddWithValue("@importe", pago.Importe);

                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return -1;
            }
        }
    }
}
