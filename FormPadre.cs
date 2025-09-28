using System;
using Microsoft.Data.SqlClient;
using EmpresaManzanilla.FE;

namespace EmpresaManzanilla
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }
        public class ConexionBD
        {
            private readonly string _connectionString;

            public ConexionBD()
            {

                _connectionString = Environment.GetEnvironmentVariable("CADENA_CONEXION_SQL_EmpresaManzanilla")
                                    ?? throw new InvalidOperationException("❌ No se encontró la variable de entorno CADENA_CONEXION_SQL_EmpresaManzanilla");
            }

            public SqlConnection ObtenerConexion()
            {
                return new SqlConnection(_connectionString);
            }
        }

        private void FormPadre_Load(object sender, EventArgs e)
        {
            FormRegistroHoras registroHoras = new FormRegistroHoras();
            registroHoras.ShowDialog();
            FormRegistroEmpleados ingreso = new FormRegistroEmpleados();
            ingreso.ShowDialog();
        }
    }
}
