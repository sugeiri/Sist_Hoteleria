namespace SistHoteleria
{
    partial class R_Reserva
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
            this.TCliente = new System.Windows.Forms.TextBox();
            this.TCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BCrear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TdescTAlojamiento = new System.Windows.Forms.TextBox();
            this.TTAlojamiento = new System.Windows.Forms.TextBox();
            this.BTAlojamiento = new System.Windows.Forms.Button();
            this.BCliente = new System.Windows.Forms.Button();
            this.TdescCliente = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTAloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Datos
            // 
            this.DG_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.idCliente,
            this.Nombre,
            this.idTAloj,
            this.TAloj,
            this.Fecha_Ini,
            this.Fecha_fin,
            this.Monto,
            this.status});
            this.DG_Datos.Location = new System.Drawing.Point(15, 101);
            this.DG_Datos.Name = "DG_Datos";
            this.DG_Datos.Size = new System.Drawing.Size(623, 334);
            this.DG_Datos.TabIndex = 30;
            this.DG_Datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Datos_CellDoubleClick);
            this.DG_Datos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Datos_CellMouseDoubleClick);
            this.DG_Datos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.DG_Datos_PreviewKeyDown);
            // 
            // TCliente
            // 
            this.TCliente.Location = new System.Drawing.Point(163, 29);
            this.TCliente.Name = "TCliente";
            this.TCliente.Size = new System.Drawing.Size(62, 20);
            this.TCliente.TabIndex = 36;
            this.TCliente.TextChanged += new System.EventHandler(this.TNombreTercero_TextChanged);
            // 
            // TCodigo
            // 
            this.TCodigo.Location = new System.Drawing.Point(163, 1);
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.Size = new System.Drawing.Size(62, 20);
            this.TCodigo.TabIndex = 44;
            this.TCodigo.TextChanged += new System.EventHandler(this.TCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID:";
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BLimpiar.FlatAppearance.BorderSize = 2;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BLimpiar.Location = new System.Drawing.Point(659, 112);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(120, 36);
            this.BLimpiar.TabIndex = 51;
            this.BLimpiar.Text = "&Limpiar Filtro";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BCrear
            // 
            this.BCrear.BackColor = System.Drawing.Color.Transparent;
            this.BCrear.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BCrear.FlatAppearance.BorderSize = 2;
            this.BCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCrear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BCrear.Location = new System.Drawing.Point(659, 151);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(120, 36);
            this.BCrear.TabIndex = 61;
            this.BCrear.Text = "&CREAR";
            this.BCrear.UseVisualStyleBackColor = false;
            this.BCrear.Click += new System.EventHandler(this.BCrear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(659, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 60;
            this.button1.Text = "&CONSULTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TdescTAlojamiento
            // 
            this.TdescTAlojamiento.BackColor = System.Drawing.SystemColors.Window;
            this.TdescTAlojamiento.Location = new System.Drawing.Point(231, 55);
            this.TdescTAlojamiento.Name = "TdescTAlojamiento";
            this.TdescTAlojamiento.Size = new System.Drawing.Size(349, 20);
            this.TdescTAlojamiento.TabIndex = 79;
            this.TdescTAlojamiento.TextChanged += new System.EventHandler(this.TDescConsultorio_TextChanged);
            // 
            // TTAlojamiento
            // 
            this.TTAlojamiento.Location = new System.Drawing.Point(163, 55);
            this.TTAlojamiento.Name = "TTAlojamiento";
            this.TTAlojamiento.Size = new System.Drawing.Size(62, 20);
            this.TTAlojamiento.TabIndex = 78;
            this.TTAlojamiento.TextChanged += new System.EventHandler(this.TConsultorio_TextChanged);
            // 
            // BTAlojamiento
            // 
            this.BTAlojamiento.Location = new System.Drawing.Point(59, 55);
            this.BTAlojamiento.Name = "BTAlojamiento";
            this.BTAlojamiento.Size = new System.Drawing.Size(98, 23);
            this.BTAlojamiento.TabIndex = 77;
            this.BTAlojamiento.Text = "&TAlojamiento";
            this.BTAlojamiento.UseVisualStyleBackColor = true;
            this.BTAlojamiento.Click += new System.EventHandler(this.BConsultorio_Click);
            // 
            // BCliente
            // 
            this.BCliente.Location = new System.Drawing.Point(59, 29);
            this.BCliente.Name = "BCliente";
            this.BCliente.Size = new System.Drawing.Size(98, 23);
            this.BCliente.TabIndex = 80;
            this.BCliente.Text = "&Cliente";
            this.BCliente.UseVisualStyleBackColor = true;
            this.BCliente.Click += new System.EventHandler(this.BCliente_Click);
            // 
            // TdescCliente
            // 
            this.TdescCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TdescCliente.Location = new System.Drawing.Point(231, 29);
            this.TdescCliente.Name = "TdescCliente";
            this.TdescCliente.Size = new System.Drawing.Size(349, 20);
            this.TdescCliente.TabIndex = 81;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "idC";
            this.idCliente.Name = "idCliente";
            this.idCliente.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Cliente";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // idTAloj
            // 
            this.idTAloj.HeaderText = "idTAloj";
            this.idTAloj.Name = "idTAloj";
            this.idTAloj.Visible = false;
            // 
            // TAloj
            // 
            this.TAloj.HeaderText = "T Alojamiento";
            this.TAloj.Name = "TAloj";
            this.TAloj.Width = 125;
            // 
            // Fecha_Ini
            // 
            this.Fecha_Ini.HeaderText = "Fecha ini";
            this.Fecha_Ini.Name = "Fecha_Ini";
            this.Fecha_Ini.ReadOnly = true;
            this.Fecha_Ini.Width = 70;
            // 
            // Fecha_fin
            // 
            this.Fecha_fin.HeaderText = "Fecha Fin";
            this.Fecha_fin.Name = "Fecha_fin";
            this.Fecha_fin.Width = 70;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 70;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Width = 50;
            // 
            // R_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 447);
            this.Controls.Add(this.TdescCliente);
            this.Controls.Add(this.BCliente);
            this.Controls.Add(this.TdescTAlojamiento);
            this.Controls.Add(this.TTAlojamiento);
            this.Controls.Add(this.BTAlojamiento);
            this.Controls.Add(this.BCrear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TCodigo);
            this.Controls.Add(this.TCliente);
            this.Controls.Add(this.DG_Datos);
            this.Name = "R_Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C_Reserva";
            this.Load += new System.EventHandler(this.C_Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Datos;
        private System.Windows.Forms.TextBox TCliente;
        private System.Windows.Forms.TextBox TCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BCrear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TdescTAlojamiento;
        private System.Windows.Forms.TextBox TTAlojamiento;
        private System.Windows.Forms.Button BTAlojamiento;
        private System.Windows.Forms.Button BCliente;
        private System.Windows.Forms.TextBox TdescCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTAloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ini;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}