using System;
using Microsoft.Data.SqlClient;
using static EmpresaManzanilla.FormPadre;
using EmpresaManzanilla.BE;

namespace EmpresaManzanilla.DAL
{
    public class RegistroHorasDAL
    {
        public string Error { get; set; }
        private readonly ConexionBD _conexion;

        public RegistroHorasDAL()
        {
            _conexion = new ConexionBD();
        }

        public int InsertarRegistroConDetalle(RegistroHoras registro, RegistroHorasDetalle detalle)
        {
            try
            {
                using (var conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            string sqlInsertRegistro = @"
                        INSERT INTO RegistroHoras (idEmpleado, fecha, precioHora, feriadoDomingo, descanso)
                        OUTPUT INSERTED.idRegistro
                        VALUES (@idEmpleado, @fecha, @precioHora, @feriadoDomingo, @descanso);";

                            int idRegistro;
                            using (var cmd = new SqlCommand(sqlInsertRegistro, conn, tran))
                            {
                                cmd.Parameters.Add("@idEmpleado", System.Data.SqlDbType.Int).Value = registro.IdEmpleado;
                                cmd.Parameters.Add("@fecha", System.Data.SqlDbType.Date).Value = registro.Fecha.ToDateTime(TimeOnly.MinValue);
                                cmd.Parameters.Add("@precioHora", System.Data.SqlDbType.Int).Value = registro.PrecioHora;
                                cmd.Parameters.Add("@feriadoDomingo", System.Data.SqlDbType.Bit).Value = registro.FeriadoDomingo;
                                cmd.Parameters.Add("@descanso", System.Data.SqlDbType.Time).Value = TimeSpan.FromMinutes(registro.Descanso);

                                var scalar = cmd.ExecuteScalar();
                                idRegistro = Convert.ToInt32(scalar);
                            }

                            string sqlInsertDetalle = @"
                        INSERT INTO RegistroHorasDetalle (idRegistro, horaIngreso, horaSalida)
                        VALUES (@idRegistro, @horaIngreso, @horaSalida);";

                            using (var cmd2 = new SqlCommand(sqlInsertDetalle, conn, tran))
                            {
                                cmd2.Parameters.Add("@idRegistro", System.Data.SqlDbType.Int).Value = idRegistro;
                                cmd2.Parameters.Add("@horaIngreso", System.Data.SqlDbType.Time).Value = detalle.HoraIngreso.ToTimeSpan();
                                cmd2.Parameters.Add("@horaSalida", System.Data.SqlDbType.Time).Value = detalle.HoraSalida.ToTimeSpan();

                                cmd2.ExecuteNonQuery();
                            }

                            tran.Commit();
                            return idRegistro;
                        }
                        catch (Exception exInner)
                        {
                            try { tran.Rollback(); } catch { /* ignorar */ }
                            Error = exInner.Message;
                            return -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return -1;
            }
        }
        public decimal CalcularPagoEmpleadoSQL(int idEmpleado, DateTime desde, DateTime hasta)
        {
            using (var conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        SUM(
                            (DATEDIFF(MINUTE, r.horaIngreso, r.horaSalida) / 60.0) * r.precioHora *
                            CASE WHEN r.feriadoDomingo = 1 THEN 2 ELSE 1 END
                        )
                    FROM RegistroHoras r
                    WHERE r.idEmpleado = @idEmpleado
                      AND r.fecha BETWEEN @desde AND @hasta";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@desde", desde);
                    cmd.Parameters.AddWithValue("@hasta", hasta);

                    object result = cmd.ExecuteScalar();
                    return (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                }
            }
        }
    
    }
}