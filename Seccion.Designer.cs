namespace Clinica_SePrice
{
    partial class Seccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seccion));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnEstudiosClinicos = new Button();
            btnConsultoriosExternos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 174);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(290, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 174);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnEstudiosClinicos
            // 
            btnEstudiosClinicos.Location = new Point(57, 225);
            btnEstudiosClinicos.Name = "btnEstudiosClinicos";
            btnEstudiosClinicos.Size = new Size(172, 23);
            btnEstudiosClinicos.TabIndex = 2;
            btnEstudiosClinicos.Text = "Estudios clínicos";
            btnEstudiosClinicos.UseVisualStyleBackColor = true;
            btnEstudiosClinicos.Click += button1_Click;
            // 
            // btnConsultoriosExternos
            // 
            btnConsultoriosExternos.Location = new Point(290, 225);
            btnConsultoriosExternos.Name = "btnConsultoriosExternos";
            btnConsultoriosExternos.Size = new Size(168, 23);
            btnConsultoriosExternos.TabIndex = 3;
            btnConsultoriosExternos.Text = "Consultorios externos";
            btnConsultoriosExternos.UseVisualStyleBackColor = true;
            // 
            // Seccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 263);
            Controls.Add(btnConsultoriosExternos);
            Controls.Add(btnEstudiosClinicos);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Seccion";
            Text = "Seccion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnEstudiosClinicos;
        private Button btnConsultoriosExternos;
    }
}