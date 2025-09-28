using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using EmpresaManzanilla.BE;
using static EmpresaManzanilla.FormPadre;

namespace EmpresaManzanilla.DAL
{
    public class EmpleadoDAL
    {
        public string Error { get; set; }
        private readonly ConexionBD _conexion;
        public EmpleadoDAL()
        {   
            _conexion = new ConexionBD();
        }
        public int AgregarEmpleado(Empleados empleado)
        {
            try
            {
                string query = "INSERT INTO Empleados (nombre, apellido, dni, telefonos, sueldoHora, estado) VALUES (@nombre, @apellido, @dni, @telefonos, @sueldoHora, @estado); SELECT SCOPE_IDENTITY();";


                using (SqlConnection conn = _conexion.ObtenerConexion())
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nombre", empleado.Nombre);
                        command.Parameters.AddWithValue("@apellido", empleado.Apellido);
                        command.Parameters.AddWithValue("@dni", empleado.DNI);
                        command.Parameters.AddWithValue("@telefonos", empleado.Telefono);
                        command.Parameters.AddWithValue("@sueldoHora", empleado.SueldoHora);
                        command.Parameters.AddWithValue("@estado", !empleado.Inactivo);

                        // Ejecutar la inserción y devolver el ID generado
                        int nuevoId = Convert.ToInt32(command.ExecuteScalar());
                        return nuevoId;
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return -1;
            }
        }
        public List <Empleados> ObtenerEmpleados()
        {
            List<Empleados> empleados = new List<Empleados>();
            try
            {
                string query = "SELECT idEmpleado, nombre, apellido, dni, telefonos, sueldoHora, estado FROM Empleados";
                using (SqlConnection conn = _conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Empleados empleado = new Empleados(
                                    reader.GetInt32(0), // idEmpleado
                                    reader.GetString(1), // nombre
                                    reader.GetString(2), // apellido
                                    reader.GetString(3), // dni
                                    reader.GetString(4), // telefonos
                                    reader.GetInt32(5), // sueldoHora
                                    !reader.GetBoolean(6) // estado (invertido para Inactivo)
                                );
                                empleados.Add(empleado);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return empleados;
        }
    }
}
