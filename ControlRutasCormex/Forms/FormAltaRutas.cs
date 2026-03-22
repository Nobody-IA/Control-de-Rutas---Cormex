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
            SendMessage(cmbChofer.Handle, CB_SETCUEBANNER, 0, "Seleccione");
            SendMessage(cmbTipo.Handle, CB_SETCUEBANNER, 0, "Seleccione");
        }
        #endregion
        #region Métodos de carga
        private void CargarCiudades()
        {
            string query = "SELECT IdCiudad, Nombre FROM Ciudades ORDER BY Nombre ASC";
            ConsultasBase.LlenarComboBox(cmbCiudad, query, "Nombre", "IdCiudad");
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
            // Limpiamos antes de empezar
            cmbChofer.DataSource = null;
            cmbChofer.Items.Clear();
            using (var conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    conexion.Open();

                    // Modificamos el query: "(ID) Nombre Apellido"
                    // Usamos CAST para convertir el número a texto y poder pegarlo
                    string query = @"SELECT IdEmpleado, 
                             '(' + CAST(IdEmpleado AS VARCHAR) + ') ' + Nombre + ' ' + ApellidoPaterno AS NombreIdentificado 
                             FROM Empleados 
                             WHERE IdCiudad = @IdCiudad AND Activo = 1 
                             ORDER BY Nombre ASC";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@IdCiudad", idCiudad);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count > 0)
                    {
                        cmbChofer.DataSource = dt;
                        // Usamos el nuevo alias "NombreIdentificado"
                        cmbChofer.DisplayMember = "NombreIdentificado";
                        cmbChofer.ValueMember = "IdEmpleado";
                        cmbChofer.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("No hay choferes en esta ciudad.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar choferes: " + ex.Message);
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
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombreRuta.Text, @"^[a-zA-Z0-9\s]+$"))
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
                txtCapacidad.Focus();
                txtCapacidad.SelectAll();
                return false;
            }

            if (cmbTipo.SelectedIndex == 1 && capacidad > 100)
            {
                MessageBox.Show("Máximo 100 para Artículos");
                txtCapacidad.Focus();
                txtCapacidad.SelectAll();
                return false;
            }


            return true;
        }
        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCiudad.SelectedValue == null)
                return;

            // Evitar el problema de DataRowView
            if (cmbCiudad.SelectedValue is DataRowView)
                return;

            int idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);

            if (idCiudad > 0)
            {
                CargarChoferes(idCiudad);
            }
            else
            {
                cmbChofer.DataSource = null;
                cmbChofer.Items.Clear();
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
        #region mover formulario
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
               "¿Desea salir?",
               "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
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
