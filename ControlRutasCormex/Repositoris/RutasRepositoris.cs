using ControlRutasCormex.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlRutasCormex.Repositoris
{
    internal class RutasRepositoris
    {

        public void GuardarModRutas(int Tipo, int capacidad, int Empleado, int Ruta)
        {
            //sacar los querys a un repositorio
            //using (var conexion = new Conexion().ObtenerConexion())
            //{
            //    conexion.Open();

            //    string query = @"
            //    UPDATE Rutas
            //    SET 
            //        Tipo = @Tipo,
            //        Capacidad = @Capacidad,
            //        IdEmpleado = @Empleado
            //    WHERE IdRuta = @IdRuta";

            //    SqlCommand cmd = new SqlCommand(query, conexion);

            //    cmd.Parameters.AddWithValue("@Tipo", tipo.SelectedIndex + 1);
            //    cmd.Parameters.AddWithValue("@Capacidad", int.Parse(txtCapacidad.Text));
            //    cmd.Parameters.AddWithValue("@Empleado", cmbChofer.SelectedValue);
            //    cmd.Parameters.AddWithValue("@IdRuta", _idRuta);

            //    cmd.ExecuteNonQuery();
            //}
        }
    }
}
