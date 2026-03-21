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
    public partial class formAltaEmpleado : Form
    {
        public formAltaEmpleado()
        {
            InitializeComponent();
        }

        private void formAltaEmpleado_Load(object sender, EventArgs e)
        {
            CargarCiudades();
            // restar 18 años a la fecha actual para que nadie menor pueda poner su fecha 
            dtpFechaNacimiento.MaxDate = DateTime.Today.AddDays(-18);
        }
        private void CargarCiudades()
        {
            using (var conexion = new Conexion().ObtenerConexion())
            {
                conexion.Open();
                
                string query = "SELECT IdCiudad, Nombre FROM Ciudades";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                cmbCiudad.DataSource = dt;
                cmbCiudad.DisplayMember = "Nombre";
                cmbCiudad.ValueMember = "IdCiudad";

                cmbCiudad.SelectedIndex = -1; // "Seleccione"
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
            if (!ValidarCampos())
                return;

            using (var conexion = new Conexion().ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO Empleados (IdCiudad, Nombre, FechaNacimiento, Sueldo) VALUES (@IdCiudad, @Nombre, @FechaNacimiento, @Sueldo)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdCiudad", cmbCiudad.SelectedValue);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                cmd.Parameters.AddWithValue("@Sueldo", decimal.Parse(txtSueldo.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado registrado exitosamente");
                this.Close();

            }
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
    }
}
