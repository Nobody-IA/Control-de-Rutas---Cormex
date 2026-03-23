namespace ControlRutasCormex.Forms
{
    partial class FormModRutas
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
            label5 = new Label();
            txtCapacidad = new TextBox();
            btnSalir = new Button();
            btnActualizar = new Button();
            label4 = new Label();
            cmbChofer = new ComboBox();
            label3 = new Label();
            cmbTipo = new ComboBox();
            txtNombreRuta = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbCiudad = new ComboBox();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar2).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(btnCerrar2);
            BarraTitulo.Controls.Add(Rutas);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(407, 37);
            BarraTitulo.TabIndex = 20;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnCerrar2
            // 
            btnCerrar2.Cursor = Cursors.Hand;
            btnCerrar2.Image = Properties.Resources.cerrar1;
            btnCerrar2.Location = new Point(376, 6);
            btnCerrar2.Name = "btnCerrar2";
            btnCerrar2.Size = new Size(25, 25);
            btnCerrar2.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar2.TabIndex = 7;
            btnCerrar2.TabStop = false;
            btnCerrar2.Click += btnCerrar2_Click;
            // 
            // Rutas
            // 
            Rutas.AutoSize = true;
            Rutas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Rutas.ForeColor = SystemColors.ControlLightLight;
            Rutas.Location = new Point(12, 10);
            Rutas.Name = "Rutas";
            Rutas.Size = new Size(123, 20);
            Rutas.TabIndex = 6;
            Rutas.Text = "Modificar Rutas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(18, 240);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 32;
            label5.Text = "Capacidad:";
            // 
            // txtCapacidad
            // 
            txtCapacidad.BackColor = SystemColors.InactiveBorder;
            txtCapacidad.BorderStyle = BorderStyle.None;
            txtCapacidad.Font = new Font("Consolas", 12F);
            txtCapacidad.Location = new Point(132, 240);
            txtCapacidad.MaxLength = 15;
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(74, 19);
            txtCapacidad.TabIndex = 31;
            txtCapacidad.KeyPress += txtCapacidad_KeyPress;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(0, 80, 200);
            btnSalir.FlatAppearance.BorderColor = Color.Red;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(212, 277);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 30;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(0, 80, 200);
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(131, 277);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 29;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(45, 201);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 28;
            label4.Text = "Chofer:";
            // 
            // cmbChofer
            // 
            cmbChofer.BackColor = SystemColors.InactiveBorder;
            cmbChofer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChofer.FlatStyle = FlatStyle.Flat;
            cmbChofer.Font = new Font("Consolas", 12F);
            cmbChofer.FormattingEnabled = true;
            cmbChofer.Location = new Point(132, 198);
            cmbChofer.Name = "cmbChofer";
            cmbChofer.Size = new Size(238, 27);
            cmbChofer.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(63, 164);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 26;
            label3.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = SystemColors.InactiveBorder;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.Font = new Font("Consolas", 12F);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(132, 156);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(155, 27);
            cmbTipo.TabIndex = 25;
            // 
            // txtNombreRuta
            // 
            txtNombreRuta.BackColor = SystemColors.InactiveBorder;
            txtNombreRuta.BorderStyle = BorderStyle.None;
            txtNombreRuta.Font = new Font("Consolas", 12F);
            txtNombreRuta.Location = new Point(132, 89);
            txtNombreRuta.MaxLength = 155;
            txtNombreRuta.Multiline = true;
            txtNombreRuta.Name = "txtNombreRuta";
            txtNombreRuta.Size = new Size(238, 61);
            txtNombreRuta.TabIndex = 24;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Consolas", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(38, 102);
            label2.Name = "label2";
            label2.Size = new Size(95, 40);
            label2.TabIndex = 23;
            label2.Text = "Nombre de la ruta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(51, 59);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 22;
            label1.Text = "Ciudad:";
            // 
            // cmbCiudad
            // 
            cmbCiudad.BackColor = SystemColors.InactiveBorder;
            cmbCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCiudad.FlatStyle = FlatStyle.Flat;
            cmbCiudad.Font = new Font("Consolas", 12F);
            cmbCiudad.FormattingEnabled = true;
            cmbCiudad.Location = new Point(132, 56);
            cmbCiudad.Name = "cmbCiudad";
            cmbCiudad.Size = new Size(238, 27);
            cmbCiudad.TabIndex = 21;
            // 
            // FormModRutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 66, 85);
            ClientSize = new Size(407, 333);
            Controls.Add(BarraTitulo);
            Controls.Add(label5);
            Controls.Add(txtCapacidad);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(label4);
            Controls.Add(cmbChofer);
            Controls.Add(label3);
            Controls.Add(cmbTipo);
            Controls.Add(txtNombreRuta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCiudad);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FormModRutas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormModRutas";
            Load += FormModRutas_Load;
            KeyDown += FormModRutas_KeyDown;
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar2;
        private Label Rutas;
        private Label label5;
        private TextBox txtCapacidad;
        private Button btnSalir;
        private Button btnActualizar;
        private Label label4;
        private ComboBox cmbChofer;
        private Label label3;
        private ComboBox cmbTipo;
        private TextBox txtNombreRuta;
        private Label label2;
        private Label label1;
        private ComboBox cmbCiudad;
    }
}