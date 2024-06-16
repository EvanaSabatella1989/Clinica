namespace Clinica_SePrice
{
    partial class frmAgregarPacienteLaboratorio
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
            lblDni = new Label();
            txtDni = new TextBox();
            btnAgregar = new Button();
            chkAyuno = new CheckBox();
            cbHorarios = new ComboBox();
            chkPrioritario = new CheckBox();
            SuspendLayout();
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(39, 51);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(82, 48);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(200, 23);
            txtDni.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(121, 193);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 42);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // chkAyuno
            // 
            chkAyuno.AutoSize = true;
            chkAyuno.Location = new Point(164, 144);
            chkAyuno.Name = "chkAyuno";
            chkAyuno.Size = new Size(118, 19);
            chkAyuno.TabIndex = 4;
            chkAyuno.Text = "Ayuno Requerido";
            chkAyuno.UseVisualStyleBackColor = true;
            chkAyuno.CheckedChanged += chkAyuno_CheckedChanged;
            // 
            // cbHorarios
            // 
            cbHorarios.FormattingEnabled = true;
            cbHorarios.Location = new Point(25, 142);
            cbHorarios.Name = "cbHorarios";
            cbHorarios.Size = new Size(121, 23);
            cbHorarios.TabIndex = 5;
            // 
            // chkPrioritario
            // 
            chkPrioritario.AutoSize = true;
            chkPrioritario.Location = new Point(39, 98);
            chkPrioritario.Name = "chkPrioritario";
            chkPrioritario.Size = new Size(243, 19);
            chkPrioritario.TabIndex = 6;
            chkPrioritario.Text = "Prioritario (Internación / Guardia Médica)";
            chkPrioritario.UseVisualStyleBackColor = true;
            chkPrioritario.CheckedChanged += chkPrioritario_CheckedChanged;
            // 
            // frmAgregarPacienteLaboratorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 275);
            Controls.Add(chkPrioritario);
            Controls.Add(cbHorarios);
            Controls.Add(chkAyuno);
            Controls.Add(btnAgregar);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Name = "frmAgregarPacienteLaboratorio";
            Text = "Agregar Paciente Laboratorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chkAyuno;
        private System.Windows.Forms.ComboBox cbHorarios;
        private CheckBox chkPrioritario;
    }
}