namespace SistHoteleria
{
    partial class C_Mantenimiento
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
            this.BLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TCodigo = new System.Windows.Forms.TextBox();
            this.TFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Estado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BConsultar = new System.Windows.Forms.Button();
            this.BImprimir = new System.Windows.Forms.Button();
            this.LSuma = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.THabitacion = new System.Windows.Forms.TextBox();
            this.TipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Datos
            // 
            this.DG_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoFactura,
            this.Numero,
            this.Estado,
            this.Fecha,
            this.Hora});
            this.DG_Datos.Location = new System.Drawing.Point(15, 135);
            this.DG_Datos.Name = "DG_Datos";
            this.DG_Datos.ReadOnly = true;
            this.DG_Datos.Size = new System.Drawing.Size(521, 359);
            this.DG_Datos.TabIndex = 15;
            this.DG_Datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Datos_CellDoubleClick);
            this.DG_Datos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Datos_CellMouseDoubleClick);
            this.DG_Datos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_DATOS_RowEnter);
            this.DG_Datos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.DG_Datos_PreviewKeyDown);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BLimpiar.FlatAppearance.BorderSize = 2;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BLimpiar.Location = new System.Drawing.Point(407, 94);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(120, 36);
            this.BLimpiar.TabIndex = 69;
            this.BLimpiar.Text = "&Limpiar Filtro";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Mantenimiento:";
            // 
            // TCodigo
            // 
            this.TCodigo.Location = new System.Drawing.Point(158, 14);
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.Size = new System.Drawing.Size(100, 20);
            this.TCodigo.TabIndex = 65;
            this.TCodigo.TextChanged += new System.EventHandler(this.TCodigo_TextChanged);
            // 
            // TFecha
            // 
            this.TFecha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TFecha.Location = new System.Drawing.Point(158, 40);
            this.TFecha.Name = "TFecha";
            this.TFecha.Size = new System.Drawing.Size(261, 23);
            this.TFecha.TabIndex = 100;
            this.TFecha.TextChanged += new System.EventHandler(this.TFecha_TextChanged);
            this.TFecha.Leave += new System.EventHandler(this.TFecha_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "Fecha:";
            // 
            // CB_Estado
            // 
            this.CB_Estado.FormattingEnabled = true;
            this.CB_Estado.Items.AddRange(new object[] {
            "TODAS",
            "ACTIVAS",
            "NULAS"});
            this.CB_Estado.Location = new System.Drawing.Point(338, 14);
            this.CB_Estado.Name = "CB_Estado";
            this.CB_Estado.Size = new System.Drawing.Size(81, 21);
            this.CB_Estado.TabIndex = 103;
            this.CB_Estado.SelectedIndexChanged += new System.EventHandler(this.CB_Estado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 104;
            this.label3.Text = "Estado:";
            // 
            // BConsultar
            // 
            this.BConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BConsultar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BConsultar.FlatAppearance.BorderSize = 2;
            this.BConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BConsultar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BConsultar.Location = new System.Drawing.Point(30, 94);
            this.BConsultar.Name = "BConsultar";
            this.BConsultar.Size = new System.Drawing.Size(120, 36);
            this.BConsultar.TabIndex = 106;
            this.BConsultar.Text = "&Consultar";
            this.BConsultar.UseVisualStyleBackColor = false;
            this.BConsultar.Click += new System.EventHandler(this.BConsultar_Click);
            // 
            // BImprimir
            // 
            this.BImprimir.BackColor = System.Drawing.Color.Transparent;
            this.BImprimir.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BImprimir.FlatAppearance.BorderSize = 2;
            this.BImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BImprimir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BImprimir.Location = new System.Drawing.Point(281, 94);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(120, 36);
            this.BImprimir.TabIndex = 105;
            this.BImprimir.Text = "&Imprimir";
            this.BImprimir.UseVisualStyleBackColor = false;
            this.BImprimir.Click += new System.EventHandler(this.BImprimir_Click);
            // 
            // LSuma
            // 
            this.LSuma.AutoSize = true;
            this.LSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSuma.Location = new System.Drawing.Point(440, 14);
            this.LSuma.Name = "LSuma";
            this.LSuma.Size = new System.Drawing.Size(0, 17);
            this.LSuma.TabIndex = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 121;
            this.label4.Text = "TipoHabitacion:";
            // 
            // THabitacion
            // 
            this.THabitacion.Location = new System.Drawing.Point(158, 69);
            this.THabitacion.Name = "THabitacion";
            this.THabitacion.Size = new System.Drawing.Size(100, 20);
            this.THabitacion.TabIndex = 120;
            this.THabitacion.TextChanged += new System.EventHandler(this.THabitacion_TextChanged);
            // 
            // TipoFactura
            // 
            this.TipoFactura.HeaderText = "Mantenimiento";
            this.TipoFactura.Name = "TipoFactura";
            this.TipoFactura.ReadOnly = true;
            this.TipoFactura.Width = 90;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "TipoHab";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 110;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 80;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(155, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 107;
            this.button1.Text = "&Ver Detalle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // C_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 525);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.THabitacion);
            this.Controls.Add(this.LSuma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BConsultar);
            this.Controls.Add(this.BImprimir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TFecha);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TCodigo);
            this.Controls.Add(this.DG_Datos);
            this.Name = "C_Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C_Mantenimiento";
            this.Load += new System.EventHandler(this.C_Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Datos;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCodigo;
        private System.Windows.Forms.TextBox TFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BConsultar;
        private System.Windows.Forms.Button BImprimir;
        private System.Windows.Forms.Label LSuma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox THabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Button button1;
    }
}