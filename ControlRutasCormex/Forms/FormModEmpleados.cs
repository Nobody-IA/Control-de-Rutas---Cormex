using ControlRutasCormex.Data;
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
    public partial class FormModEmpleados : Form
    {
        public FormModEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion vali = new Validacion();
            e.KeyChar = Convert.ToChar(vali.SoloNumeros(e.KeyChar));
        }
    }
}
