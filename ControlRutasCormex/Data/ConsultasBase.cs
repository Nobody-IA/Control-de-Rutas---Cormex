using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlRutasCormex.Data
{
    internal class ConsultasBase
    {

        // Llena un ComboBox con datos de SQL de forma genérica

        public static void LlenarComboBox(ComboBox combo, string query, string displayMember, string valueMember)
        {
            try
            {
                using (var conexion = new Conexion().ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    combo.DataSource = dt;
                    combo.DisplayMember = displayMember;
                    combo.ValueMember = valueMember;

                    // Siempre iniciamos sin selección por estética
                    combo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
