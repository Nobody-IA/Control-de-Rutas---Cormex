namespace ControlRutasCormex
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximisar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            panel4 = new Panel();
            btnBusquedaRutas = new Button();
            panel3 = new Panel();
            btnAltaRutas = new Button();
            panel2 = new Panel();
            btnBusquedaEmpleados = new Button();
            panel1 = new Panel();
            btnAltaEmpleados = new Button();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximisar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximisar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 37);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Properties.Resources.res;
            btnRestaurar.Location = new Point(1240, 6);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 2;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.minimazar;
            btnMinimizar.Location = new Point(1209, 6);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximisar
            // 
            btnMaximisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximisar.Cursor = Cursors.Hand;
            btnMaximisar.Image = Properties.Resources.maxi;
            btnMaximisar.Location = new Point(1240, 6);
            btnMaximisar.Name = "btnMaximisar";
            btnMaximisar.Size = new Size(25, 25);
            btnMaximisar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximisar.TabIndex = 1;
            btnMaximisar.TabStop = false;
            btnMaximisar.Click += btnMaximisar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.cerrar1;
            btnCerrar.Location = new Point(1271, 6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(20, 32, 40);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(btnBusquedaRutas);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(btnAltaRutas);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(btnBusquedaEmpleados);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(btnAltaEmpleados);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 37);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 613);
            MenuVertical.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(0, 306);
            panel4.Name = "panel4";
            panel4.Size = new Size(12, 45);
            panel4.TabIndex = 8;
            // 
            // btnBusquedaRutas
            // 
            btnBusquedaRutas.BackColor = Color.FromArgb(20, 32, 40);
            btnBusquedaRutas.FlatAppearance.BorderSize = 0;
            btnBusquedaRutas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnBusquedaRutas.FlatStyle = FlatStyle.Flat;
            btnBusquedaRutas.Font = new Font("Arial", 9.75F);
            btnBusquedaRutas.ForeColor = SystemColors.ControlLightLight;
            btnBusquedaRutas.Image = Properties.Resources.compras;
            btnBusquedaRutas.ImageAlign = ContentAlignment.MiddleLeft;
            btnBusquedaRutas.Location = new Point(12, 306);
            btnBusquedaRutas.Name = "btnBusquedaRutas";
            btnBusquedaRutas.Size = new Size(205, 45);
            btnBusquedaRutas.TabIndex = 7;
            btnBusquedaRutas.Text = "Búsqueda Rutas";
            btnBusquedaRutas.TextAlign = ContentAlignment.MiddleRight;
            btnBusquedaRutas.UseVisualStyleBackColor = false;
            btnBusquedaRutas.Click += btnBusquedaRutas_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 255);
            panel3.Name = "panel3";
            panel3.Size = new Size(12, 45);
            panel3.TabIndex = 6;
            // 
            // btnAltaRutas
            // 
            btnAltaRutas.BackColor = Color.FromArgb(20, 32, 40);
            btnAltaRutas.FlatAppearance.BorderSize = 0;
            btnAltaRutas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAltaRutas.FlatStyle = FlatStyle.Flat;
            btnAltaRutas.Font = new Font("Arial", 9.75F);
            btnAltaRutas.ForeColor = SystemColors.ControlLightLight;
            btnAltaRutas.Image = Properties.Resources.compras1;
            btnAltaRutas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAltaRutas.Location = new Point(12, 255);
            btnAltaRutas.Name = "btnAltaRutas";
            btnAltaRutas.Size = new Size(205, 45);
            btnAltaRutas.TabIndex = 5;
            btnAltaRutas.Text = "Alta Rutas";
            btnAltaRutas.TextAlign = ContentAlignment.MiddleRight;
            btnAltaRutas.UseVisualStyleBackColor = false;
            btnAltaRutas.Click += btnAltaRutas_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(0, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(12, 45);
            panel2.TabIndex = 4;
            // 
            // btnBusquedaEmpleados
            // 
            btnBusquedaEmpleados.BackColor = Color.FromArgb(20, 32, 40);
            btnBusquedaEmpleados.FlatAppearance.BorderSize = 0;
            btnBusquedaEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnBusquedaEmpleados.FlatStyle = FlatStyle.Flat;
            btnBusquedaEmpleados.Font = new Font("Arial", 9.75F);
            btnBusquedaEmpleados.ForeColor = SystemColors.ControlLightLight;
            btnBusquedaEmpleados.Image = Properties.Resources.clientes;
            btnBusquedaEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnBusquedaEmpleados.Location = new Point(12, 204);
            btnBusquedaEmpleados.Name = "btnBusquedaEmpleados";
            btnBusquedaEmpleados.RightToLeft = RightToLeft.No;
            btnBusquedaEmpleados.Size = new Size(205, 45);
            btnBusquedaEmpleados.TabIndex = 3;
            btnBusquedaEmpleados.Text = "Búsqueda Empleados";
            btnBusquedaEmpleados.TextAlign = ContentAlignment.MiddleRight;
            btnBusquedaEmpleados.UseVisualStyleBackColor = false;
            btnBusquedaEmpleados.Click += btnBusquedaEmpleados_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(0, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(12, 45);
            panel1.TabIndex = 2;
            // 
            // btnAltaEmpleados
            // 
            btnAltaEmpleados.BackColor = Color.FromArgb(20, 32, 40);
            btnAltaEmpleados.FlatAppearance.BorderSize = 0;
            btnAltaEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAltaEmpleados.FlatStyle = FlatStyle.Flat;
            btnAltaEmpleados.Font = new Font("Arial", 9.75F);
            btnAltaEmpleados.ForeColor = SystemColors.ControlLightLight;
            btnAltaEmpleados.Image = Properties.Resources.empleados;
            btnAltaEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnAltaEmpleados.Location = new Point(12, 153);
            btnAltaEmpleados.Name = "btnAltaEmpleados";
            btnAltaEmpleados.Size = new Size(205, 45);
            btnAltaEmpleados.TabIndex = 1;
            btnAltaEmpleados.Text = "Alta Empleados";
            btnAltaEmpleados.TextAlign = ContentAlignment.MiddleRight;
            btnAltaEmpleados.UseVisualStyleBackColor = false;
            btnAltaEmpleados.Click += btnAltaEmpleados_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Cormex__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(220, 37);
            panel7.Name = "panel7";
            panel7.Size = new Size(1080, 613);
            panel7.TabIndex = 2;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 66, 85);
            ClientSize = new Size(1300, 650);
            Controls.Add(panel7);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMenu_Load;
            KeyPress += FormMenu_KeyPress;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximisar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximisar;
        private PictureBox btnRestaurar;
        private Button btnAltaEmpleados;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Button btnBusquedaRutas;
        private Panel panel3;
        private Button btnAltaRutas;
        private Panel panel2;
        private Button btnBusquedaEmpleados;
        private Panel panel1;
        private Panel panel7;
    }
}
