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
            lblEspecialidad = new Label();
            comboBoxEspecialidad = new ComboBox();
            lblInfoEspecialidad = new Label();
            lblMedico = new Label();
            comboBoxMedico = new ComboBox();
            lblInfoMedico = new Label();
            dateTimePicker = new DateTimePicker();
            listBox = new ListBox();
            btnConfirmaTurno = new Button();
            btnCancelarTurno = new Button();
            label1 = new Label();
            textBoxDni = new TextBox();
            btnVerificarDni = new Button();
            SuspendLayout();
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(53, 88);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(75, 15);
            lblEspecialidad.TabIndex = 0;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // comboBoxEspecialidad
            // 
            comboBoxEspecialidad.FormattingEnabled = true;
            comboBoxEspecialidad.Items.AddRange(new object[] { "Diabetes", "Cardiología", "Dermatología", "Oftalmología" });
            comboBoxEspecialidad.Location = new Point(147, 85);
            comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            comboBoxEspecialidad.Size = new Size(121, 23);
            comboBoxEspecialidad.TabIndex = 1;
            comboBoxEspecialidad.SelectedIndexChanged += comboBoxEspecialidad_SelectedIndexChanged;
            // 
            // lblInfoEspecialidad
            // 
            lblInfoEspecialidad.AutoSize = true;
            lblInfoEspecialidad.Location = new Point(53, 117);
            lblInfoEspecialidad.Name = "lblInfoEspecialidad";
            lblInfoEspecialidad.Size = new Size(0, 15);
            lblInfoEspecialidad.TabIndex = 2;
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Location = new Point(53, 155);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(47, 15);
            lblMedico.TabIndex = 3;
            lblMedico.Text = "Médico";
            // 
            // comboBoxMedico
            // 
            comboBoxMedico.FormattingEnabled = true;
            comboBoxMedico.Items.AddRange(new object[] { "Gómez Juana", "Spada Cristina", "Stechina Alfredo", "Garay Noelia", "" });
            comboBoxMedico.Location = new Point(147, 147);
            comboBoxMedico.Name = "comboBoxMedico";
            comboBoxMedico.Size = new Size(121, 23);
            comboBoxMedico.TabIndex = 4;
            comboBoxMedico.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblInfoMedico
            // 
            lblInfoMedico.AutoSize = true;
            lblInfoMedico.Location = new Point(53, 192);
            lblInfoMedico.Name = "lblInfoMedico";
            lblInfoMedico.Size = new Size(0, 15);
            lblInfoMedico.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(53, 240);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 6;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(278, 240);
            listBox.Name = "listBox";
            listBox.Size = new Size(120, 94);
            listBox.TabIndex = 7;
            listBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnConfirmaTurno
            // 
            btnConfirmaTurno.Location = new Point(293, 351);
            btnConfirmaTurno.Name = "btnConfirmaTurno";
            btnConfirmaTurno.Size = new Size(75, 23);
            btnConfirmaTurno.TabIndex = 8;
            btnConfirmaTurno.Text = "Confirmar";
            btnConfirmaTurno.UseVisualStyleBackColor = true;
            btnConfirmaTurno.Click += btnConfirmaTurno_Click;
            // 
            // btnCancelarTurno
            // 
            btnCancelarTurno.Location = new Point(125, 351);
            btnCancelarTurno.Name = "btnCancelarTurno";
            btnCancelarTurno.Size = new Size(75, 23);
            btnCancelarTurno.TabIndex = 9;
            btnCancelarTurno.Text = "Cancelar";
            btnCancelarTurno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 36);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 10;
            label1.Text = "DNI:";
            label1.Click += label1_Click_1;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(147, 33);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(121, 23);
            textBoxDni.TabIndex = 11;
            // 
            // btnVerificarDni
            // 
            btnVerificarDni.Location = new Point(312, 33);
            btnVerificarDni.Name = "btnVerificarDni";
            btnVerificarDni.Size = new Size(75, 23);
            btnVerificarDni.TabIndex = 12;
            btnVerificarDni.Text = "Verificar";
            btnVerificarDni.UseVisualStyleBackColor = true;
            btnVerificarDni.Click += btnVerificarDni_Click;
            // 
            // GenerarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 419);
            Controls.Add(btnVerificarDni);
            Controls.Add(textBoxDni);
            Controls.Add(label1);
            Controls.Add(btnCancelarTurno);
            Controls.Add(btnConfirmaTurno);
            Controls.Add(listBox);
            Controls.Add(dateTimePicker);
            Controls.Add(lblInfoMedico);
            Controls.Add(comboBoxMedico);
            Controls.Add(lblMedico);
            Controls.Add(lblInfoEspecialidad);
            Controls.Add(comboBoxEspecialidad);
            Controls.Add(lblEspecialidad);
            Name = "GenerarTurno";
            Text = "GenerarTurno";
            Load += GenerarTurno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoMedico;
        private Label lblEspecialidad;
        private ComboBox comboBoxEspecialidad;
        private Label lblInfoEspecialidad;
        private Label lblMedico;
        private ComboBox comboBoxMedico;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox;
        private DateTimePicker dateTimePicker;
        private Button btnConfirmaTurno;
        private Button btnCancelarTurno;
        private Label label1;
        private TextBox textBoxDni;
        private Button btnVerificarDni;
    }
}