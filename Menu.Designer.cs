namespace Clinica_SePrice
{
    partial class Menu
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
            btnTurnos = new Button();
            label1 = new Label();
            label2 = new Label();
            btnGestionDeInsumos = new Button();
            button3 = new Button();
            btnGestionEstudios = new Button();
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
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 21);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre de usuario";
            label2.Click += label2_Click;
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
            button3.Location = new Point(390, 168);
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
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 233);
            Controls.Add(btnGestionEstudios);
            Controls.Add(button3);
            Controls.Add(btnGestionDeInsumos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTurnos);
            Name = "Menu";
            Text = "Menu";
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
    }
}