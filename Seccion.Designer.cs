namespace Clinica_SePrice
{
    partial class frmSeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeccion));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnConsultoriosExternos = new Button();
            btnEstudiosClinicos = new Button();
            btnVolverMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 174);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(290, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 174);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnConsultoriosExternos
            // 
            btnConsultoriosExternos.Location = new Point(57, 237);
            btnConsultoriosExternos.Name = "btnConsultoriosExternos";
            btnConsultoriosExternos.Size = new Size(172, 23);
            btnConsultoriosExternos.TabIndex = 2;
            btnConsultoriosExternos.Text = "Consultorios externos";
            btnConsultoriosExternos.UseVisualStyleBackColor = true;
            btnConsultoriosExternos.Click += button1_Click;
            // 
            // btnEstudiosClinicos
            // 
            btnEstudiosClinicos.Location = new Point(290, 237);
            btnEstudiosClinicos.Name = "btnEstudiosClinicos";
            btnEstudiosClinicos.Size = new Size(168, 23);
            btnEstudiosClinicos.TabIndex = 3;
            btnEstudiosClinicos.Text = "Estudios clínicos";
            btnEstudiosClinicos.UseVisualStyleBackColor = true;
            btnEstudiosClinicos.Click += btnEstudiosClinicos_Click;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(12, 12);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(109, 23);
            btnVolverMenu.TabIndex = 4;
            btnVolverMenu.Text = "Volver al menú";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // frmSeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 281);
            Controls.Add(btnVolverMenu);
            Controls.Add(btnEstudiosClinicos);
            Controls.Add(btnConsultoriosExternos);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmSeccion";
            Text = "Seccion Turnos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnConsultoriosExternos;
        private Button btnEstudiosClinicos;
        private Button btnVolverMenu;
    }
}