namespace Clinica_SePrice
{
    partial class frmComprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobante));
            pbLogo = new PictureBox();
            lblIdEstudio = new Label();
            lblTipoEstudio = new Label();
            lblFecha = new Label();
            lblDniPaciente = new Label();
            lblNombrePaciente = new Label();
            lblApellidoPaciente = new Label();
            lblFechaRetiro = new Label();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.InitialImage = null;
            pbLogo.Location = new Point(247, 76);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(141, 128);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblIdEstudio
            // 
            lblIdEstudio.AutoSize = true;
            lblIdEstudio.Location = new Point(30, 65);
            lblIdEstudio.Name = "lblIdEstudio";
            lblIdEstudio.Size = new Size(38, 15);
            lblIdEstudio.TabIndex = 1;
            lblIdEstudio.Text = "label1";
            // 
            // lblTipoEstudio
            // 
            lblTipoEstudio.AutoSize = true;
            lblTipoEstudio.Location = new Point(30, 30);
            lblTipoEstudio.Name = "lblTipoEstudio";
            lblTipoEstudio.Size = new Size(38, 15);
            lblTipoEstudio.TabIndex = 2;
            lblTipoEstudio.Text = "label2";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(30, 207);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "label3";
            // 
            // lblDniPaciente
            // 
            lblDniPaciente.AutoSize = true;
            lblDniPaciente.Location = new Point(30, 100);
            lblDniPaciente.Name = "lblDniPaciente";
            lblDniPaciente.Size = new Size(38, 15);
            lblDniPaciente.TabIndex = 4;
            lblDniPaciente.Text = "label4";
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Location = new Point(30, 137);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(38, 15);
            lblNombrePaciente.TabIndex = 5;
            lblNombrePaciente.Text = "label5";
            // 
            // lblApellidoPaciente
            // 
            lblApellidoPaciente.AutoSize = true;
            lblApellidoPaciente.Location = new Point(30, 172);
            lblApellidoPaciente.Name = "lblApellidoPaciente";
            lblApellidoPaciente.Size = new Size(38, 15);
            lblApellidoPaciente.TabIndex = 6;
            lblApellidoPaciente.Text = "label6";
            // 
            // lblFechaRetiro
            // 
            lblFechaRetiro.AutoSize = true;
            lblFechaRetiro.Location = new Point(30, 242);
            lblFechaRetiro.Name = "lblFechaRetiro";
            lblFechaRetiro.Size = new Size(38, 15);
            lblFechaRetiro.TabIndex = 7;
            lblFechaRetiro.Text = "label1";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(313, 22);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 8;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // frmComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 282);
            Controls.Add(btnImprimir);
            Controls.Add(lblFechaRetiro);
            Controls.Add(lblApellidoPaciente);
            Controls.Add(lblNombrePaciente);
            Controls.Add(lblDniPaciente);
            Controls.Add(lblFecha);
            Controls.Add(lblTipoEstudio);
            Controls.Add(lblIdEstudio);
            Controls.Add(pbLogo);
            Name = "frmComprobante";
            Text = "ComprobanteEstudio";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblIdEstudio;
        private Label lblTipoEstudio;
        private Label lblFecha;
        private Label lblDniPaciente;
        private Label lblNombrePaciente;
        private Label lblApellidoPaciente;
        private Label lblFechaRetiro;
        private Button btnImprimir;
    }
}