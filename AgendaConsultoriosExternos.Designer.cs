namespace Clinica_SePrice
{
    partial class frmAgendaConsultoriosExternos
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
            btnAtras = new Button();
            dgvAgendaConsultorios = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colHorario = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colMedico = new DataGridViewTextBoxColumn();
            colEspecialidad = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAgendaConsultorios).BeginInit();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(835, 12);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(166, 36);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "Solicitar un turno";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(84, 36);
            btnAtras.TabIndex = 3;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // dgvAgendaConsultorios
            // 
            dgvAgendaConsultorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgendaConsultorios.Columns.AddRange(new DataGridViewColumn[] { colId, colFecha, colHorario, colDni, colNombre, colApellido, colMedico, colEspecialidad, colAcciones });
            dgvAgendaConsultorios.Location = new Point(12, 65);
            dgvAgendaConsultorios.Name = "dgvAgendaConsultorios";
            dgvAgendaConsultorios.Size = new Size(989, 227);
            dgvAgendaConsultorios.TabIndex = 4;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.Width = 70;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.Width = 70;
            // 
            // colHorario
            // 
            colHorario.HeaderText = "Horario";
            colHorario.Name = "colHorario";
            colHorario.Width = 70;
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.Name = "colDni";
            colDni.Width = 70;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.Width = 140;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.Name = "colApellido";
            colApellido.Width = 140;
            // 
            // colMedico
            // 
            colMedico.HeaderText = "Médico";
            colMedico.Name = "colMedico";
            colMedico.Width = 140;
            // 
            // colEspecialidad
            // 
            colEspecialidad.HeaderText = "Especialidad";
            colEspecialidad.Name = "colEspecialidad";
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "Acciones";
            colAcciones.Name = "colAcciones";
            colAcciones.Resizable = DataGridViewTriState.True;
            colAcciones.SortMode = DataGridViewColumnSortMode.Automatic;
            colAcciones.Width = 150;
            // 
            // frmAgendaConsultoriosExternos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 298);
            Controls.Add(dgvAgendaConsultorios);
            Controls.Add(btnAtras);
            Controls.Add(btnSolicitar);
            Name = "frmAgendaConsultoriosExternos";
            Text = "Agenda Consultorios Externos";
            ((System.ComponentModel.ISupportInitialize)dgvAgendaConsultorios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSolicitar;
        private Button btnAtras;
        private DataGridView dgvAgendaConsultorios;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colHorario;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colMedico;
        private DataGridViewTextBoxColumn colEspecialidad;
        private DataGridViewButtonColumn colAcciones;
    }
}