namespace ControlRutasCormex.Forms
{
    partial class FormModEmpleados
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
            btnSalir = new Button();
            btnGuardar = new Button();
            label6 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtSueldo = new TextBox();
            label5 = new Label();
            txtApMaterno = new TextBox();
            label4 = new Label();
            txtApPaterno = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbCiudad = new ComboBox();
            Choferes = new Label();
            btnCerrar = new PictureBox();
            txtNombre = new TextBox();
            BarraTitulo = new Panel();
            btnSalir2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir2).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(0, 80, 200);
            btnSalir.FlatAppearance.BorderColor = Color.Red;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(173, 253);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 30;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(92, 253);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Actualizar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(12, 210);
            label6.Name = "label6";
            label6.Size = new Size(189, 19);
            label6.TabIndex = 28;
            label6.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "yyyy-MM-dd";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(207, 207);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(122, 23);
            dtpFechaNacimiento.TabIndex = 27;
            // 
            // txtSueldo
            // 
            txtSueldo.BackColor = SystemColors.InactiveBorder;
            txtSueldo.BorderStyle = BorderStyle.None;
            txtSueldo.Font = new Font("Consolas", 12F);
            txtSueldo.Location = new Point(126, 182);
            txtSueldo.MaxLength = 15;
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(91, 19);
            txtSueldo.TabIndex = 26;
            txtSueldo.KeyPress += txtSueldo_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(15, 182);
            label5.Name = "label5";
            label5.Size = new Size(108, 19);
            label5.TabIndex = 25;
            label5.Text = "Sueldo:   $";
            // 
            // txtApMaterno
            // 
            txtApMaterno.BackColor = SystemColors.InactiveBorder;
            txtApMaterno.BorderStyle = BorderStyle.None;
            txtApMaterno.Font = new Font("Consolas", 12F);
            txtApMaterno.Location = new Point(144, 154);
            txtApMaterno.MaxLength = 15;
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(175, 19);
            txtApMaterno.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(15, 154);
            label4.Name = "label4";
            label4.Size = new Size(117, 19);
            label4.TabIndex = 23;
            label4.Text = "Ap. Materno:";
            // 
            // txtApPaterno
            // 
            txtApPaterno.BackColor = SystemColors.InactiveBorder;
            txtApPaterno.BorderStyle = BorderStyle.None;
            txtApPaterno.Font = new Font("Consolas", 12F);
            txtApPaterno.Location = new Point(144, 126);
            txtApPaterno.MaxLength = 15;
            txtApPaterno.Name = "txtApPaterno";
            txtApPaterno.Size = new Size(175, 19);
            txtApPaterno.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(15, 126);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 21;
            label3.Text = "Ap. Paterno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(15, 98);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 19;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(15, 59);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 18;
            label1.Text = "Ciudad:";
            // 
            // cmbCiudad
            // 
            cmbCiudad.BackColor = SystemColors.InactiveBorder;
            cmbCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCiudad.FlatStyle = FlatStyle.Flat;
            cmbCiudad.Font = new Font("Consolas", 12F);
            cmbCiudad.FormattingEnabled = true;
            cmbCiudad.Location = new Point(93, 56);
            cmbCiudad.Name = "cmbCiudad";
            cmbCiudad.Size = new Size(155, 27);
            cmbCiudad.TabIndex = 17;
            // 
            // Choferes
            // 
            Choferes.AutoSize = true;
            Choferes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Choferes.ForeColor = SystemColors.ControlLightLight;
            Choferes.Location = new Point(12, 10);
            Choferes.Name = "Choferes";
            Choferes.Size = new Size(160, 20);
            Choferes.TabIndex = 6;
            Choferes.Text = "Modificar Empleados";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.cerrar1;
            btnCerrar.Location = new Point(575, 6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveBorder;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Consolas", 12F);
            txtNombre.Location = new Point(93, 98);
            txtNombre.MaxLength = 15;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 19);
            txtNombre.TabIndex = 20;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(btnSalir2);
            BarraTitulo.Controls.Add(Choferes);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(363, 37);
            BarraTitulo.TabIndex = 16;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnSalir2
            // 
            btnSalir2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir2.Cursor = Cursors.Hand;
            btnSalir2.Image = Properties.Resources.cerrar1;
            btnSalir2.Location = new Point(331, 6);
            btnSalir2.Name = "btnSalir2";
            btnSalir2.Size = new Size(25, 25);
            btnSalir2.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir2.TabIndex = 7;
            btnSalir2.TabStop = false;
            btnSalir2.Click += btnSalir2_Click;
            // 
            // FormModEmpleados
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCiudad);
            Controls.Add(txtNombre);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModEmpleados";
            Text = "FormModEmpleados";
            Load += FormModEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnGuardar;
        private Label label6;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtSueldo;
        private Label label5;
        private TextBox txtApMaterno;
        private Label label4;
        private TextBox txtApPaterno;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbCiudad;
        private Label Choferes;
        private PictureBox btnCerrar;
        private TextBox txtNombre;
        private Panel BarraTitulo;
        private PictureBox btnSalir2;
    }
}