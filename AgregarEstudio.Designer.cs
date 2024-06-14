namespace Clinica_SePrice
{
    partial class frmAgregarEstudio
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
            lblIdEstudio = new Label();
            lblTipoEstudio = new Label();
            lblIdPaciente = new Label();
            txtIdEstudio = new TextBox();
            cmbTipoEstudio = new ComboBox();
            idPaciente = new TextBox();
            btnAgregarEstudio = new Button();
            lblFechaEstudio = new Label();
            dtpFechaEstudio = new DateTimePicker();
            SuspendLayout();
            // 
            // lblIdEstudio
            // 
            lblIdEstudio.AutoSize = true;
            lblIdEstudio.Location = new Point(37, 51);
            lblIdEstudio.Name = "lblIdEstudio";
            lblIdEstudio.Size = new Size(78, 15);
            lblIdEstudio.TabIndex = 0;
            lblIdEstudio.Text = "Id del estudio";
            // 
            // lblTipoEstudio
            // 
            lblTipoEstudio.AutoSize = true;
            lblTipoEstudio.Location = new Point(37, 96);
            lblTipoEstudio.Name = "lblTipoEstudio";
            lblTipoEstudio.Size = new Size(88, 15);
            lblTipoEstudio.TabIndex = 1;
            lblTipoEstudio.Text = "Tipo de estudio";
            // 
            // lblIdPaciente
            // 
            lblIdPaciente.AutoSize = true;
            lblIdPaciente.Location = new Point(37, 140);
            lblIdPaciente.Name = "lblIdPaciente";
            lblIdPaciente.Size = new Size(84, 15);
            lblIdPaciente.TabIndex = 2;
            lblIdPaciente.Text = "Id del paciente";
            // 
            // txtIdEstudio
            // 
            txtIdEstudio.Location = new Point(178, 48);
            txtIdEstudio.Name = "txtIdEstudio";
            txtIdEstudio.Size = new Size(157, 23);
            txtIdEstudio.TabIndex = 3;
            // 
            // cmbTipoEstudio
            // 
            cmbTipoEstudio.FormattingEnabled = true;
            cmbTipoEstudio.Items.AddRange(new object[] { "Ecografía", "Electrocardiograma", "Laboratorio", "Radiografía", "Tomografía" });
            cmbTipoEstudio.Location = new Point(178, 93);
            cmbTipoEstudio.Name = "cmbTipoEstudio";
            cmbTipoEstudio.Size = new Size(157, 23);
            cmbTipoEstudio.TabIndex = 4;
            // 
            // idPaciente
            // 
            idPaciente.Location = new Point(178, 140);
            idPaciente.Name = "idPaciente";
            idPaciente.Size = new Size(157, 23);
            idPaciente.TabIndex = 5;
            // 
            // btnAgregarEstudio
            // 
            btnAgregarEstudio.Location = new Point(114, 243);
            btnAgregarEstudio.Name = "btnAgregarEstudio";
            btnAgregarEstudio.Size = new Size(145, 23);
            btnAgregarEstudio.TabIndex = 6;
            btnAgregarEstudio.Text = "Agregar Estudio";
            btnAgregarEstudio.UseVisualStyleBackColor = true;
            btnAgregarEstudio.Click += btnAgregarEstudio_Click;
            // 
            // lblFechaEstudio
            // 
            lblFechaEstudio.AutoSize = true;
            lblFechaEstudio.Location = new Point(37, 184);
            lblFechaEstudio.Name = "lblFechaEstudio";
            lblFechaEstudio.Size = new Size(99, 15);
            lblFechaEstudio.TabIndex = 7;
            lblFechaEstudio.Text = "Fecha del estudio";
            // 
            // dtpFechaEstudio
            // 
            dtpFechaEstudio.Format = DateTimePickerFormat.Custom;
            dtpFechaEstudio.Location = new Point(178, 184);
            dtpFechaEstudio.Name = "dtpFechaEstudio";
            dtpFechaEstudio.Size = new Size(157, 23);
            dtpFechaEstudio.TabIndex = 8;
            // 
            // frmAgregarEstudio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 302);
            Controls.Add(dtpFechaEstudio);
            Controls.Add(lblFechaEstudio);
            Controls.Add(btnAgregarEstudio);
            Controls.Add(idPaciente);
            Controls.Add(cmbTipoEstudio);
            Controls.Add(txtIdEstudio);
            Controls.Add(lblIdPaciente);
            Controls.Add(lblTipoEstudio);
            Controls.Add(lblIdEstudio);
            Name = "frmAgregarEstudio";
            Text = "AgregarEstudio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdEstudio;
        private Label lblTipoEstudio;
        private Label lblIdPaciente;
        private TextBox txtIdEstudio;
        private ComboBox cmbTipoEstudio;
        private TextBox idPaciente;
        private Button btnAgregarEstudio;
        private Label lblFechaEstudio;
        private DateTimePicker dtpFechaEstudio;
    }
}