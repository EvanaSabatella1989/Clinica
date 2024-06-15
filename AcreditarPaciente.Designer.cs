namespace Clinica_SePrice
{
    partial class frmAcreditarPaciente
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
            lblModalidadDePago = new Label();
            rbObraSocial = new RadioButton();
            gbModalidadPago = new GroupBox();
            rbParticular = new RadioButton();
            btnAcreditar = new Button();
            gbModalidadPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblModalidadDePago
            // 
            lblModalidadDePago.AutoSize = true;
            lblModalidadDePago.Location = new Point(58, 23);
            lblModalidadDePago.Name = "lblModalidadDePago";
            lblModalidadDePago.Size = new Size(110, 15);
            lblModalidadDePago.TabIndex = 1;
            lblModalidadDePago.Text = "Modalidad de Pago";
            // 
            // rbObraSocial
            // 
            rbObraSocial.AutoSize = true;
            rbObraSocial.Location = new Point(6, 18);
            rbObraSocial.Name = "rbObraSocial";
            rbObraSocial.Size = new Size(85, 19);
            rbObraSocial.TabIndex = 2;
            rbObraSocial.TabStop = true;
            rbObraSocial.Text = "Obra Social";
            rbObraSocial.UseVisualStyleBackColor = true;
            // 
            // gbModalidadPago
            // 
            gbModalidadPago.Controls.Add(rbParticular);
            gbModalidadPago.Controls.Add(rbObraSocial);
            gbModalidadPago.Location = new Point(67, 51);
            gbModalidadPago.Name = "gbModalidadPago";
            gbModalidadPago.Size = new Size(91, 78);
            gbModalidadPago.TabIndex = 3;
            gbModalidadPago.TabStop = false;
            // 
            // rbParticular
            // 
            rbParticular.AutoSize = true;
            rbParticular.Location = new Point(6, 43);
            rbParticular.Name = "rbParticular";
            rbParticular.Size = new Size(75, 19);
            rbParticular.TabIndex = 3;
            rbParticular.TabStop = true;
            rbParticular.Text = "Particular";
            rbParticular.UseVisualStyleBackColor = true;
            // 
            // btnAcreditar
            // 
            btnAcreditar.Location = new Point(73, 154);
            btnAcreditar.Name = "btnAcreditar";
            btnAcreditar.Size = new Size(75, 23);
            btnAcreditar.TabIndex = 4;
            btnAcreditar.Text = "Acreditar";
            btnAcreditar.UseVisualStyleBackColor = true;
            btnAcreditar.Click += btnAcreditar_Click;
            // 
            // frmAcreditarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 203);
            Controls.Add(btnAcreditar);
            Controls.Add(gbModalidadPago);
            Controls.Add(lblModalidadDePago);
            Name = "frmAcreditarPaciente";
            Text = "AcreditarPaciente";
            gbModalidadPago.ResumeLayout(false);
            gbModalidadPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModalidadDePago;
        private RadioButton rbObraSocial;
        private GroupBox gbModalidadPago;
        private RadioButton rbParticular;
        private Button btnAcreditar;
    }
}