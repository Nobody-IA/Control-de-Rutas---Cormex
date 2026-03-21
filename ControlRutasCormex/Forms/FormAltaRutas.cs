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
            //validar nombre de la ruta
            //validar tipo de ruta
            //validar 
            return true;
        }
        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCiudad.SelectedValue != null && cmbCiudad.SelectedValue is int idCiudad)
            {
                CargarChoferes(idCiudad);
            }
        }

    }
}
