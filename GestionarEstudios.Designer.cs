namespace Clinica_SePrice
{
    partial class frmGestionarEstudios
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
            dgvEstudios = new DataGridView();
            IdEstudio = new DataGridViewTextBoxColumn();
            TipoEstudio = new DataGridViewTextBoxColumn();
            NombrePaciente = new DataGridViewTextBoxColumn();
            ApellidoPaciente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewTextBoxColumn();
            btnVolverGestionarEstudios = new Button();
            btnAgregarEstudio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstudios).BeginInit();
            SuspendLayout();
            // 
            // dgvEstudios
            // 
            dgvEstudios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudios.Columns.AddRange(new DataGridViewColumn[] { IdEstudio, TipoEstudio, NombrePaciente, ApellidoPaciente, Fecha, Acciones });
            dgvEstudios.Location = new Point(12, 99);
            dgvEstudios.Name = "dgvEstudios";
            dgvEstudios.Size = new Size(725, 213);
            dgvEstudios.TabIndex = 0;
            // 
            // IdEstudio
            // 
            IdEstudio.HeaderText = "Id";
            IdEstudio.Name = "IdEstudio";
            // 
            // TipoEstudio
            // 
            TipoEstudio.HeaderText = "Tipo";
            TipoEstudio.Name = "TipoEstudio";
            TipoEstudio.Width = 120;
            // 
            // NombrePaciente
            // 
            NombrePaciente.HeaderText = "Nombre del paciente";
            NombrePaciente.Name = "NombrePaciente";
            NombrePaciente.Width = 130;
            // 
            // ApellidoPaciente
            // 
            ApellidoPaciente.HeaderText = "Apellido del paciente";
            ApellidoPaciente.Name = "ApellidoPaciente";
            ApellidoPaciente.Width = 130;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.Name = "Acciones";
            // 
            // btnVolverGestionarEstudios
            // 
            btnVolverGestionarEstudios.Location = new Point(12, 24);
            btnVolverGestionarEstudios.Name = "btnVolverGestionarEstudios";
            btnVolverGestionarEstudios.Size = new Size(75, 23);
            btnVolverGestionarEstudios.TabIndex = 1;
            btnVolverGestionarEstudios.Text = "Volver";
            btnVolverGestionarEstudios.UseVisualStyleBackColor = true;
            btnVolverGestionarEstudios.Click += btnVolverGestionarEstudios_Click;
            // 
            // btnAgregarEstudio
            // 
            btnAgregarEstudio.Location = new Point(611, 24);
            btnAgregarEstudio.Name = "btnAgregarEstudio";
            btnAgregarEstudio.Size = new Size(123, 23);
            btnAgregarEstudio.TabIndex = 2;
            btnAgregarEstudio.Text = "Agregar estudio";
            btnAgregarEstudio.UseVisualStyleBackColor = true;
            btnAgregarEstudio.Click += btnAgregarEstudio_Click;
            // 
            // frmGestionarEstudios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 324);
            Controls.Add(btnAgregarEstudio);
            Controls.Add(btnVolverGestionarEstudios);
            Controls.Add(dgvEstudios);
            Name = "frmGestionarEstudios";
            Text = "GestionarEstudios";
            ((System.ComponentModel.ISupportInitialize)dgvEstudios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstudios;
        private DataGridViewTextBoxColumn IdEstudio;
        private DataGridViewTextBoxColumn TipoEstudio;
        private DataGridViewTextBoxColumn NombrePaciente;
        private DataGridViewTextBoxColumn ApellidoPaciente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Acciones;
        private Button btnVolverGestionarEstudios;
        private Button btnAgregarEstudio;
    }
}