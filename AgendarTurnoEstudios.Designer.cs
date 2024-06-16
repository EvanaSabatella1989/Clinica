namespace Clinica_SePrice
{
    partial class frmAgendarTurnoEstudios
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
            btnSolicitar = new Button();
            btnVolver = new Button();
            frmNuevoPaciente = new Button();
            txtDni = new TextBox();
            lblDni = new Label();
            lblTipoEstudio = new Label();
            cbTipoEstudio = new ComboBox();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            lblHorario = new Label();
            cbHorario = new ComboBox();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(205, 249);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(111, 40);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "Solicitar turno";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(80, 33);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmNuevoPaciente
            // 
            frmNuevoPaciente.Location = new Point(357, 12);
            frmNuevoPaciente.Name = "frmNuevoPaciente";
            frmNuevoPaciente.Size = new Size(153, 33);
            frmNuevoPaciente.TabIndex = 2;
            frmNuevoPaciente.Text = "Registrar Nuevo Paciente";
            frmNuevoPaciente.UseVisualStyleBackColor = true;
            frmNuevoPaciente.Click += frmNuevoPaciente_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(238, 76);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(152, 23);
            txtDni.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(116, 79);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(94, 15);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI del paciente";
            // 
            // lblTipoEstudio
            // 
            lblTipoEstudio.AutoSize = true;
            lblTipoEstudio.Location = new Point(122, 121);
            lblTipoEstudio.Name = "lblTipoEstudio";
            lblTipoEstudio.Size = new Size(88, 15);
            lblTipoEstudio.TabIndex = 5;
            lblTipoEstudio.Text = "Tipo de Estudio";
            // 
            // cbTipoEstudio
            // 
            cbTipoEstudio.FormattingEnabled = true;
            cbTipoEstudio.Items.AddRange(new object[] { "Ecografía", "Electrocardiograma", "Radiografía", "Tomografía" });
            cbTipoEstudio.Location = new Point(238, 118);
            cbTipoEstudio.Name = "cbTipoEstudio";
            cbTipoEstudio.Size = new Size(152, 23);
            cbTipoEstudio.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(238, 158);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(234, 23);
            dtpFecha.TabIndex = 7;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(172, 164);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(163, 210);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(47, 15);
            lblHorario.TabIndex = 9;
            lblHorario.Text = "Horario";
            // 
            // cbHorario
            // 
            cbHorario.FormattingEnabled = true;
            cbHorario.Location = new Point(238, 207);
            cbHorario.Name = "cbHorario";
            cbHorario.Size = new Size(152, 23);
            cbHorario.TabIndex = 10;
            // 
            // frmAgendarTurnoEstudios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 301);
            Controls.Add(cbHorario);
            Controls.Add(lblHorario);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(cbTipoEstudio);
            Controls.Add(lblTipoEstudio);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Controls.Add(frmNuevoPaciente);
            Controls.Add(btnVolver);
            Controls.Add(btnSolicitar);
            Name = "frmAgendarTurnoEstudios";
            Text = "Agendar Turno Estudio Clínico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitar;
        private Button btnVolver;
        private Button frmNuevoPaciente;
        private TextBox txtDni;
        private Label lblDni;
        private Label lblTipoEstudio;
        private ComboBox cbTipoEstudio;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label lblHorario;
        private ComboBox cbHorario;
    }
}