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
    public class RegistroHorasDetalleDAL
    {
        public string Error { get; set; }
        private readonly ConexionBD _conexion;
        public RegistroHorasDetalleDAL()
        {
            _conexion = new ConexionBD();
        }
        public int InsertarDetalle(RegistroHorasDetalle registroDetalle)
        {
            try
            {
                string query = @"INSERT INTO RegistroHorasDetalle 
                                (horaIngreso, horaSalida)
                                VALUES (@horaIngreso, @horaSalida);
                                SELECT SCOPE_IDENTITY();";

                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@horaIngreso", registroDetalle.HoraIngreso);
                        cmd.Parameters.AddWithValue("@horaSalida", registroDetalle.HoraSalida);

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
