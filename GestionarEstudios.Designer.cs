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
            DniPaciente = new DataGridViewTextBoxColumn();
            NombrePaciente = new DataGridViewTextBoxColumn();
            ApellidoPaciente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewButtonColumn();
            btnVolverMenu = new Button();
            btnAgregarEstudio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstudios).BeginInit();
            SuspendLayout();
            // 
            // dgvEstudios
            // 
            dgvEstudios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudios.Columns.AddRange(new DataGridViewColumn[] { IdEstudio, TipoEstudio, DniPaciente, NombrePaciente, ApellidoPaciente, Fecha, Acciones });
            dgvEstudios.Location = new Point(12, 80);
            dgvEstudios.Name = "dgvEstudios";
            dgvEstudios.Size = new Size(852, 213);
            dgvEstudios.TabIndex = 0;
            dgvEstudios.CellContentClick += dgvEstudios_CellContentClick;
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
            // DniPaciente
            // 
            DniPaciente.HeaderText = "DNI del paciente";
            DniPaciente.Name = "DniPaciente";
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
            Acciones.Resizable = DataGridViewTriState.True;
            Acciones.SortMode = DataGridViewColumnSortMode.Automatic;
            Acciones.Width = 130;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(12, 24);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(111, 23);
            btnVolverMenu.TabIndex = 1;
            btnVolverMenu.Text = "Volver al menú";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // btnAgregarEstudio
            // 
            btnAgregarEstudio.Location = new Point(729, 24);
            btnAgregarEstudio.Name = "btnAgregarEstudio";
            btnAgregarEstudio.Size = new Size(135, 41);
            btnAgregarEstudio.TabIndex = 2;
            btnAgregarEstudio.Text = "Agregar estudio";
            btnAgregarEstudio.UseVisualStyleBackColor = true;
            btnAgregarEstudio.Click += btnAgregarEstudio_Click;
            // 
            // frmGestionarEstudios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 304);
            Controls.Add(btnAgregarEstudio);
            Controls.Add(btnVolverMenu);
            Controls.Add(dgvEstudios);
            Name = "frmGestionarEstudios";
            Text = "Gestionar Estudios";
            ((System.ComponentModel.ISupportInitialize)dgvEstudios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstudios;
        private Button btnVolverMenu;
        private Button btnAgregarEstudio;
        private DataGridViewTextBoxColumn IdEstudio;
        private DataGridViewTextBoxColumn TipoEstudio;
        private DataGridViewTextBoxColumn DniPaciente;
        private DataGridViewTextBoxColumn NombrePaciente;
        private DataGridViewTextBoxColumn ApellidoPaciente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewButtonColumn Acciones;
    }
}