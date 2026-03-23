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
    public partial class FormBusquedaRuta : Form
    {
        public FormBusquedaRuta()
        {
            InitializeComponent();
        }

        private void FormBusquedaRuta_Load(object sender, EventArgs e)
        {
            CargarCiudades();
            ConfigurarPlaceholder();
        }
        private void CargarCiudades()
        {
            string query = "SELECT IdCiudad, Nombre FROM Ciudades ORDER BY Nombre ASC";
            ConsultasBase.LlenarComboBox(cmbCiudad, query, "Nombre", "IdCiudad");
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
        // Botón para cerrar el formulario

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //boton fallido 

        private void txtFiltroRuta_Enter(object sender, EventArgs e)
        {

        }
        //metodo para optener las rutas de la base de datos con un filtro por nombre y por ciudad
        private DataTable ObtenerRutas(int idCiudad, string filtro)
        {

            using (var conexion = new Conexion().ObtenerConexion())
            {

                conexion.Open();

                string query = @"
                SELECT 
                    R.IdRuta,
                    R.NombreRuta,
                    CASE 
                        WHEN R.Tipo = 1 THEN 'Personal'
                        ELSE 'Artículos'
                    END AS Tipo,
                    R.Capacidad,
                    E.Nombre + ' ' + E.ApellidoPaterno AS Chofer
                FROM Rutas R
                INNER JOIN Empleados E ON R.IdEmpleado = E.IdEmpleado
                WHERE R.IdCiudad = @IdCiudad
                AND R.NombreRuta LIKE @Filtro";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdCiudad", idCiudad);
                cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }


        //boton para eliminar el filtro y mostrar todas las rutas de la ciudad seleccionada
        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {

        }
        //agregar botones de editar y eliminar a cada fila del datagridview
        private void AgregarBotones()
        {
            if (!dgvRutas.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgvRutas.Columns.Add(btnEditar);
            }

            if (!dgvRutas.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgvRutas.Columns.Add(btnEliminar);
            }
        }
        //eliminar ruta
        private void EliminarRuta(int idRuta)
        {
            var confirm = MessageBox.Show(
                "¿Deseas eliminar esta ruta?",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.No)
                return;

            using (var conexion = new Conexion().ObtenerConexion())
            {
                conexion.Open();

                string query = "DELETE FROM Rutas WHERE IdRuta = @Id";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Id", idRuta);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Ruta eliminada");

            CargarRutas(); // refrescar el datagridview
        }

        private void dgvRutas_DataSourceChanged(object sender, EventArgs e)
        {
            AgregarBotones();
        }
        //boton temporal de busqueda
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbCiudad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una ciudad");
                return;
            }

            int idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
            string filtro = txtFiltroRuta.Text;

            dgvRutas.DataSource = ObtenerRutas(idCiudad, filtro);
        }

        //evento para detectar el click en los botones de editar y eliminar del datagridview
        private void dgvRutas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //primero validamos que no se haya hecho click en el encabezado o en una fila nueva
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            // Validamos que no sea la fila de "nueva fila" al final del DataGridView
            if (dgvRutas.Rows[e.RowIndex].IsNewRow) return;
            //validamos que el valor de la celda "IdRuta" no sea nulo o DBNull antes de convertirlo a entero
            var valorId = dgvRutas.Rows[e.RowIndex].Cells["IdRuta"].Value;
            if (valorId == null || valorId == DBNull.Value) return;
            // Obtenemos el IdRuta de la fila seleccionada
            int idRuta = Convert.ToInt32(dgvRutas.Rows[e.RowIndex].Cells["IdRuta"].Value);

            if (dgvRutas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                EliminarRuta(idRuta);
                CargarRutas(); // Refrescar después de borrar
            }

            if (dgvRutas.Columns[e.ColumnIndex].Name == "Editar")
            {
                idRuta = Convert.ToInt32(dgvRutas.Rows[e.RowIndex].Cells["IdRuta"].Value);
                FormModRutas frm = new FormModRutas(idRuta);
                frm.ShowDialog();

                CargarRutas(); // refrescar
            }
        }
        //prototipo de cargar datos en tiempo real al escribir en el filtro y al seleccionar una ciudad
        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarRutas();
        }

        private void txtFiltroRuta_TextChanged(object sender, EventArgs e)
        {
            CargarRutas();
        }

        //metodo para cargar todas las rutas
        private void CargarRutas()
        {
            if (cmbCiudad.SelectedValue == null)
                return;

            if (cmbCiudad.SelectedValue is DataRowView)
                return;

            int idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
            string filtro = txtFiltroRuta.Text;

            using (var conexion = new Conexion().ObtenerConexion())
            {
                conexion.Open();

                string query = @"
                SELECT 
                    R.IdRuta,
                    R.NombreRuta,
                    CASE 
                        WHEN R.Tipo = 1 THEN 'Personal'
                        ELSE 'Artículos'
                    END AS Tipo,
                    R.Capacidad
                FROM Rutas R
                WHERE R.IdCiudad = @IdCiudad
                AND R.NombreRuta LIKE @Filtro";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdCiudad", idCiudad);
                cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRutas.DataSource = dt;
            }
        }

        private void dgvRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


        private void FormBusquedaRuta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Preguntamos al usuario si realmente quiere salir
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro que desea salir? Se perderán los cambios no guardados.",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
