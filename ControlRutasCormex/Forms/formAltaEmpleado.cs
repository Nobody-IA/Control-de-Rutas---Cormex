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
using static System.Collections.Specialized.BitVector32;

namespace ControlRutasCormex.Forms
{
    public partial class formAltaEmpleado : Form
    {
        public formAltaEmpleado()
        {
            InitializeComponent();
        }

        private void formAltaEmpleado_Load(object sender, EventArgs e)
        {
            CargarCiudades();
            ConfigurarPlaceholder();

        }
        #region Placeholder

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        const int CB_SETCUEBANNER = 0x1703; // Código para poner el texto sugerido

        private void ConfigurarPlaceholder()
        {
            // Texto Fantasma para los ComboBox
            SendMessage(cmbCiudad.Handle, CB_SETCUEBANNER, 0, "Seleccione");
        }
        #endregion
        private void CargarCiudades()
        {
            using (var conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT IdCiudad, Nombre FROM Ciudades ORDER BY Nombre ASC";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbCiudad.DataSource = dt;
                    cmbCiudad.DisplayMember = "Nombre";
                    cmbCiudad.ValueMember = "IdCiudad";


                    cmbCiudad.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            try
            {
                using (var conexion = new Conexion().ObtenerConexion())
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("InsertarEmpleado", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", txtApPaterno.Text);
                    cmd.Parameters.AddWithValue("@ApellidoMaterno", txtApMaterno.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@Sueldo", decimal.Parse(txtSueldo.Text));
                    cmd.Parameters.AddWithValue("@IdCiudad", cmbCiudad.SelectedValue);

                    var id = cmd.ExecuteScalar();

                    MessageBox.Show("Empleado guardado. ID: " + id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar empleado" + ex.Message);
            }

            if (!ValidarCampos())
                return;

            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            cmbCiudad.SelectedIndex = -1;
            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtSueldo.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;

            cmbCiudad.Focus();
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

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
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
