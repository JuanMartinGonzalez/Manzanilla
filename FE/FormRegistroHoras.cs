using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpresaManzanilla.BE;
using EmpresaManzanilla.DAL;

namespace EmpresaManzanilla.FE
{
    public partial class FormRegistroHoras : Form
    {
        public FormRegistroHoras()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            EmpleadoDAL empleadoDAL = new EmpleadoDAL();
            var empleados = empleadoDAL.ObtenerEmpleados();
            comboBoxEmpleado.DataSource = empleados;
            comboBoxEmpleado.DisplayMember = "Nombre";
            comboBoxEmpleado.ValueMember = "IdEmpleado";
        }

        private void buttonRegistrarHoras_Click(object sender, EventArgs e)
        {
            int idEmpleado = Convert.ToInt32(comboBoxEmpleado.SelectedValue);
            DateOnly fecha = DateOnly.FromDateTime(dateTimePickerFechaRegistroHoras.Value);
            int precioHora = (int)numericUpDownPrecioHoraRegistroHoras.Value;
            bool feriado = checkBoxFeriado.Checked;
            int descanso = (int)numericUpDownDescanso.Value;

            var horaIngreso = new TimeOnly((int)numericUpDownHoraIngreso.Value, (int)numericUpDownMinutoIngreso.Value);
            var horaSalida = new TimeOnly((int)numericUpDownHoraSalida.Value, (int)numericUpDownMinutoSalida.Value);

            var registro = new RegistroHoras(0, 0, DateOnly.MinValue, 0, 0, false)
            {
                IdEmpleado = idEmpleado,
                Fecha = fecha,
                PrecioHora = precioHora,
                FeriadoDomingo = feriado,
                Descanso = descanso
            };

            var detalle = new RegistroHorasDetalle(0, TimeOnly.MinValue, TimeOnly.MinValue)
            {
                HoraIngreso = horaIngreso,
                HoraSalida = horaSalida
            };

            var be = new BERegistroHoras();
            int idRegistro = be.AgregarRegistroConDetalle(registro, detalle);

            if (idRegistro > 0)
                MessageBox.Show("Registro de horas guardado con éxito");
            else
                MessageBox.Show("Error al guardar el registro: " + be.Error);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
