namespace SistHoteleria
{
    partial class C_Alojamiento
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
            this.TAlojamiento = new System.Windows.Forms.TextBox();
            this.CB_Estado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.TReserva = new System.Windows.Forms.TextBox();
            this.BImprimir = new System.Windows.Forms.Button();
            this.BReserva = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIdentif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Datos
            // 
            this.DG_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Identificacion,
            this.LicRE,
            this.TIdentif});
            this.DG_Datos.Location = new System.Drawing.Point(18, 43);
            this.DG_Datos.Name = "DG_Datos";
            this.DG_Datos.Size = new System.Drawing.Size(565, 313);
            this.DG_Datos.TabIndex = 30;
            this.DG_Datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Datos_CellDoubleClick);
            this.DG_Datos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Datos_CellMouseDoubleClick);
            this.DG_Datos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.DG_Datos_PreviewKeyDown);
            // 
            // TAlojamiento
            // 
            this.TAlojamiento.Location = new System.Drawing.Point(56, 14);
            this.TAlojamiento.Name = "TAlojamiento";
            this.TAlojamiento.Size = new System.Drawing.Size(114, 20);
            this.TAlojamiento.TabIndex = 44;
            this.TAlojamiento.TextChanged += new System.EventHandler(this.TCodigo_TextChanged);
            // 
            // CB_Estado
            // 
            this.CB_Estado.FormattingEnabled = true;
            this.CB_Estado.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.CB_Estado.Location = new System.Drawing.Point(497, 14);
            this.CB_Estado.Name = "CB_Estado";
            this.CB_Estado.Size = new System.Drawing.Size(86, 21);
            this.CB_Estado.TabIndex = 49;
            this.CB_Estado.SelectedIndexChanged += new System.EventHandler(this.CB_Estado_Servicio_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(428, 19);
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
            this.BLimpiar.Location = new System.Drawing.Point(463, 399);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(120, 36);
            this.BLimpiar.TabIndex = 51;
            this.BLimpiar.Text = "&Limpiar Filtro";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // TReserva
            // 
            this.TReserva.Location = new System.Drawing.Point(289, 15);
            this.TReserva.Name = "TReserva";
            this.TReserva.Size = new System.Drawing.Size(123, 20);
            this.TReserva.TabIndex = 53;
            this.TReserva.TextChanged += new System.EventHandler(this.TTipo_TextChanged);
            // 
            // BImprimir
            // 
            this.BImprimir.BackColor = System.Drawing.Color.Transparent;
            this.BImprimir.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BImprimir.FlatAppearance.BorderSize = 2;
            this.BImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BImprimir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BImprimir.Location = new System.Drawing.Point(361, 398);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(96, 36);
            this.BImprimir.TabIndex = 60;
            this.BImprimir.Text = "&IMPRIMIR";
            this.BImprimir.UseVisualStyleBackColor = false;
            this.BImprimir.Click += new System.EventHandler(this.BImprimir_Click);
            // 
            // BReserva
            // 
            this.BReserva.Location = new System.Drawing.Point(176, 14);
            this.BReserva.Name = "BReserva";
            this.BReserva.Size = new System.Drawing.Size(107, 23);
            this.BReserva.TabIndex = 101;
            this.BReserva.Text = "Reserva";
            this.BReserva.UseVisualStyleBackColor = true;
            this.BReserva.Click += new System.EventHandler(this.BReserva_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(28, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 98;
            this.label5.Text = "ID";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Alojamiento";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Reservacion";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Fecha Ini";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // LicRE
            // 
            this.LicRE.HeaderText = "Fecha fin";
            this.LicRE.Name = "LicRE";
            this.LicRE.ReadOnly = true;
            // 
            // TIdentif
            // 
            this.TIdentif.HeaderText = "Estado";
            this.TIdentif.Name = "TIdentif";
            this.TIdentif.ReadOnly = true;
            this.TIdentif.Width = 50;
            // 
            // C_Alojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 447);
            this.Controls.Add(this.BReserva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BImprimir);
            this.Controls.Add(this.TReserva);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.CB_Estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TAlojamiento);
            this.Controls.Add(this.DG_Datos);
            this.Name = "C_Alojamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C_Alojamiento";
            this.Load += new System.EventHandler(this.C_Alojamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Datos;
        private System.Windows.Forms.TextBox TAlojamiento;
        private System.Windows.Forms.ComboBox CB_Estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.TextBox TReserva;
        private System.Windows.Forms.Button BImprimir;
        private System.Windows.Forms.Button BReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIdentif;
    }
}