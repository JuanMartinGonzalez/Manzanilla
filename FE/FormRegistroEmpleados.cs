using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpresaManzanilla.BE;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static EmpresaManzanilla.FormPadre;

namespace EmpresaManzanilla.FE
{
    public partial class FormRegistroEmpleados : Form
    {
        public FormRegistroEmpleados()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            BEEmpleado beEmpleado = new BEEmpleado();

            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string dni = textBoxDNI.Text;
            string telefono = textBoxTelefono.Text;
            int sueldoHora = Convert.ToInt32(numericUpDownSueldoHora.Value);
            bool inactivo = checkBoxInactivo.Checked;
            try
            {
                BE.Empleados empleado = new BE.Empleados(0, string.Empty, string.Empty, string.Empty, string.Empty, 0, true)
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    DNI = dni,
                    Telefono = telefono,
                    SueldoHora = sueldoHora,
                    Inactivo = inactivo
                };
                int resultadoId = beEmpleado.AgregarEmpleado(empleado);

                if (resultadoId == -1)
                {
                    MessageBox.Show(beEmpleado.Error ?? "Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Parar el proceso si hubo error en BD
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\n" + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
