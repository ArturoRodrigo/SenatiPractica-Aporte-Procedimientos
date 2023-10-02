namespace SenatiPractica.presentacion
{
    partial class FrmMenuPrincipalInstructor
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
            this.btnIngresarI = new System.Windows.Forms.Button();
            this.btnEditarI = new System.Windows.Forms.Button();
            this.btnEliminarI = new System.Windows.Forms.Button();
            this.btnBuscarI = new System.Windows.Forms.Button();
            this.btnRefrescarI = new System.Windows.Forms.Button();
            this.dgvInstructores = new System.Windows.Forms.DataGridView();
            this.btnSalirI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarI
            // 
            this.btnIngresarI.Location = new System.Drawing.Point(38, 61);
            this.btnIngresarI.Name = "btnIngresarI";
            this.btnIngresarI.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarI.TabIndex = 0;
            this.btnIngresarI.Text = "Ingresar";
            this.btnIngresarI.UseVisualStyleBackColor = true;
            // 
            // btnEditarI
            // 
            this.btnEditarI.Location = new System.Drawing.Point(38, 109);
            this.btnEditarI.Name = "btnEditarI";
            this.btnEditarI.Size = new System.Drawing.Size(75, 23);
            this.btnEditarI.TabIndex = 1;
            this.btnEditarI.Text = "Editar";
            this.btnEditarI.UseVisualStyleBackColor = true;
            // 
            // btnEliminarI
            // 
            this.btnEliminarI.Location = new System.Drawing.Point(38, 156);
            this.btnEliminarI.Name = "btnEliminarI";
            this.btnEliminarI.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarI.TabIndex = 2;
            this.btnEliminarI.Text = "Eliminar";
            this.btnEliminarI.UseVisualStyleBackColor = true;
            // 
            // btnBuscarI
            // 
            this.btnBuscarI.Location = new System.Drawing.Point(38, 204);
            this.btnBuscarI.Name = "btnBuscarI";
            this.btnBuscarI.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarI.TabIndex = 3;
            this.btnBuscarI.Text = "Buscar";
            this.btnBuscarI.UseVisualStyleBackColor = true;
            // 
            // btnRefrescarI
            // 
            this.btnRefrescarI.Location = new System.Drawing.Point(38, 254);
            this.btnRefrescarI.Name = "btnRefrescarI";
            this.btnRefrescarI.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescarI.TabIndex = 4;
            this.btnRefrescarI.Text = "Refrescar";
            this.btnRefrescarI.UseVisualStyleBackColor = true;
            // 
            // dgvInstructores
            // 
            this.dgvInstructores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructores.Location = new System.Drawing.Point(162, 61);
            this.dgvInstructores.Name = "dgvInstructores";
            this.dgvInstructores.Size = new System.Drawing.Size(604, 216);
            this.dgvInstructores.TabIndex = 5;
            // 
            // btnSalirI
            // 
            this.btnSalirI.Location = new System.Drawing.Point(358, 312);
            this.btnSalirI.Name = "btnSalirI";
            this.btnSalirI.Size = new System.Drawing.Size(75, 23);
            this.btnSalirI.TabIndex = 6;
            this.btnSalirI.Text = "Salir";
            this.btnSalirI.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipalInstructor
            // 
            this.ClientSize = new System.Drawing.Size(798, 407);
            this.Controls.Add(this.btnSalirI);
            this.Controls.Add(this.dgvInstructores);
            this.Controls.Add(this.btnRefrescarI);
            this.Controls.Add(this.btnBuscarI);
            this.Controls.Add(this.btnEliminarI);
            this.Controls.Add(this.btnEditarI);
            this.Controls.Add(this.btnIngresarI);
            this.Name = "FrmMenuPrincipalInstructor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresarI;
        private System.Windows.Forms.Button btnEditarI;
        private System.Windows.Forms.Button btnEliminarI;
        private System.Windows.Forms.Button btnBuscarI;
        private System.Windows.Forms.Button btnRefrescarI;
        private System.Windows.Forms.DataGridView dgvInstructores;
        private System.Windows.Forms.Button btnSalirI;
    }
}