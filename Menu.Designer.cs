namespace Clinica_SePrice
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            btnTurnos = new Button();
            label1 = new Label();
            label2 = new Label();
            btnGestionDeInsumos = new Button();
            button3 = new Button();
            btnGestionEstudios = new Button();
            btnListaEsperaEstudiosClinicos = new Button();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnTurnos
            // 
            btnTurnos.Location = new Point(34, 62);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(166, 23);
            btnTurnos.TabIndex = 0;
            btnTurnos.Text = "Gestión de Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 21);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido/a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 21);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre de usuario";
            // 
            // btnGestionDeInsumos
            // 
            btnGestionDeInsumos.Location = new Point(34, 120);
            btnGestionDeInsumos.Name = "btnGestionDeInsumos";
            btnGestionDeInsumos.Size = new Size(166, 23);
            btnGestionDeInsumos.TabIndex = 3;
            btnGestionDeInsumos.Text = "Gestión de Insumos";
            btnGestionDeInsumos.UseVisualStyleBackColor = true;
            btnGestionDeInsumos.Click += btnGestionDeInsumos_Click;
            // 
            // button3
            // 
            button3.Location = new Point(342, 21);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnGestionEstudios
            // 
            btnGestionEstudios.Location = new Point(34, 91);
            btnGestionEstudios.Name = "btnGestionEstudios";
            btnGestionEstudios.Size = new Size(166, 23);
            btnGestionEstudios.TabIndex = 5;
            btnGestionEstudios.Text = "Gestión de Estudios";
            btnGestionEstudios.UseVisualStyleBackColor = true;
            btnGestionEstudios.Click += btnGestionEstudios_Click;
            // 
            // btnListaEsperaEstudiosClinicos
            // 
            btnListaEsperaEstudiosClinicos.Location = new Point(34, 149);
            btnListaEsperaEstudiosClinicos.Name = "btnListaEsperaEstudiosClinicos";
            btnListaEsperaEstudiosClinicos.Size = new Size(166, 23);
            btnListaEsperaEstudiosClinicos.TabIndex = 6;
            btnListaEsperaEstudiosClinicos.Text = "Agenda Estudios Clínicos";
            btnListaEsperaEstudiosClinicos.UseVisualStyleBackColor = true;
            btnListaEsperaEstudiosClinicos.Click += btnListaEsperaEstudiosClinicos_Click;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(269, 62);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(148, 118);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 7;
            picLogo.TabStop = false;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 222);
            Controls.Add(picLogo);
            Controls.Add(btnListaEsperaEstudiosClinicos);
            Controls.Add(btnGestionEstudios);
            Controls.Add(button3);
            Controls.Add(btnGestionDeInsumos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTurnos);
            Name = "frmMenu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTurnos;
        private Label label1;
        private Label label2;
        private Button btnGestionDeInsumos;
        private Button button3;
        private Button btnGestionEstudios;
        private Button btnListaEsperaEstudiosClinicos;
        private PictureBox picLogo;
    }
}