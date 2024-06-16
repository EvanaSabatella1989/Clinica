namespace Clinica_SePrice
{
    partial class GenerarTurno
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
            dateTimePicker = new DateTimePicker();
            lblDni = new Label();
            textBoxDni = new TextBox();
            lblInfoEspecialidad = new Label();
            lblInfoMedico = new Label();
            comboBoxEspecialidad = new ComboBox();
            comboBoxMedico = new ComboBox();
            btnConfirmaTurno = new Button();
            listBox = new ListBox();
            btnVerificarDni = new Button();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(68, 218);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(215, 23);
            dateTimePicker.TabIndex = 3;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(68, 47);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI";
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(178, 44);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(146, 23);
            textBoxDni.TabIndex = 5;
            // 
            // lblInfoEspecialidad
            // 
            lblInfoEspecialidad.AutoSize = true;
            lblInfoEspecialidad.Location = new Point(68, 100);
            lblInfoEspecialidad.Name = "lblInfoEspecialidad";
            lblInfoEspecialidad.Size = new Size(72, 15);
            lblInfoEspecialidad.TabIndex = 6;
            lblInfoEspecialidad.Text = "Especialidad";
            // 
            // lblInfoMedico
            // 
            lblInfoMedico.AutoSize = true;
            lblInfoMedico.Location = new Point(68, 156);
            lblInfoMedico.Name = "lblInfoMedico";
            lblInfoMedico.Size = new Size(58, 15);
            lblInfoMedico.TabIndex = 7;
            lblInfoMedico.Text = "Médico/a";
            // 
            // comboBoxEspecialidad
            // 
            comboBoxEspecialidad.FormattingEnabled = true;
            comboBoxEspecialidad.Items.AddRange(new object[] { "Cardiología", "Dermatología", "Fisio-kinesiología", "Salud mental" });
            comboBoxEspecialidad.Location = new Point(178, 100);
            comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            comboBoxEspecialidad.Size = new Size(146, 23);
            comboBoxEspecialidad.TabIndex = 8;
            // 
            // comboBoxMedico
            // 
            comboBoxMedico.FormattingEnabled = true;
            comboBoxMedico.Items.AddRange(new object[] { "Gómez Juana", "Spada Cristina", "Stechina Alfredo", "Garay Noelia" });
            comboBoxMedico.Location = new Point(178, 156);
            comboBoxMedico.Name = "comboBoxMedico";
            comboBoxMedico.Size = new Size(146, 23);
            comboBoxMedico.TabIndex = 9;
            // 
            // btnConfirmaTurno
            // 
            btnConfirmaTurno.Location = new Point(178, 323);
            btnConfirmaTurno.Name = "btnConfirmaTurno";
            btnConfirmaTurno.Size = new Size(109, 37);
            btnConfirmaTurno.TabIndex = 10;
            btnConfirmaTurno.Text = "Confirmar";
            btnConfirmaTurno.UseVisualStyleBackColor = true;
            btnConfirmaTurno.Click += btnConfirmaTurno_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(306, 218);
            listBox.Name = "listBox";
            listBox.Size = new Size(120, 94);
            listBox.TabIndex = 11;
            // 
            // btnVerificarDni
            // 
            btnVerificarDni.Location = new Point(355, 39);
            btnVerificarDni.Name = "btnVerificarDni";
            btnVerificarDni.Size = new Size(89, 31);
            btnVerificarDni.TabIndex = 12;
            btnVerificarDni.Text = "Verificar";
            btnVerificarDni.UseVisualStyleBackColor = true;
            btnVerificarDni.Click += btnVerificarDni_Click;
            // 
            // GenerarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 383);
            Controls.Add(btnVerificarDni);
            Controls.Add(listBox);
            Controls.Add(btnConfirmaTurno);
            Controls.Add(comboBoxMedico);
            Controls.Add(comboBoxEspecialidad);
            Controls.Add(lblInfoMedico);
            Controls.Add(lblInfoEspecialidad);
            Controls.Add(textBoxDni);
            Controls.Add(lblDni);
            Controls.Add(dateTimePicker);
            Name = "GenerarTurno";
            Text = "GenerarTurno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoMedico;
        private DateTimePicker dateTimePicker;
        private Label lblDni;
        private TextBox textBoxDni;
        private Label lblInfoEspecialidad;
        private ComboBox comboBoxEspecialidad;
        private ComboBox comboBoxMedico;
        private Button btnConfirmaTurno;
        private ListBox listBox;
        private Button btnVerificarDni;
    }
}