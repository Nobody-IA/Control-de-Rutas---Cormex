using ControlRutasCormex.Data;
using ControlRutasCormex.Forms;

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
        #region botones de control de ventana

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
            formAltaEmpleado formAltaEmpleado = new formAltaEmpleado();
            formAltaEmpleado.ShowDialog();
            
        }
    }
}
