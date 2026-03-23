namespace ControlRutasCormex.Forms
{
    partial class formBusquedaEmpleados
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BarraTitulo = new Panel();
            btpSalir = new PictureBox();
            pictureBox1 = new PictureBox();
            btnCerrar2 = new PictureBox();
            BusquedaEmpleados = new Label();
            btnCerrar = new PictureBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtFiltroNombre = new TextBox();
            cmbCiudad = new ComboBox();
            dgvEmpleados = new DataGridView();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btpSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(btpSalir);
            BarraTitulo.Controls.Add(pictureBox1);
            BarraTitulo.Controls.Add(btnCerrar2);
            BarraTitulo.Controls.Add(BusquedaEmpleados);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(950, 37);
            BarraTitulo.TabIndex = 6;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btpSalir
            // 
            btpSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btpSalir.Cursor = Cursors.Hand;
            btpSalir.Image = Properties.Resources.cerrar1;
            btpSalir.Location = new Point(921, 5);
            btpSalir.Name = "btpSalir";
            btpSalir.Size = new Size(25, 25);
            btpSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btpSalir.TabIndex = 9;
            btpSalir.TabStop = false;
            btpSalir.Click += btpSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.cerrar1;
            pictureBox1.Location = new Point(1672, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnCerrar2
            // 
            btnCerrar2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar2.Cursor = Cursors.Hand;
            btnCerrar2.Image = Properties.Resources.cerrar1;
            btnCerrar2.Location = new Point(1992, 5);
            btnCerrar2.Name = "btnCerrar2";
            btnCerrar2.Size = new Size(25, 25);
            btnCerrar2.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar2.TabIndex = 7;
            btnCerrar2.TabStop = false;
            // 
            // BusquedaEmpleados
            // 
            BusquedaEmpleados.AutoSize = true;
            BusquedaEmpleados.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BusquedaEmpleados.ForeColor = SystemColors.ControlLightLight;
            BusquedaEmpleados.Location = new Point(12, 10);
            BusquedaEmpleados.Name = "BusquedaEmpleados";
            BusquedaEmpleados.Size = new Size(184, 20);
            BusquedaEmpleados.TabIndex = 6;
            BusquedaEmpleados.Text = "Busqueda De Empleados";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.cerrar1;
            btnCerrar.Location = new Point(2312, 6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFiltroNombre);
            groupBox1.Controls.Add(cmbCiudad);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 417);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos De Busqueda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(126, 19);
            label2.TabIndex = 6;
            label2.Text = "Filltro Ruta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 5;
            label1.Text = "Ciudad:";
            // 
            // txtFiltroNombre
            // 
            txtFiltroNombre.Location = new Point(6, 94);
            txtFiltroNombre.Multiline = true;
            txtFiltroNombre.Name = "txtFiltroNombre";
            txtFiltroNombre.Size = new Size(239, 47);
            txtFiltroNombre.TabIndex = 4;
            txtFiltroNombre.TextChanged += txtFiltroNombre_TextChanged;
            // 
            // cmbCiudad
            // 
            cmbCiudad.BackColor = SystemColors.InactiveBorder;
            cmbCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCiudad.FlatStyle = FlatStyle.Flat;
            cmbCiudad.Font = new Font("Consolas", 12F);
            cmbCiudad.FormattingEnabled = true;
            cmbCiudad.Location = new Point(84, 22);
            cmbCiudad.Name = "cmbCiudad";
            cmbCiudad.Size = new Size(155, 27);
            cmbCiudad.TabIndex = 3;
            cmbCiudad.SelectedIndexChanged += cmbCiudad_SelectedIndexChanged;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = Color.FromArgb(50, 66, 85);
            dgvEmpleados.BorderStyle = BorderStyle.None;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 80, 200);
            dataGridViewCellStyle1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.ColumnHeadersHeight = 30;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.GridColor = Color.SteelBlue;
            dgvEmpleados.Location = new Point(291, 56);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 66, 85);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 66, 85);
            dataGridViewCellStyle3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleados.Size = new Size(631, 417);
            dgvEmpleados.TabIndex = 8;
            dgvEmpleados.DataSourceChanged += dgvEmpleados_DataSourceChanged;
            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            // 
            // formBusquedaEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 541);
            Controls.Add(BarraTitulo);
            Controls.Add(groupBox1);
            Controls.Add(dgvEmpleados);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "formBusquedaEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formBusquedaEmpleados";
            Load += formBusquedaEmpleados_Load;
            KeyDown += formBusquedaEmpleados_KeyDown;
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btpSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private PictureBox pictureBox1;
        private PictureBox btnCerrar2;
        private Label BusquedaEmpleados;
        private PictureBox btnCerrar;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtFiltroNombre;
        private ComboBox cmbCiudad;
        private DataGridView dgvEmpleados;
        private PictureBox btpSalir;
    }
}