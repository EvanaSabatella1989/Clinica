namespace Clinica_SePrice
{
    partial class frmPacientePrioritario
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
            cbTipoEstudio = new ComboBox();
            btnAgregarPacientePrioritario = new Button();
            lblTipoEstudio = new Label();
            SuspendLayout();
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(76, 48);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(117, 48);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(140, 23);
            txtDni.TabIndex = 1;
            // 
            // cbTipoEstudio
            // 
            cbTipoEstudio.FormattingEnabled = true;
            cbTipoEstudio.Items.AddRange(new object[] { "Ecografía", "Electrocardiograma", "Laboratorio", "Radiografía", "Tomografía" });
            cbTipoEstudio.Location = new Point(117, 93);
            cbTipoEstudio.Name = "cbTipoEstudio";
            cbTipoEstudio.Size = new Size(140, 23);
            cbTipoEstudio.TabIndex = 2;
            // 
            // btnAgregarPacientePrioritario
            // 
            btnAgregarPacientePrioritario.Location = new Point(96, 137);
            btnAgregarPacientePrioritario.Name = "btnAgregarPacientePrioritario";
            btnAgregarPacientePrioritario.Size = new Size(75, 40);
            btnAgregarPacientePrioritario.TabIndex = 3;
            btnAgregarPacientePrioritario.Text = "Agregar";
            btnAgregarPacientePrioritario.UseVisualStyleBackColor = true;
            btnAgregarPacientePrioritario.Click += btnAgregarPacientePrioritario_Click;
            // 
            // lblTipoEstudio
            // 
            lblTipoEstudio.AutoSize = true;
            lblTipoEstudio.Location = new Point(15, 93);
            lblTipoEstudio.Name = "lblTipoEstudio";
            lblTipoEstudio.Size = new Size(88, 15);
            lblTipoEstudio.TabIndex = 4;
            lblTipoEstudio.Text = "Tipo de estudio";
            // 
            // frmPacientePrioritario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 204);
            Controls.Add(lblTipoEstudio);
            Controls.Add(btnAgregarPacientePrioritario);
            Controls.Add(cbTipoEstudio);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Name = "frmPacientePrioritario";
            Text = "PacientePrioritario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDni;
        private TextBox txtDni;
        private ComboBox cbTipoEstudio;
        private Button btnAgregarPacientePrioritario;
        private Label lblTipoEstudio;
    }
}