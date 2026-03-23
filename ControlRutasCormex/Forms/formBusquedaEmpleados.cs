using ControlRutasCormex.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlRutasCormex.Forms
{
    public partial class formBusquedaEmpleados : Form
    {
        public formBusquedaEmpleados()
        {
            InitializeComponent();

        }

        private void formBusquedaEmpleados_Load(object sender, EventArgs e)
        {
            ConfigurarPlaceholder();
            CargarCiudades();
            cmbCiudad.SelectedIndex = -1;
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
        #region Cargar Empleados y Ciudades
        private void CargarCiudades()
        {
            string query = "SELECT IdCiudad, Nombre FROM Ciudades ORDER BY Nombre ASC";
            ConsultasBase.LlenarComboBox(cmbCiudad, query, "Nombre", "IdCiudad");
        }

        private void CargarEmpleados()
        {
            if (cmbCiudad.SelectedValue == null)
                return;

            if (cmbCiudad.SelectedValue is DataRowView)
                return;

            int idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
            string filtro = txtFiltroNombre.Text;

            using (var conexion = new Conexion().ObtenerConexion())
            {
                conexion.Open();

                string query = @"
                SELECT 
                    IdEmpleado,
                    Nombre,
                    ApellidoPaterno,
                    ApellidoMaterno,
                    FechaNacimiento,
                    Sueldo
                FROM Empleados
                WHERE IdCiudad = @IdCiudad
                AND (Nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno) LIKE @Filtro
                AND Activo = 1";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdCiudad", idCiudad);
                cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvEmpleados.DataSource = dt;
            }
        }
        //mejor desabilitar al empleado en lugar de eliminarlo completamente
        private void EliminarEmpleado(int idEmpleado)
        {
            using (var conexion = new Conexion().ObtenerConexion())
            {
                conexion.Open();

                // Validar si tiene rutas
                string queryValidar = "SELECT COUNT(*) FROM Rutas WHERE IdEmpleado = @Id";
                SqlCommand cmdValidar = new SqlCommand(queryValidar, conexion);
                cmdValidar.Parameters.AddWithValue("@Id", idEmpleado);

                int totalRutas = (int)cmdValidar.ExecuteScalar();

                if (totalRutas > 0)
                {
                    MessageBox.Show("No se puede eliminar el empleado porque tiene rutas asignadas");
                    return;
                }

                //  Confirmación
                var confirm = MessageBox.Show(
                    "¿Deseas eliminar este empleado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (confirm == DialogResult.No)
                    return;

                // En lugar de eliminar, se desactiva el empleado
                string query = "UPDATE Empleados SET Activo = 0 WHERE IdEmpleado = @Id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", idEmpleado);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Empleado desactivado");
            CargarEmpleados();
        }

        #endregion

        private void btpSalir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Evento para cargar los empleados cada vez que se cambia la ciudad seleccionada o el texto del filtro
        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
        // Evento para cargar los empleados cada vez que se cambia el texto del filtro
        private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores al hacer clic en el encabezado o fuera de las filas
            if (e.RowIndex < 0) return;
            // Evitar errores al hacer clic en la fila de "nueva entrada"
            if (dgvEmpleados.Rows[e.RowIndex].IsNewRow) return;
            // Verificar que la columna clickeada sea "Editar" o "Eliminar"
            var valorId = dgvEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value;
            if (valorId == null || valorId == DBNull.Value) return;

            int idEmpleado = Convert.ToInt32(dgvEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value);

            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                EliminarEmpleado(idEmpleado);
            }

            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "Editar")
            {
                idEmpleado = Convert.ToInt32(dgvEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value);
                FormModEmpleados formME = new FormModEmpleados(idEmpleado);
                formME.ShowDialog();
            }
        }
        private void AgregarBotones()
        {
            if (!dgvEmpleados.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgvEmpleados.Columns.Add(btnEditar);
            }

            if (!dgvEmpleados.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgvEmpleados.Columns.Add(btnEliminar);
            }
        }
        private void dgvEmpleados_DataSourceChanged(object sender, EventArgs e)
        {
            AgregarBotones();
        }
    }
}
