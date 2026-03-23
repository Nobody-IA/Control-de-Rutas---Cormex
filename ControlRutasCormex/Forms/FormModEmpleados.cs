using ControlRutasCormex.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlRutasCormex.Forms
{
    public partial class FormModEmpleados : Form
    {
        private int _idEmpleado;
        public FormModEmpleados(int idEmpleado)
        {
            InitializeComponent();
            _idEmpleado = idEmpleado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Desea salir?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion vali = new Validacion();
            e.KeyChar = Convert.ToChar(vali.SoloNumeros(e.KeyChar));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void FormModEmpleados_Load(object sender, EventArgs e)
        {
            // Cargar datos del empleado
            CargarEmpleado();
            // Deshabilitar campos que no se pueden modificar
            txtNombre.Enabled = false;
            txtApPaterno.Enabled = false;
            txtApMaterno.Enabled = false;
            cmbCiudad.Enabled = false;
        }

        private void CargarEmpleado()
        {
            using (var conexion = new Conexion().ObtenerConexion())
            {
                conexion.Open();

                string query = "SELECT * FROM Empleados WHERE IdEmpleado = @Id";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", _idEmpleado);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtApPaterno.Text = reader["ApellidoPaterno"].ToString();
                    txtApMaterno.Text = reader["ApellidoMaterno"].ToString();
                    dtpFechaNacimiento.Value = Convert.ToDateTime(reader["FechaNacimiento"]);
                    txtSueldo.Text = reader["Sueldo"].ToString();
                }
            }
        }

        private bool ValidarCampos()
        {
            if (!decimal.TryParse(txtSueldo.Text, out decimal sueldo) || sueldo <= 0)
            {
                MessageBox.Show("Sueldo inválido");
                return false;
            }

            int edad = DateTime.Now.Year - dtpFechaNacimiento.Value.Year;

            if (edad < 18)
            {
                MessageBox.Show("Debe ser mayor de edad");
                return false;
            }

            return true;
        }
    }
}
