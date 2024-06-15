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
            menuStrip1 = new MenuStrip();
            Especialidades = new ToolStripMenuItem();
            oftalmologíaToolStripMenuItem = new ToolStripMenuItem();
            dermatologíaToolStripMenuItem = new ToolStripMenuItem();
            flebologíaToolStripMenuItem = new ToolStripMenuItem();
            cardiologíaToolStripMenuItem = new ToolStripMenuItem();
            pediatríaToolStripMenuItem = new ToolStripMenuItem();
            diabetologíaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            médicosToolStripMenuItem = new ToolStripMenuItem();
            gómezHéctorToolStripMenuItem = new ToolStripMenuItem();
            acostaSilvanaToolStripMenuItem = new ToolStripMenuItem();
            sanchezJuanToolStripMenuItem = new ToolStripMenuItem();
            monthCalendar1 = new MonthCalendar();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Especialidades });
            menuStrip1.Location = new Point(83, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(96, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // Especialidades
            // 
            Especialidades.DropDownItems.AddRange(new ToolStripItem[] { oftalmologíaToolStripMenuItem, dermatologíaToolStripMenuItem, flebologíaToolStripMenuItem, cardiologíaToolStripMenuItem, pediatríaToolStripMenuItem, diabetologíaToolStripMenuItem });
            Especialidades.Name = "Especialidades";
            Especialidades.Size = new Size(84, 20);
            Especialidades.Text = "Especialidad";
            // 
            // oftalmologíaToolStripMenuItem
            // 
            oftalmologíaToolStripMenuItem.Name = "oftalmologíaToolStripMenuItem";
            oftalmologíaToolStripMenuItem.Size = new Size(146, 22);
            oftalmologíaToolStripMenuItem.Text = "Oftalmología";
            // 
            // dermatologíaToolStripMenuItem
            // 
            dermatologíaToolStripMenuItem.Name = "dermatologíaToolStripMenuItem";
            dermatologíaToolStripMenuItem.Size = new Size(146, 22);
            dermatologíaToolStripMenuItem.Text = "Dermatología";
            // 
            // flebologíaToolStripMenuItem
            // 
            flebologíaToolStripMenuItem.Name = "flebologíaToolStripMenuItem";
            flebologíaToolStripMenuItem.Size = new Size(146, 22);
            flebologíaToolStripMenuItem.Text = "Flebología";
            // 
            // cardiologíaToolStripMenuItem
            // 
            cardiologíaToolStripMenuItem.Name = "cardiologíaToolStripMenuItem";
            cardiologíaToolStripMenuItem.Size = new Size(146, 22);
            cardiologíaToolStripMenuItem.Text = "Cardiología";
            // 
            // pediatríaToolStripMenuItem
            // 
            pediatríaToolStripMenuItem.Name = "pediatríaToolStripMenuItem";
            pediatríaToolStripMenuItem.Size = new Size(146, 22);
            pediatríaToolStripMenuItem.Text = "Pediatría";
            // 
            // diabetologíaToolStripMenuItem
            // 
            diabetologíaToolStripMenuItem.Name = "diabetologíaToolStripMenuItem";
            diabetologíaToolStripMenuItem.Size = new Size(146, 22);
            diabetologíaToolStripMenuItem.Text = "Diabetología";
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { médicosToolStripMenuItem });
            menuStrip2.Location = new Point(83, 64);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(78, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // médicosToolStripMenuItem
            // 
            médicosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gómezHéctorToolStripMenuItem, acostaSilvanaToolStripMenuItem, sanchezJuanToolStripMenuItem });
            médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            médicosToolStripMenuItem.Size = new Size(70, 20);
            médicosToolStripMenuItem.Text = "Médica/o";
            // 
            // gómezHéctorToolStripMenuItem
            // 
            gómezHéctorToolStripMenuItem.Name = "gómezHéctorToolStripMenuItem";
            gómezHéctorToolStripMenuItem.Size = new Size(150, 22);
            gómezHéctorToolStripMenuItem.Text = "Gómez Héctor";
            // 
            // acostaSilvanaToolStripMenuItem
            // 
            acostaSilvanaToolStripMenuItem.Name = "acostaSilvanaToolStripMenuItem";
            acostaSilvanaToolStripMenuItem.Size = new Size(150, 22);
            acostaSilvanaToolStripMenuItem.Text = "Acosta Silvana";
            // 
            // sanchezJuanToolStripMenuItem
            // 
            sanchezJuanToolStripMenuItem.Name = "sanchezJuanToolStripMenuItem";
            sanchezJuanToolStripMenuItem.Size = new Size(150, 22);
            sanchezJuanToolStripMenuItem.Text = "Sanchez Juan";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(93, 97);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // GenerarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 419);
            Controls.Add(monthCalendar1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "GenerarTurno";
            Text = "GenerarTurno";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Especialidades;
        private ToolStripMenuItem oftalmologíaToolStripMenuItem;
        private ToolStripMenuItem dermatologíaToolStripMenuItem;
        private ToolStripMenuItem flebologíaToolStripMenuItem;
        private ToolStripMenuItem cardiologíaToolStripMenuItem;
        private ToolStripMenuItem pediatríaToolStripMenuItem;
        private ToolStripMenuItem diabetologíaToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem médicosToolStripMenuItem;
        private ToolStripMenuItem gómezHéctorToolStripMenuItem;
        private ToolStripMenuItem acostaSilvanaToolStripMenuItem;
        private ToolStripMenuItem sanchezJuanToolStripMenuItem;
        private MonthCalendar monthCalendar1;
    }
}