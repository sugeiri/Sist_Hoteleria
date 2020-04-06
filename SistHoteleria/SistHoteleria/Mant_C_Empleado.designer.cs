namespace SistHoteleria
{
    partial class Mant_C_Empleado
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
            this.DG_Datos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIdentif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Estado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Datos
            // 
            this.DG_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.TIdentif,
            this.Identificacion});
            this.DG_Datos.Location = new System.Drawing.Point(15, 122);
            this.DG_Datos.Name = "DG_Datos";
            this.DG_Datos.Size = new System.Drawing.Size(565, 313);
            this.DG_Datos.TabIndex = 30;
            this.DG_Datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Datos_CellDoubleClick);
            this.DG_Datos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Datos_CellMouseDoubleClick);
            this.DG_Datos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.DG_Datos_PreviewKeyDown);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Usuario";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // TIdentif
            // 
            this.TIdentif.HeaderText = "Estado";
            this.TIdentif.Name = "TIdentif";
            this.TIdentif.ReadOnly = true;
            this.TIdentif.Width = 50;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Tipo Usuario";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(109, 46);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(471, 20);
            this.TNombre.TabIndex = 36;
            this.TNombre.TextChanged += new System.EventHandler(this.TDescripcion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "NOMBRE:";
            // 
            // TEmpleado
            // 
            this.TEmpleado.Location = new System.Drawing.Point(109, 16);
            this.TEmpleado.Name = "TEmpleado";
            this.TEmpleado.Size = new System.Drawing.Size(196, 20);
            this.TEmpleado.TabIndex = 44;
            this.TEmpleado.TextChanged += new System.EventHandler(this.TCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Empleado:";
            // 
            // CB_Estado
            // 
            this.CB_Estado.FormattingEnabled = true;
            this.CB_Estado.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.CB_Estado.Location = new System.Drawing.Point(494, 12);
            this.CB_Estado.Name = "CB_Estado";
            this.CB_Estado.Size = new System.Drawing.Size(86, 21);
            this.CB_Estado.TabIndex = 49;
            this.CB_Estado.SelectedIndexChanged += new System.EventHandler(this.CB_Estado_Servicio_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(431, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Estado:";
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BLimpiar.FlatAppearance.BorderSize = 2;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BLimpiar.Location = new System.Drawing.Point(463, 80);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(120, 36);
            this.BLimpiar.TabIndex = 51;
            this.BLimpiar.Text = "&Limpiar Filtro";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // Mant_C_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 447);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.CB_Estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TEmpleado);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DG_Datos);
            this.Name = "Mant_C_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mant_C_Empleado";
            this.Load += new System.EventHandler(this.Mant_C_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Datos;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIdentif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
    }
}