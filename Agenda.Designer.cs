namespace Clinica_SePrice
{
    partial class Agenda
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
            btnSolicitar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(161, 41);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(166, 23);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "Solicitar un turno";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(161, 88);
            button2.Name = "button2";
            button2.Size = new Size(166, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar un turno";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(161, 135);
            button3.Name = "button3";
            button3.Size = new Size(166, 23);
            button3.TabIndex = 2;
            button3.Text = "Ver turnos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(58, 184);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Atrás";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            label1.Click += label1_Click;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 243);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnSolicitar);
            Name = "Agenda";
            Text = "Agenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSolicitar;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}