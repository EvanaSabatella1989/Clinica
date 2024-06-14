namespace Clinica_SePrice
{
    partial class RegistrarPaciente
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
            txtNombrePaciente = new TextBox();
            txtApellidoPaciente = new TextBox();
            btnVolverRegistrarPaciente = new Button();
            btnGuardarPaciente = new Button();
            lblNombrePaciente = new Label();
            lblApellidoPaciente = new Label();
            lblDniPaciente = new Label();
            txtDniPaciente = new TextBox();
            lblFechaNacPaciente = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblRegistroPaciente = new Label();
            SuspendLayout();
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(82, 76);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(157, 23);
            txtNombrePaciente.TabIndex = 0;
            // 
            // txtApellidoPaciente
            // 
            txtApellidoPaciente.Location = new Point(373, 76);
            txtApellidoPaciente.Name = "txtApellidoPaciente";
            txtApellidoPaciente.Size = new Size(157, 23);
            txtApellidoPaciente.TabIndex = 1;
            // 
            // btnVolverRegistrarPaciente
            // 
            btnVolverRegistrarPaciente.Location = new Point(455, 18);
            btnVolverRegistrarPaciente.Name = "btnVolverRegistrarPaciente";
            btnVolverRegistrarPaciente.Size = new Size(75, 23);
            btnVolverRegistrarPaciente.TabIndex = 2;
            btnVolverRegistrarPaciente.Text = "Volver";
            btnVolverRegistrarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.Location = new Point(195, 202);
            btnGuardarPaciente.Name = "btnGuardarPaciente";
            btnGuardarPaciente.Size = new Size(190, 39);
            btnGuardarPaciente.TabIndex = 3;
            btnGuardarPaciente.Text = "Guardar";
            btnGuardarPaciente.UseVisualStyleBackColor = true;
            btnGuardarPaciente.Click += btnGuardarPaciente_Click;
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Location = new Point(25, 79);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(51, 15);
            lblNombrePaciente.TabIndex = 4;
            lblNombrePaciente.Text = "Nombre";
            // 
            // lblApellidoPaciente
            // 
            lblApellidoPaciente.AutoSize = true;
            lblApellidoPaciente.Location = new Point(316, 79);
            lblApellidoPaciente.Name = "lblApellidoPaciente";
            lblApellidoPaciente.Size = new Size(51, 15);
            lblApellidoPaciente.TabIndex = 5;
            lblApellidoPaciente.Text = "Apellido";
            // 
            // lblDniPaciente
            // 
            lblDniPaciente.AutoSize = true;
            lblDniPaciente.Location = new Point(49, 144);
            lblDniPaciente.Name = "lblDniPaciente";
            lblDniPaciente.Size = new Size(27, 15);
            lblDniPaciente.TabIndex = 6;
            lblDniPaciente.Text = "DNI";
            // 
            // txtDniPaciente
            // 
            txtDniPaciente.Location = new Point(82, 136);
            txtDniPaciente.Name = "txtDniPaciente";
            txtDniPaciente.Size = new Size(157, 23);
            txtDniPaciente.TabIndex = 7;
            // 
            // lblFechaNacPaciente
            // 
            lblFechaNacPaciente.AutoSize = true;
            lblFechaNacPaciente.Location = new Point(302, 144);
            lblFechaNacPaciente.Name = "lblFechaNacPaciente";
            lblFechaNacPaciente.Size = new Size(65, 15);
            lblFechaNacPaciente.TabIndex = 8;
            lblFechaNacPaciente.Text = "Fecha Nac.";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(373, 138);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(91, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // lblRegistroPaciente
            // 
            lblRegistroPaciente.AutoSize = true;
            lblRegistroPaciente.Font = new Font("Segoe UI", 11F);
            lblRegistroPaciente.Location = new Point(195, 21);
            lblRegistroPaciente.Name = "lblRegistroPaciente";
            lblRegistroPaciente.Size = new Size(190, 20);
            lblRegistroPaciente.TabIndex = 10;
            lblRegistroPaciente.Text = "Registro de nuevo paciente";
            // 
            // RegistrarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 263);
            Controls.Add(lblRegistroPaciente);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFechaNacPaciente);
            Controls.Add(txtDniPaciente);
            Controls.Add(lblDniPaciente);
            Controls.Add(lblApellidoPaciente);
            Controls.Add(lblNombrePaciente);
            Controls.Add(btnGuardarPaciente);
            Controls.Add(btnVolverRegistrarPaciente);
            Controls.Add(txtApellidoPaciente);
            Controls.Add(txtNombrePaciente);
            Name = "RegistrarPaciente";
            Text = "RegistrarPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombrePaciente;
        private TextBox txtApellidoPaciente;
        private Button btnVolverRegistrarPaciente;
        private Button btnGuardarPaciente;
        private Label lblNombrePaciente;
        private Label lblApellidoPaciente;
        private Label lblDniPaciente;
        private TextBox txtDniPaciente;
        private Label lblFechaNacPaciente;
        private DateTimePicker dateTimePicker1;
        private Label lblRegistroPaciente;
    }
}