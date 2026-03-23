using ControlRutasCormex.Data;
using ControlRutasCormex.Forms;
using System.Runtime.InteropServices;

namespace ControlRutasCormex
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }


        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
        #region BotonesDeControlDeVentana

        private void btnCerrar_Click(object sender, EventArgs e)
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

        private void btnMaximisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximisar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximisar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        private void btnAltaEmpleados_Click(object sender, EventArgs e)
        {
            formModEmpleados formAltaEmpleado = new formModEmpleados();
            formAltaEmpleado.ShowDialog();

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

        private void btnAltaRutas_Click(object sender, EventArgs e)
        {
            FormAltaRutas formAltaRutas = new FormAltaRutas();
            formAltaRutas.ShowDialog();
        }

        private void btnBusquedaRutas_Click(object sender, EventArgs e)
        {
            FormBusquedaRuta formBusquedaRuta = new FormBusquedaRuta();
            formBusquedaRuta.ShowDialog();
        }

        private void btnBusquedaEmpleados_Click(object sender, EventArgs e)
        {
            formBusquedaEmpleados formBusquedaEmpleados = new formBusquedaEmpleados();
            formBusquedaEmpleados.ShowDialog();
        }

        private void FormMenu_KeyPress(object sender, KeyPressEventArgs e)
        {

            this.Close();
        }
    }
}
