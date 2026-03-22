using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlRutasCormex.Data
{
    internal class Validacion
    {
        public int SoloNumeros(int Tecla)
        {
            switch (Tecla)
            {
                case >= 48 and <= 57: // Números del 0 al 9
                case 8: // Retroceso
                case 46: // Punto decimal
                case 13: // Enter

                return Tecla; // Permitir la tecla    
                default:
                    MessageBox.Show("Solo se permiten números");
                    break;
            }
            return Tecla = 0; 
        }

    }
}
