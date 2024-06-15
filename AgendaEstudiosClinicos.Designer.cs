namespace Clinica_SePrice
{
    partial class frmAgendaEstudiosClinicos
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
            frmNuevoPaciente = new Button();
            btnPacientePrioritario = new Button();
            btnVolverMenu = new Button();
            tabTomografia = new TabPage();
            dgvTomografia = new DataGridView();
            tabRadiografia = new TabPage();
            dgvRadiografia = new DataGridView();
            tabElectrocardiograma = new TabPage();
            dgvElectrocardiograma = new DataGridView();
            tabEcografia = new TabPage();
            dgvEcografia = new DataGridView();
            colAccionesEcografia = new DataGridViewButtonColumn();
            colFechaEcografia = new DataGridViewTextBoxColumn();
            colApellidoEcografia = new DataGridViewTextBoxColumn();
            colNombreEcografia = new DataGridViewTextBoxColumn();
            colDniEcografia = new DataGridViewTextBoxColumn();
            colHorarioEcografia = new DataGridViewTextBoxColumn();
            colIdEcografia = new DataGridViewTextBoxColumn();
            tabLaboratorio = new TabPage();
            dgvLaboratorio = new DataGridView();
            colAccionesLaboratorio = new DataGridViewButtonColumn();
            colApellidoLaboratorio = new DataGridViewTextBoxColumn();
            colNombreLaboratorio = new DataGridViewTextBoxColumn();
            colDniLaboratorio = new DataGridViewTextBoxColumn();
            colHorarioLaboratorio = new DataGridViewTextBoxColumn();
            colIdLaboratorio = new DataGridViewTextBoxColumn();
            btnAgregarPacienteLaboratorio = new Button();
            tbEstudios = new TabControl();
            colIdElectrocardiograma = new DataGridViewTextBoxColumn();
            colHorarioElectrocardiograma = new DataGridViewTextBoxColumn();
            colDniElectrocardiograma = new DataGridViewTextBoxColumn();
            colNombreElectrocardiograma = new DataGridViewTextBoxColumn();
            colApellidoElectrocardiograma = new DataGridViewTextBoxColumn();
            colFechaElectrocardiograma = new DataGridViewTextBoxColumn();
            colAccionesElectrocardiograma = new DataGridViewButtonColumn();
            colIdRadiografia = new DataGridViewTextBoxColumn();
            colHorarioRadiografia = new DataGridViewTextBoxColumn();
            colDniRadiografia = new DataGridViewTextBoxColumn();
            colNombreRadiografia = new DataGridViewTextBoxColumn();
            colApellidoRadiografia = new DataGridViewTextBoxColumn();
            colFechaRadiografia = new DataGridViewTextBoxColumn();
            colAccionesRadiografia = new DataGridViewButtonColumn();
            colIdTomografia = new DataGridViewTextBoxColumn();
            colHorarioTomografia = new DataGridViewTextBoxColumn();
            colDniTomografia = new DataGridViewTextBoxColumn();
            colNombreTomografia = new DataGridViewTextBoxColumn();
            colApellidoTomografia = new DataGridViewTextBoxColumn();
            colFechaTomografia = new DataGridViewTextBoxColumn();
            colAcreditarTomografia = new DataGridViewButtonColumn();
            tabTomografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTomografia).BeginInit();
            tabRadiografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRadiografia).BeginInit();
            tabElectrocardiograma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvElectrocardiograma).BeginInit();
            tabEcografia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEcografia).BeginInit();
            tabLaboratorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorio).BeginInit();
            tbEstudios.SuspendLayout();
            SuspendLayout();
            // 
            // frmNuevoPaciente
            // 
            frmNuevoPaciente.Location = new Point(716, 12);
            frmNuevoPaciente.Name = "frmNuevoPaciente";
            frmNuevoPaciente.Size = new Size(171, 23);
            frmNuevoPaciente.TabIndex = 1;
            frmNuevoPaciente.Text = "Registrar Nuevo Paciente";
            frmNuevoPaciente.UseVisualStyleBackColor = true;
            frmNuevoPaciente.Click += frmNuevoPaciente_Click;
            // 
            // btnPacientePrioritario
            // 
            btnPacientePrioritario.Location = new Point(545, 12);
            btnPacientePrioritario.Name = "btnPacientePrioritario";
            btnPacientePrioritario.Size = new Size(165, 23);
            btnPacientePrioritario.TabIndex = 2;
            btnPacientePrioritario.Text = "Agregar Paciente Prioritario";
            btnPacientePrioritario.UseVisualStyleBackColor = true;
            btnPacientePrioritario.Click += btnPacientePrioritario_Click;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(16, 12);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(103, 23);
            btnVolverMenu.TabIndex = 3;
            btnVolverMenu.Text = "Volver al menú";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // tabTomografia
            // 
            tabTomografia.Controls.Add(dgvTomografia);
            tabTomografia.Location = new Point(4, 24);
            tabTomografia.Name = "tabTomografia";
            tabTomografia.Size = new Size(874, 264);
            tabTomografia.TabIndex = 4;
            tabTomografia.Text = "Tomografía";
            tabTomografia.UseVisualStyleBackColor = true;
            // 
            // dgvTomografia
            // 
            dgvTomografia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTomografia.Columns.AddRange(new DataGridViewColumn[] { colIdTomografia, colHorarioTomografia, colDniTomografia, colNombreTomografia, colApellidoTomografia, colFechaTomografia, colAcreditarTomografia });
            dgvTomografia.Location = new Point(6, 6);
            dgvTomografia.Name = "dgvTomografia";
            dgvTomografia.Size = new Size(865, 255);
            dgvTomografia.TabIndex = 0;
            // 
            // tabRadiografia
            // 
            tabRadiografia.Controls.Add(dgvRadiografia);
            tabRadiografia.Location = new Point(4, 24);
            tabRadiografia.Name = "tabRadiografia";
            tabRadiografia.Padding = new Padding(3);
            tabRadiografia.Size = new Size(874, 264);
            tabRadiografia.TabIndex = 3;
            tabRadiografia.Text = "Radiografía";
            tabRadiografia.UseVisualStyleBackColor = true;
            // 
            // dgvRadiografia
            // 
            dgvRadiografia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRadiografia.Columns.AddRange(new DataGridViewColumn[] { colIdRadiografia, colHorarioRadiografia, colDniRadiografia, colNombreRadiografia, colApellidoRadiografia, colFechaRadiografia, colAccionesRadiografia });
            dgvRadiografia.Location = new Point(6, 6);
            dgvRadiografia.Name = "dgvRadiografia";
            dgvRadiografia.Size = new Size(865, 255);
            dgvRadiografia.TabIndex = 0;
            // 
            // tabElectrocardiograma
            // 
            tabElectrocardiograma.Controls.Add(dgvElectrocardiograma);
            tabElectrocardiograma.Location = new Point(4, 24);
            tabElectrocardiograma.Name = "tabElectrocardiograma";
            tabElectrocardiograma.Padding = new Padding(3);
            tabElectrocardiograma.Size = new Size(874, 264);
            tabElectrocardiograma.TabIndex = 2;
            tabElectrocardiograma.Text = "Electrocardiograma";
            tabElectrocardiograma.UseVisualStyleBackColor = true;
            // 
            // dgvElectrocardiograma
            // 
            dgvElectrocardiograma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElectrocardiograma.Columns.AddRange(new DataGridViewColumn[] { colIdElectrocardiograma, colHorarioElectrocardiograma, colDniElectrocardiograma, colNombreElectrocardiograma, colApellidoElectrocardiograma, colFechaElectrocardiograma, colAccionesElectrocardiograma });
            dgvElectrocardiograma.Location = new Point(6, 6);
            dgvElectrocardiograma.Name = "dgvElectrocardiograma";
            dgvElectrocardiograma.Size = new Size(865, 255);
            dgvElectrocardiograma.TabIndex = 0;
            // 
            // tabEcografia
            // 
            tabEcografia.Controls.Add(dgvEcografia);
            tabEcografia.Location = new Point(4, 24);
            tabEcografia.Name = "tabEcografia";
            tabEcografia.Padding = new Padding(3);
            tabEcografia.Size = new Size(874, 264);
            tabEcografia.TabIndex = 1;
            tabEcografia.Text = "Ecografía";
            tabEcografia.UseVisualStyleBackColor = true;
            // 
            // dgvEcografia
            // 
            dgvEcografia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEcografia.Columns.AddRange(new DataGridViewColumn[] { colIdEcografia, colHorarioEcografia, colDniEcografia, colNombreEcografia, colApellidoEcografia, colFechaEcografia, colAccionesEcografia });
            dgvEcografia.Location = new Point(6, 6);
            dgvEcografia.Name = "dgvEcografia";
            dgvEcografia.Size = new Size(865, 255);
            dgvEcografia.TabIndex = 0;
            // 
            // colAccionesEcografia
            // 
            colAccionesEcografia.HeaderText = "Acciones";
            colAccionesEcografia.Name = "colAccionesEcografia";
            colAccionesEcografia.Resizable = DataGridViewTriState.True;
            colAccionesEcografia.SortMode = DataGridViewColumnSortMode.Automatic;
            colAccionesEcografia.Width = 150;
            // 
            // colFechaEcografia
            // 
            colFechaEcografia.HeaderText = "Fecha";
            colFechaEcografia.Name = "colFechaEcografia";
            // 
            // colApellidoEcografia
            // 
            colApellidoEcografia.HeaderText = "Apellido";
            colApellidoEcografia.Name = "colApellidoEcografia";
            colApellidoEcografia.Width = 180;
            // 
            // colNombreEcografia
            // 
            colNombreEcografia.HeaderText = "Nombre";
            colNombreEcografia.Name = "colNombreEcografia";
            colNombreEcografia.Width = 180;
            // 
            // colDniEcografia
            // 
            colDniEcografia.HeaderText = "DNI";
            colDniEcografia.Name = "colDniEcografia";
            colDniEcografia.Width = 80;
            // 
            // colHorarioEcografia
            // 
            colHorarioEcografia.HeaderText = "Horario";
            colHorarioEcografia.Name = "colHorarioEcografia";
            colHorarioEcografia.Width = 70;
            // 
            // colIdEcografia
            // 
            colIdEcografia.HeaderText = "Id";
            colIdEcografia.Name = "colIdEcografia";
            colIdEcografia.Width = 70;
            // 
            // tabLaboratorio
            // 
            tabLaboratorio.Controls.Add(btnAgregarPacienteLaboratorio);
            tabLaboratorio.Controls.Add(dgvLaboratorio);
            tabLaboratorio.Location = new Point(4, 24);
            tabLaboratorio.Name = "tabLaboratorio";
            tabLaboratorio.Padding = new Padding(3);
            tabLaboratorio.Size = new Size(874, 264);
            tabLaboratorio.TabIndex = 0;
            tabLaboratorio.Tag = "";
            tabLaboratorio.Text = "Laboratorio";
            tabLaboratorio.UseVisualStyleBackColor = true;
            // 
            // dgvLaboratorio
            // 
            dgvLaboratorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaboratorio.Columns.AddRange(new DataGridViewColumn[] { colIdLaboratorio, colHorarioLaboratorio, colDniLaboratorio, colNombreLaboratorio, colApellidoLaboratorio, colAccionesLaboratorio });
            dgvLaboratorio.Location = new Point(6, 34);
            dgvLaboratorio.Name = "dgvLaboratorio";
            dgvLaboratorio.Size = new Size(865, 227);
            dgvLaboratorio.TabIndex = 0;
            // 
            // colAccionesLaboratorio
            // 
            colAccionesLaboratorio.HeaderText = "Acciones";
            colAccionesLaboratorio.Name = "colAccionesLaboratorio";
            colAccionesLaboratorio.Resizable = DataGridViewTriState.True;
            colAccionesLaboratorio.SortMode = DataGridViewColumnSortMode.Automatic;
            colAccionesLaboratorio.Width = 150;
            // 
            // colApellidoLaboratorio
            // 
            colApellidoLaboratorio.HeaderText = "Apellido";
            colApellidoLaboratorio.Name = "colApellidoLaboratorio";
            colApellidoLaboratorio.Width = 200;
            // 
            // colNombreLaboratorio
            // 
            colNombreLaboratorio.HeaderText = "Nombre";
            colNombreLaboratorio.Name = "colNombreLaboratorio";
            colNombreLaboratorio.Width = 200;
            // 
            // colDniLaboratorio
            // 
            colDniLaboratorio.HeaderText = "DNI";
            colDniLaboratorio.Name = "colDniLaboratorio";
            // 
            // colHorarioLaboratorio
            // 
            colHorarioLaboratorio.HeaderText = "Horario";
            colHorarioLaboratorio.Name = "colHorarioLaboratorio";
            // 
            // colIdLaboratorio
            // 
            colIdLaboratorio.HeaderText = "Id";
            colIdLaboratorio.Name = "colIdLaboratorio";
            colIdLaboratorio.Width = 70;
            // 
            // btnAgregarPacienteLaboratorio
            // 
            btnAgregarPacienteLaboratorio.Location = new Point(6, 6);
            btnAgregarPacienteLaboratorio.Name = "btnAgregarPacienteLaboratorio";
            btnAgregarPacienteLaboratorio.Size = new Size(226, 23);
            btnAgregarPacienteLaboratorio.TabIndex = 1;
            btnAgregarPacienteLaboratorio.Text = "Agregar paciente a la lista de espera";
            btnAgregarPacienteLaboratorio.UseVisualStyleBackColor = true;
            btnAgregarPacienteLaboratorio.Click += btnAgregarPacienteLaboratorio_Click;
            // 
            // tbEstudios
            // 
            tbEstudios.Controls.Add(tabLaboratorio);
            tbEstudios.Controls.Add(tabEcografia);
            tbEstudios.Controls.Add(tabElectrocardiograma);
            tbEstudios.Controls.Add(tabRadiografia);
            tbEstudios.Controls.Add(tabTomografia);
            tbEstudios.Location = new Point(12, 61);
            tbEstudios.Name = "tbEstudios";
            tbEstudios.SelectedIndex = 0;
            tbEstudios.Size = new Size(882, 292);
            tbEstudios.TabIndex = 0;
            // 
            // colIdElectrocardiograma
            // 
            colIdElectrocardiograma.HeaderText = "Id";
            colIdElectrocardiograma.Name = "colIdElectrocardiograma";
            colIdElectrocardiograma.Width = 70;
            // 
            // colHorarioElectrocardiograma
            // 
            colHorarioElectrocardiograma.HeaderText = "Horario";
            colHorarioElectrocardiograma.Name = "colHorarioElectrocardiograma";
            colHorarioElectrocardiograma.Width = 70;
            // 
            // colDniElectrocardiograma
            // 
            colDniElectrocardiograma.HeaderText = "DNI";
            colDniElectrocardiograma.Name = "colDniElectrocardiograma";
            colDniElectrocardiograma.Width = 80;
            // 
            // colNombreElectrocardiograma
            // 
            colNombreElectrocardiograma.HeaderText = "Nombre";
            colNombreElectrocardiograma.Name = "colNombreElectrocardiograma";
            colNombreElectrocardiograma.Width = 180;
            // 
            // colApellidoElectrocardiograma
            // 
            colApellidoElectrocardiograma.HeaderText = "Apellido";
            colApellidoElectrocardiograma.Name = "colApellidoElectrocardiograma";
            colApellidoElectrocardiograma.Width = 180;
            // 
            // colFechaElectrocardiograma
            // 
            colFechaElectrocardiograma.HeaderText = "Fecha";
            colFechaElectrocardiograma.Name = "colFechaElectrocardiograma";
            // 
            // colAccionesElectrocardiograma
            // 
            colAccionesElectrocardiograma.HeaderText = "Acciones";
            colAccionesElectrocardiograma.Name = "colAccionesElectrocardiograma";
            colAccionesElectrocardiograma.Resizable = DataGridViewTriState.True;
            colAccionesElectrocardiograma.SortMode = DataGridViewColumnSortMode.Automatic;
            colAccionesElectrocardiograma.Width = 150;
            // 
            // colIdRadiografia
            // 
            colIdRadiografia.HeaderText = "Id";
            colIdRadiografia.Name = "colIdRadiografia";
            colIdRadiografia.Width = 70;
            // 
            // colHorarioRadiografia
            // 
            colHorarioRadiografia.HeaderText = "Horario";
            colHorarioRadiografia.Name = "colHorarioRadiografia";
            colHorarioRadiografia.Width = 70;
            // 
            // colDniRadiografia
            // 
            colDniRadiografia.HeaderText = "DNI";
            colDniRadiografia.Name = "colDniRadiografia";
            colDniRadiografia.Width = 80;
            // 
            // colNombreRadiografia
            // 
            colNombreRadiografia.HeaderText = "Nombre";
            colNombreRadiografia.Name = "colNombreRadiografia";
            colNombreRadiografia.Width = 180;
            // 
            // colApellidoRadiografia
            // 
            colApellidoRadiografia.HeaderText = "Apellido";
            colApellidoRadiografia.Name = "colApellidoRadiografia";
            colApellidoRadiografia.Width = 180;
            // 
            // colFechaRadiografia
            // 
            colFechaRadiografia.HeaderText = "Fecha";
            colFechaRadiografia.Name = "colFechaRadiografia";
            // 
            // colAccionesRadiografia
            // 
            colAccionesRadiografia.HeaderText = "Acciones";
            colAccionesRadiografia.Name = "colAccionesRadiografia";
            colAccionesRadiografia.Resizable = DataGridViewTriState.True;
            colAccionesRadiografia.SortMode = DataGridViewColumnSortMode.Automatic;
            colAccionesRadiografia.Width = 150;
            // 
            // colIdTomografia
            // 
            colIdTomografia.HeaderText = "Id";
            colIdTomografia.Name = "colIdTomografia";
            colIdTomografia.Width = 70;
            // 
            // colHorarioTomografia
            // 
            colHorarioTomografia.HeaderText = "Horario";
            colHorarioTomografia.Name = "colHorarioTomografia";
            colHorarioTomografia.Width = 70;
            // 
            // colDniTomografia
            // 
            colDniTomografia.HeaderText = "DNI";
            colDniTomografia.Name = "colDniTomografia";
            colDniTomografia.Width = 80;
            // 
            // colNombreTomografia
            // 
            colNombreTomografia.HeaderText = "Nombre";
            colNombreTomografia.Name = "colNombreTomografia";
            colNombreTomografia.Width = 180;
            // 
            // colApellidoTomografia
            // 
            colApellidoTomografia.HeaderText = "Apellido";
            colApellidoTomografia.Name = "colApellidoTomografia";
            colApellidoTomografia.Width = 180;
            // 
            // colFechaTomografia
            // 
            colFechaTomografia.HeaderText = "Fecha";
            colFechaTomografia.Name = "colFechaTomografia";
            // 
            // colAcreditarTomografia
            // 
            colAcreditarTomografia.HeaderText = "Acciones";
            colAcreditarTomografia.Name = "colAcreditarTomografia";
            colAcreditarTomografia.Resizable = DataGridViewTriState.True;
            colAcreditarTomografia.SortMode = DataGridViewColumnSortMode.Automatic;
            colAcreditarTomografia.Width = 150;
            // 
            // frmAgendaEstudiosClinicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
            Controls.Add(btnVolverMenu);
            Controls.Add(btnPacientePrioritario);
            Controls.Add(frmNuevoPaciente);
            Controls.Add(tbEstudios);
            Name = "frmAgendaEstudiosClinicos";
            Text = "Agenda Estudios Clínicos";
            tabTomografia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTomografia).EndInit();
            tabRadiografia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRadiografia).EndInit();
            tabElectrocardiograma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvElectrocardiograma).EndInit();
            tabEcografia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEcografia).EndInit();
            tabLaboratorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorio).EndInit();
            tbEstudios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button frmNuevoPaciente;
        private Button btnPacientePrioritario;
        private Button btnVolverMenu;
        private TabPage tabTomografia;
        private DataGridView dgvTomografia;
        private DataGridViewTextBoxColumn colIdTomografia;
        private DataGridViewTextBoxColumn colHorarioTomografia;
        private DataGridViewTextBoxColumn colDniTomografia;
        private DataGridViewTextBoxColumn colNombreTomografia;
        private DataGridViewTextBoxColumn colApellidoTomografia;
        private DataGridViewTextBoxColumn colFechaTomografia;
        private DataGridViewButtonColumn colAcreditarTomografia;
        private TabPage tabRadiografia;
        private DataGridView dgvRadiografia;
        private DataGridViewTextBoxColumn colIdRadiografia;
        private DataGridViewTextBoxColumn colHorarioRadiografia;
        private DataGridViewTextBoxColumn colDniRadiografia;
        private DataGridViewTextBoxColumn colNombreRadiografia;
        private DataGridViewTextBoxColumn colApellidoRadiografia;
        private DataGridViewTextBoxColumn colFechaRadiografia;
        private DataGridViewButtonColumn colAccionesRadiografia;
        private TabPage tabElectrocardiograma;
        private DataGridView dgvElectrocardiograma;
        private DataGridViewTextBoxColumn colIdElectrocardiograma;
        private DataGridViewTextBoxColumn colHorarioElectrocardiograma;
        private DataGridViewTextBoxColumn colDniElectrocardiograma;
        private DataGridViewTextBoxColumn colNombreElectrocardiograma;
        private DataGridViewTextBoxColumn colApellidoElectrocardiograma;
        private DataGridViewTextBoxColumn colFechaElectrocardiograma;
        private DataGridViewButtonColumn colAccionesElectrocardiograma;
        private TabPage tabEcografia;
        private DataGridView dgvEcografia;
        private DataGridViewTextBoxColumn colIdEcografia;
        private DataGridViewTextBoxColumn colHorarioEcografia;
        private DataGridViewTextBoxColumn colDniEcografia;
        private DataGridViewTextBoxColumn colNombreEcografia;
        private DataGridViewTextBoxColumn colApellidoEcografia;
        private DataGridViewTextBoxColumn colFechaEcografia;
        private DataGridViewButtonColumn colAccionesEcografia;
        private TabPage tabLaboratorio;
        private Button btnAgregarPacienteLaboratorio;
        private DataGridView dgvLaboratorio;
        private DataGridViewTextBoxColumn colIdLaboratorio;
        private DataGridViewTextBoxColumn colHorarioLaboratorio;
        private DataGridViewTextBoxColumn colDniLaboratorio;
        private DataGridViewTextBoxColumn colNombreLaboratorio;
        private DataGridViewTextBoxColumn colApellidoLaboratorio;
        private DataGridViewButtonColumn colAccionesLaboratorio;
        private TabControl tbEstudios;
    }
}