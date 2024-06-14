namespace Clinica_SePrice
{
    partial class frmAgregarInsumo
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
            btnAgregar = new Button();
            lblNombreInsumo = new Label();
            lblCantidadInsumo = new Label();
            txtNombreInsumo = new TextBox();
            txtCantidadInsumo = new TextBox();
            txtIdInsumo = new TextBox();
            lblIdInsumo = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(123, 169);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 34);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNombreInsumo
            // 
            lblNombreInsumo.AutoSize = true;
            lblNombreInsumo.Location = new Point(27, 81);
            lblNombreInsumo.Name = "lblNombreInsumo";
            lblNombreInsumo.Size = new Size(51, 15);
            lblNombreInsumo.TabIndex = 5;
            lblNombreInsumo.Text = "Nombre";
            // 
            // lblCantidadInsumo
            // 
            lblCantidadInsumo.AutoSize = true;
            lblCantidadInsumo.Location = new Point(27, 126);
            lblCantidadInsumo.Name = "lblCantidadInsumo";
            lblCantidadInsumo.Size = new Size(55, 15);
            lblCantidadInsumo.TabIndex = 6;
            lblCantidadInsumo.Text = "Cantidad";
            // 
            // txtNombreInsumo
            // 
            txtNombreInsumo.Location = new Point(163, 78);
            txtNombreInsumo.Name = "txtNombreInsumo";
            txtNombreInsumo.Size = new Size(167, 23);
            txtNombreInsumo.TabIndex = 1;
            // 
            // txtCantidadInsumo
            // 
            txtCantidadInsumo.Location = new Point(163, 123);
            txtCantidadInsumo.Name = "txtCantidadInsumo";
            txtCantidadInsumo.Size = new Size(167, 23);
            txtCantidadInsumo.TabIndex = 2;
            // 
            // txtIdInsumo
            // 
            txtIdInsumo.Location = new Point(163, 36);
            txtIdInsumo.Name = "txtIdInsumo";
            txtIdInsumo.Size = new Size(167, 23);
            txtIdInsumo.TabIndex = 0;
            // 
            // lblIdInsumo
            // 
            lblIdInsumo.AutoSize = true;
            lblIdInsumo.Location = new Point(27, 39);
            lblIdInsumo.Name = "lblIdInsumo";
            lblIdInsumo.Size = new Size(79, 15);
            lblIdInsumo.TabIndex = 4;
            lblIdInsumo.Text = "Id del insumo";
            // 
            // frmAgregarInsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 231);
            Controls.Add(lblIdInsumo);
            Controls.Add(txtIdInsumo);
            Controls.Add(txtCantidadInsumo);
            Controls.Add(txtNombreInsumo);
            Controls.Add(lblCantidadInsumo);
            Controls.Add(lblNombreInsumo);
            Controls.Add(btnAgregar);
            Name = "frmAgregarInsumo";
            Text = "AgregarInsumo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label lblNombreInsumo;
        private Label lblCantidadInsumo;
        private TextBox txtNombreInsumo;
        private TextBox txtCantidadInsumo;
        private TextBox txtIdInsumo;
        private Label lblIdInsumo;
    }
}