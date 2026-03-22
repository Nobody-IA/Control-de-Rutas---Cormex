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
    public partial class FormAltaRutas : Form
    {
        public FormAltaRutas()
        {
            InitializeComponent();
        }

        private void FormAltaRutas_Load(object sender, EventArgs e)
        {
            CargarCiudades();
            CargarTipo();

        }

        #region Métodos de carga
        private void CargarCiudades()
        {
            using (var conexion = new Conexion().ObtenerConexion())
            {
                try
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
                catch (Exception ex)
                {

                    MessageBox.Show("Error al cargar ciudades: " + ex.Message);
                }

            }

        }

        private void CargarTipo()
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Personal");
            cmbTipo.Items.Add("Artículos");
            cmbTipo.SelectedIndex = -1; // "Seleccione"

        }

        private void CargarChoferes(int idCiudad)
        {
            using (var conexion = new Conexion().ObtenerConexion())
            {
                conexion.Open();

                string query = @"SELECT IdEmpleado, Nombre + ' ' + ApellidoPaterno AS NombreCompleto 
                         FROM Empleados 
                         WHERE IdCiudad = @IdCiudad AND Activo = 1";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdCiudad", idCiudad);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay choferes Disponibles en esta ciudad");
                }


            }
        }
        #endregion

        private bool ValidarCampos()
        {
            //validar que se haya seleccionado una ciudad
            if (cmbCiudad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una ciudad");
                cmbCiudad.Focus();
                return false;
            }
            //validar nombre de la ruta
            if (string.IsNullOrWhiteSpace(txtNombreRuta.Text))
            {
                MessageBox.Show("Ingrese el nombre de la ruta");
                txtNombreRuta.Focus();
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombreRuta.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Solo caracteres alfanuméricos");
                return false;
            }
            //validar tipo de ruta
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de ruta");
                cmbTipo.Focus();
                return false;
            }

            //validar chofer
            if (cmbChofer.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un chofer");
                cmbChofer.Focus();
                return false;
            }

            //validar capacidad
            if (!int.TryParse(txtCapacidad.Text, out int capacidad) || capacidad <= 0)
            {
                MessageBox.Show("Capacidad inválida");
                return false;
            }

            if (cmbTipo.SelectedIndex == 0 && capacidad > 34)
            {
                MessageBox.Show("Máximo 34 para Personal");
                return false;
            }

            if (cmbTipo.SelectedIndex == 1 && capacidad > 100)
            {
                MessageBox.Show("Máximo 100 para Artículos");
                return false;
            }


            return true;
        }
        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCiudad.SelectedValue != null && cmbCiudad.SelectedValue is int idCiudad)
            {
                CargarChoferes(idCiudad);
            }
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion vali = new Validacion();
            e.KeyChar = Convert.ToChar(vali.SoloNumeros(e.KeyChar));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            using (var conexion = new Conexion().ObtenerConexion())
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("InsertarRuta", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreRuta", txtNombreRuta.Text);
                cmd.Parameters.AddWithValue("@Tipo", cmbTipo.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Capacidad", int.Parse(txtCapacidad.Text));
                cmd.Parameters.AddWithValue("@IdCiudad", cmbCiudad.SelectedValue);
                cmd.Parameters.AddWithValue("@IdEmpleado", cmbChofer.SelectedValue);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ruta guardada correctamente");
            }

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cmbCiudad.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            cmbChofer.DataSource = null;

            txtNombreRuta.Clear();
            txtCapacidad.Clear();

            cmbCiudad.Focus();
        }
    }
}
