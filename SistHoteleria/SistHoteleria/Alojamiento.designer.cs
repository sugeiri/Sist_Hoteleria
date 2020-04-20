namespace SistHoteleria
{
    partial class Alojamiento
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
            this.components = new System.ComponentModel.Container();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BSeguir = new System.Windows.Forms.Button();
            this.dg_Alojamientos = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LTotalN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TAlojamiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Estado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LNoches = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TReserva = new System.Windows.Forms.TextBox();
            this.TFecha_ini_Reserva = new System.Windows.Forms.TextBox();
            this.TFecha_Fin_Reserva = new System.Windows.Forms.TextBox();
            this.BReserva = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Alojamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BLimpiar.FlatAppearance.BorderSize = 2;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.Location = new System.Drawing.Point(321, 360);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(120, 38);
            this.BLimpiar.TabIndex = 13;
            this.BLimpiar.Text = "&Limpiar Todo";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BSeguir
            // 
            this.BSeguir.BackColor = System.Drawing.Color.Transparent;
            this.BSeguir.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BSeguir.FlatAppearance.BorderSize = 2;
            this.BSeguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSeguir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BSeguir.Location = new System.Drawing.Point(447, 360);
            this.BSeguir.Name = "BSeguir";
            this.BSeguir.Size = new System.Drawing.Size(120, 38);
            this.BSeguir.TabIndex = 12;
            this.BSeguir.Text = "&Guardar";
            this.BSeguir.UseVisualStyleBackColor = false;
            this.BSeguir.Click += new System.EventHandler(this.BSeguir_Click);
            // 
            // dg_Alojamientos
            // 
            this.dg_Alojamientos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_Alojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Alojamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Descr,
            this.idClie,
            this.Cant});
            this.dg_Alojamientos.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dg_Alojamientos.Location = new System.Drawing.Point(12, 19);
            this.dg_Alojamientos.Name = "dg_Alojamientos";
            this.dg_Alojamientos.Size = new System.Drawing.Size(631, 183);
            this.dg_Alojamientos.TabIndex = 9;
            this.dg_Alojamientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dg_Alojamientos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Alojamiento_CellEndEdit);
            this.dg_Alojamientos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LTotal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.LTotalN);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.dg_Alojamientos);
            this.groupBox3.Location = new System.Drawing.Point(-6, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 278);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LTotal.Location = new System.Drawing.Point(592, 250);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(36, 16);
            this.LTotal.TabIndex = 86;
            this.LTotal.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(523, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 85;
            this.label7.Text = "Total";
            // 
            // LTotalN
            // 
            this.LTotalN.AutoSize = true;
            this.LTotalN.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LTotalN.Location = new System.Drawing.Point(411, 250);
            this.LTotalN.Name = "LTotalN";
            this.LTotalN.Size = new System.Drawing.Size(36, 16);
            this.LTotalN.TabIndex = 84;
            this.LTotalN.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(309, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 83;
            this.label5.Text = "Total Noche";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Total";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(5, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 28);
            this.button5.TabIndex = 10;
            this.button5.Text = "&Limpiar Datos";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(138, 244);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 28);
            this.button6.TabIndex = 11;
            this.button6.Text = "&Borrar Fila";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(95, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "ID";
            // 
            // TAlojamiento
            // 
            this.TAlojamiento.BackColor = System.Drawing.SystemColors.Info;
            this.TAlojamiento.Location = new System.Drawing.Point(124, 3);
            this.TAlojamiento.Name = "TAlojamiento";
            this.TAlojamiento.ReadOnly = true;
            this.TAlojamiento.Size = new System.Drawing.Size(89, 20);
            this.TAlojamiento.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Llegada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Salida";
            // 
            // CB_Estado
            // 
            this.CB_Estado.FormattingEnabled = true;
            this.CB_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CB_Estado.Location = new System.Drawing.Point(545, 5);
            this.CB_Estado.Name = "CB_Estado";
            this.CB_Estado.Size = new System.Drawing.Size(86, 21);
            this.CB_Estado.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(479, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 89;
            this.label9.Text = "Estado:";
            // 
            // LNoches
            // 
            this.LNoches.AutoSize = true;
            this.LNoches.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LNoches.Location = new System.Drawing.Point(503, 33);
            this.LNoches.Name = "LNoches";
            this.LNoches.Size = new System.Drawing.Size(16, 16);
            this.LNoches.TabIndex = 92;
            this.LNoches.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(426, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 91;
            this.label10.Text = "Noches";
            // 
            // TReserva
            // 
            this.TReserva.BackColor = System.Drawing.SystemColors.Info;
            this.TReserva.Location = new System.Drawing.Point(124, 32);
            this.TReserva.Name = "TReserva";
            this.TReserva.ReadOnly = true;
            this.TReserva.Size = new System.Drawing.Size(89, 20);
            this.TReserva.TabIndex = 94;
            // 
            // TFecha_ini_Reserva
            // 
            this.TFecha_ini_Reserva.BackColor = System.Drawing.SystemColors.Info;
            this.TFecha_ini_Reserva.Location = new System.Drawing.Point(219, 32);
            this.TFecha_ini_Reserva.Name = "TFecha_ini_Reserva";
            this.TFecha_ini_Reserva.ReadOnly = true;
            this.TFecha_ini_Reserva.Size = new System.Drawing.Size(89, 20);
            this.TFecha_ini_Reserva.TabIndex = 95;
            // 
            // TFecha_Fin_Reserva
            // 
            this.TFecha_Fin_Reserva.BackColor = System.Drawing.SystemColors.Info;
            this.TFecha_Fin_Reserva.Location = new System.Drawing.Point(314, 32);
            this.TFecha_Fin_Reserva.Name = "TFecha_Fin_Reserva";
            this.TFecha_Fin_Reserva.ReadOnly = true;
            this.TFecha_Fin_Reserva.Size = new System.Drawing.Size(89, 20);
            this.TFecha_Fin_Reserva.TabIndex = 96;
            // 
            // BReserva
            // 
            this.BReserva.Location = new System.Drawing.Point(14, 29);
            this.BReserva.Name = "BReserva";
            this.BReserva.Size = new System.Drawing.Size(107, 23);
            this.BReserva.TabIndex = 97;
            this.BReserva.Text = "Reserva";
            this.BReserva.UseVisualStyleBackColor = true;
            this.BReserva.Click += new System.EventHandler(this.BReserva_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Hab";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // Descr
            // 
            this.Descr.HeaderText = "Descripcion";
            this.Descr.Name = "Descr";
            this.Descr.ReadOnly = true;
            this.Descr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descr.Width = 225;
            // 
            // idClie
            // 
            this.idClie.HeaderText = "ID Cliente";
            this.idClie.Name = "idClie";
            this.idClie.ReadOnly = true;
            this.idClie.Width = 80;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Nombre";
            this.Cant.Name = "Cant";
            this.Cant.Width = 225;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 99;
            this.button1.Text = "Oferta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(124, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 98;
            // 
            // Alojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BReserva);
            this.Controls.Add(this.TFecha_Fin_Reserva);
            this.Controls.Add(this.TFecha_ini_Reserva);
            this.Controls.Add(this.TReserva);
            this.Controls.Add(this.LNoches);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CB_Estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TAlojamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BSeguir);
            this.Name = "Alojamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alojamiento";
            this.Load += new System.EventHandler(this.Alojamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Alojamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BSeguir;
        private System.Windows.Forms.DataGridView dg_Alojamientos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TAlojamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LTotalN;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LNoches;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BReserva;
        private System.Windows.Forms.TextBox TFecha_Fin_Reserva;
        private System.Windows.Forms.TextBox TFecha_ini_Reserva;
        private System.Windows.Forms.TextBox TReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}