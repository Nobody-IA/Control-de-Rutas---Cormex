using ControlRutasCormex.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            if (!ValidarCampos())
                return;

            try
            {
                using (var conexion = new Conexion().ObtenerConexion())
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("ActualizarEmpleado", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", _idEmpleado);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@Sueldo", decimal.Parse(txtSueldo.Text));

                    cmd.ExecuteNonQuery();


                }

                MessageBox.Show("Empleado actualizado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormModEmpleados_Load(object sender, EventArgs e)
        {
            CargarCiudades();
            // Cargar datos del empleado
            CargarEmpleado();
            // Deshabilitar campos que no se pueden modificar
            txtNombre.Enabled = false;
            txtApPaterno.Enabled = false;
            txtApMaterno.Enabled = false;
            cmbCiudad.Enabled = false;
        }
        private void CargarCiudades()
        {
            string query = "SELECT IdCiudad, Nombre FROM Ciudades ORDER BY Nombre ASC";
            ConsultasBase.LlenarComboBox(cmbCiudad, query, "Nombre", "IdCiudad");
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
            // Validar que se haya seleccionado una ciudad
            if (cmbCiudad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una ciudad");
                cmbCiudad.Focus();
                return false;
            }
            // Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre");
                txtNombre.Focus();
                return false;
            }
            // Validar que el nombre solo contenga letras
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras");
                return false;
            }
            //  Validar que el nombre no exceda los 15 caracteres
            if (txtNombre.Text.Length > 15)
            {
                MessageBox.Show("Máximo 15 caracteres");
                return false;
            }
            // Validar que el sueldo sea numérico
            if (!int.TryParse(txtSueldo.Text, out _))
            {
                MessageBox.Show("El sueldo debe ser numérico");
                txtSueldo.Focus();
                return false;
            }

            // Validar que el empleado sea mayor de edad
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - dtpFechaNacimiento.Value.Year;

            //Si la fecha de nacimiento es mayor al día de hoy menos la edad calculada, entonces se resta un año a la edad
            if (fechaNacimiento.Date > hoy.AddYears(-edad))
            {
                edad--;
            }
            if (edad < 18)
            {
                MessageBox.Show("El empleado debe ser mayor de edad");
                return false;
            }

            return true;
        }

        #region MoverFormulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


        private void btnSalir2_Click(object sender, EventArgs e)
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
    }
}
