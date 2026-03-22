namespace ControlRutasCormex.Forms
{
    partial class FormAltaRutas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BarraTitulo = new Panel();
            btnCerrar2 = new PictureBox();
            Rutas = new Label();
            btnCerrar = new PictureBox();
            cmbCiudad = new ComboBox();
            label1 = new Label();
            txtNombreRuta = new TextBox();
            label2 = new Label();
            cmbTipo = new ComboBox();
            label3 = new Label();
            cmbChofer = new ComboBox();
            label4 = new Label();
            btnSalir = new Button();
            btnGuardar = new Button();
            txtCapacidad = new TextBox();
            label5 = new Label();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(btnCerrar2);
            BarraTitulo.Controls.Add(Rutas);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(520, 37);
            BarraTitulo.TabIndex = 2;
            // 
            // btnCerrar2
            // 
            btnCerrar2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar2.Cursor = Cursors.Hand;
            btnCerrar2.Image = Properties.Resources.cerrar1;
            btnCerrar2.Location = new Point(492, 5);
            btnCerrar2.Name = "btnCerrar2";
            btnCerrar2.Size = new Size(25, 25);
            btnCerrar2.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar2.TabIndex = 7;
            btnCerrar2.TabStop = false;
            // 
            // Rutas
            // 
            Rutas.AutoSize = true;
            Rutas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Rutas.ForeColor = SystemColors.ControlLightLight;
            Rutas.Location = new Point(12, 10);
            Rutas.Name = "Rutas";
            Rutas.Size = new Size(85, 20);
            Rutas.TabIndex = 6;
            Rutas.Text = "Alta Rutas";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.cerrar1;
            btnCerrar.Location = new Point(812, 6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            // 
            // cmbCiudad
            // 
            cmbCiudad.BackColor = SystemColors.InactiveBorder;
            cmbCiudad.FlatStyle = FlatStyle.Flat;
            cmbCiudad.Font = new Font("Consolas", 12F);
            cmbCiudad.FormattingEnabled = true;
            cmbCiudad.Location = new Point(184, 82);
            cmbCiudad.Name = "cmbCiudad";
            cmbCiudad.Size = new Size(155, 27);
            cmbCiudad.TabIndex = 3;
            cmbCiudad.Text = "Seleccione";
            cmbCiudad.SelectedIndexChanged += cmbCiudad_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(103, 85);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 4;
            label1.Text = "Ciudad:";
            // 
            // txtNombreRuta
            // 
            txtNombreRuta.BackColor = SystemColors.InactiveBorder;
            txtNombreRuta.BorderStyle = BorderStyle.None;
            txtNombreRuta.Font = new Font("Consolas", 12F);
            txtNombreRuta.Location = new Point(184, 149);
            txtNombreRuta.MaxLength = 155;
            txtNombreRuta.Name = "txtNombreRuta";
            txtNombreRuta.Size = new Size(155, 19);
            txtNombreRuta.TabIndex = 7;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Consolas", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(90, 128);
            label2.Name = "label2";
            label2.Size = new Size(95, 40);
            label2.TabIndex = 6;
            label2.Text = "Nombre de la ruta:";
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = SystemColors.InactiveBorder;
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.Font = new Font("Consolas", 12F);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(184, 182);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(155, 27);
            cmbTipo.TabIndex = 8;
            cmbTipo.Text = "Seleccione";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(115, 190);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 9;
            label3.Text = "Tipo:";
            // 
            // cmbChofer
            // 
            cmbChofer.BackColor = SystemColors.InactiveBorder;
            cmbChofer.FlatStyle = FlatStyle.Flat;
            cmbChofer.Font = new Font("Consolas", 12F);
            cmbChofer.FormattingEnabled = true;
            cmbChofer.Location = new Point(184, 224);
            cmbChofer.Name = "cmbChofer";
            cmbChofer.Size = new Size(155, 27);
            cmbChofer.TabIndex = 10;
            cmbChofer.Text = "Seleccione";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(97, 227);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 11;
            label4.Text = "Chofer:";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(0, 80, 200);
            btnSalir.FlatAppearance.BorderColor = Color.Red;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(264, 303);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(183, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCapacidad
            // 
            txtCapacidad.BackColor = SystemColors.InactiveBorder;
            txtCapacidad.BorderStyle = BorderStyle.None;
            txtCapacidad.Font = new Font("Consolas", 12F);
            txtCapacidad.Location = new Point(184, 266);
            txtCapacidad.MaxLength = 15;
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(74, 19);
            txtCapacidad.TabIndex = 18;
            txtCapacidad.KeyPress += txtCapacidad_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(70, 266);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 19;
            label5.Text = "Capacidad:";
            // 
            // FormAltaRutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 66, 85);
            ClientSize = new Size(520, 382);
            Controls.Add(label5);
            Controls.Add(txtCapacidad);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(cmbChofer);
            Controls.Add(label3);
            Controls.Add(cmbTipo);
            Controls.Add(txtNombreRuta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCiudad);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAltaRutas";
            Text = "FormAltaRutas";
            Load += FormAltaRutas_Load;
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitulo;
        private Label Rutas;
        private PictureBox btnCerrar;
        private PictureBox btnCerrar2;
        private ComboBox cmbCiudad;
        private Label label1;
        private TextBox txtNombreRuta;
        private Label label2;
        private ComboBox cmbTipo;
        private Label label3;
        private ComboBox cmbChofer;
        private Label label4;
        private Button btnSalir;
        private Button btnGuardar;
        private TextBox txtCapacidad;
        private Label label5;
    }
}