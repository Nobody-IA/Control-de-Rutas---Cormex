namespace ControlRutasCormex.Forms
{
    partial class formAltaEmpleado
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
            Choferes = new Label();
            btnCerrar = new PictureBox();
            cmbCiudad = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtApPaterno = new TextBox();
            label3 = new Label();
            txtApMaterno = new TextBox();
            label4 = new Label();
            txtSueldo = new TextBox();
            label5 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label6 = new Label();
            btnGuardar = new Button();
            btnSalir = new Button();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(Choferes);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(363, 37);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // Choferes
            // 
            Choferes.AutoSize = true;
            Choferes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Choferes.ForeColor = SystemColors.ControlLightLight;
            Choferes.Location = new Point(12, 10);
            Choferes.Name = "Choferes";
            Choferes.Size = new Size(107, 20);
            Choferes.TabIndex = 6;
            Choferes.Text = "Alta Choferes";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.cerrar1;
            btnCerrar.Location = new Point(335, 6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cmbCiudad
            // 
            cmbCiudad.BackColor = SystemColors.InactiveBorder;
            cmbCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCiudad.FlatStyle = FlatStyle.Flat;
            cmbCiudad.Font = new Font("Consolas", 12F);
            cmbCiudad.FormattingEnabled = true;
            cmbCiudad.Location = new Point(108, 54);
            cmbCiudad.Name = "cmbCiudad";
            cmbCiudad.Size = new Size(155, 27);
            cmbCiudad.TabIndex = 2;
            cmbCiudad.SelectedIndexChanged += cmbCiudad_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(30, 57);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 3;
            label1.Text = "Ciudad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(30, 96);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveBorder;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Consolas", 12F);
            txtNombre.Location = new Point(108, 96);
            txtNombre.MaxLength = 15;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 19);
            txtNombre.TabIndex = 5;
            // 
            // txtApPaterno
            // 
            txtApPaterno.BackColor = SystemColors.InactiveBorder;
            txtApPaterno.BorderStyle = BorderStyle.None;
            txtApPaterno.Font = new Font("Consolas", 12F);
            txtApPaterno.Location = new Point(159, 124);
            txtApPaterno.MaxLength = 15;
            txtApPaterno.Name = "txtApPaterno";
            txtApPaterno.Size = new Size(175, 19);
            txtApPaterno.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(30, 124);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 6;
            label3.Text = "Ap. Paterno:";
            // 
            // txtApMaterno
            // 
            txtApMaterno.BackColor = SystemColors.InactiveBorder;
            txtApMaterno.BorderStyle = BorderStyle.None;
            txtApMaterno.Font = new Font("Consolas", 12F);
            txtApMaterno.Location = new Point(159, 152);
            txtApMaterno.MaxLength = 15;
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(175, 19);
            txtApMaterno.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(30, 152);
            label4.Name = "label4";
            label4.Size = new Size(117, 19);
            label4.TabIndex = 8;
            label4.Text = "Ap. Materno:";
            // 
            // txtSueldo
            // 
            txtSueldo.BackColor = SystemColors.InactiveBorder;
            txtSueldo.BorderStyle = BorderStyle.None;
            txtSueldo.Font = new Font("Consolas", 12F);
            txtSueldo.Location = new Point(141, 180);
            txtSueldo.MaxLength = 15;
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(91, 19);
            txtSueldo.TabIndex = 11;
            txtSueldo.KeyPress += txtSueldo_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(30, 180);
            label5.Name = "label5";
            label5.Size = new Size(108, 19);
            label5.TabIndex = 10;
            label5.Text = "Sueldo:   $";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "yyyy-MM-dd";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(222, 205);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(122, 23);
            dtpFechaNacimiento.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(27, 208);
            label6.Name = "label6";
            label6.Size = new Size(189, 19);
            label6.TabIndex = 13;
            label6.Text = "Fecha de nacimiento:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(93, 254);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(0, 80, 200);
            btnSalir.FlatAppearance.BorderColor = Color.Red;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(174, 254);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // formAltaEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 66, 85);
            ClientSize = new Size(363, 305);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtSueldo);
            Controls.Add(label5);
            Controls.Add(txtApMaterno);
            Controls.Add(label4);
            Controls.Add(txtApPaterno);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCiudad);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "formAltaEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formAltaEmpleado";
            Load += formAltaEmpleado_Load;
            KeyDown += formAltaEmpleado_KeyDown;
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox btnCerrar;
        private Label Choferes;
        private ComboBox cmbCiudad;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtApPaterno;
        private Label label3;
        private TextBox txtApMaterno;
        private Label label4;
        private TextBox txtSueldo;
        private Label label5;
        private DateTimePicker dtpFechaNacimiento;
        private Label label6;
        private Button btnGuardar;
        private Button btnSalir;
    }
}