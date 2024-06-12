namespace Clinica_SePrice
{
    partial class frmGestionarInsumos
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
            dgvInsumos = new DataGridView();
            IdInsumo = new DataGridViewTextBoxColumn();
            NombreInsumo = new DataGridViewTextBoxColumn();
            CantidadInsumo = new DataGridViewTextBoxColumn();
            ReponerInsumo = new DataGridViewButtonColumn();
            btnAgregarInsumo = new Button();
            btnVolverInsumos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
            SuspendLayout();
            // 
            // dgvInsumos
            // 
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsumos.Columns.AddRange(new DataGridViewColumn[] { IdInsumo, NombreInsumo, CantidadInsumo, ReponerInsumo });
            dgvInsumos.Location = new Point(12, 73);
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.Size = new Size(693, 225);
            dgvInsumos.TabIndex = 0;
            dgvInsumos.CellContentClick += dgvInsumos_CellContentClick;
            dgvInsumos.CellFormatting += dgvInsumos_CellFormatting;
            // 
            // IdInsumo
            // 
            IdInsumo.HeaderText = "Id";
            IdInsumo.Name = "IdInsumo";
            IdInsumo.Resizable = DataGridViewTriState.True;
            // 
            // NombreInsumo
            // 
            NombreInsumo.HeaderText = "Nombre";
            NombreInsumo.Name = "NombreInsumo";
            NombreInsumo.Width = 200;
            // 
            // CantidadInsumo
            // 
            CantidadInsumo.HeaderText = "Cantidad";
            CantidadInsumo.Name = "CantidadInsumo";
            // 
            // ReponerInsumo
            // 
            ReponerInsumo.HeaderText = "Reponer";
            ReponerInsumo.Name = "ReponerInsumo";
            ReponerInsumo.Resizable = DataGridViewTriState.True;
            ReponerInsumo.SortMode = DataGridViewColumnSortMode.Automatic;
            ReponerInsumo.Width = 250;
            // 
            // btnAgregarInsumo
            // 
            btnAgregarInsumo.Location = new Point(534, 23);
            btnAgregarInsumo.Name = "btnAgregarInsumo";
            btnAgregarInsumo.Size = new Size(164, 23);
            btnAgregarInsumo.TabIndex = 1;
            btnAgregarInsumo.Text = "Agregar insumo";
            btnAgregarInsumo.UseVisualStyleBackColor = true;
            btnAgregarInsumo.Click += btnAgregarInsumo_Click;
            // 
            // btnVolverInsumos
            // 
            btnVolverInsumos.Location = new Point(12, 23);
            btnVolverInsumos.Name = "btnVolverInsumos";
            btnVolverInsumos.Size = new Size(75, 23);
            btnVolverInsumos.TabIndex = 2;
            btnVolverInsumos.Text = "Volver";
            btnVolverInsumos.UseVisualStyleBackColor = true;
            btnVolverInsumos.Click += btnVolverInsumos_Click;
            // 
            // frmGestionarInsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 326);
            Controls.Add(btnVolverInsumos);
            Controls.Add(btnAgregarInsumo);
            Controls.Add(dgvInsumos);
            Name = "frmGestionarInsumos";
            Text = "GestionarInsumos";
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregarInsumo;
        private Button btnVolverInsumos;
        public DataGridView dgvInsumos;
        private DataGridViewTextBoxColumn IdInsumo;
        private DataGridViewTextBoxColumn NombreInsumo;
        private DataGridViewTextBoxColumn CantidadInsumo;
        private DataGridViewButtonColumn ReponerInsumo;
    }
}