namespace SistHoteleria
{
    partial class Reserva
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
            this.dg_Reservas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LTotalN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TdescTAlojamiento = new System.Windows.Forms.TextBox();
            this.TTAlojamiento = new System.Windows.Forms.TextBox();
            this.BTAlojamiento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TReserva = new System.Windows.Forms.TextBox();
            this.TdescCliente = new System.Windows.Forms.TextBox();
            this.TCliente = new System.Windows.Forms.TextBox();
            this.BCliente = new System.Windows.Forms.Button();
            this.DT_Fecha_Ini = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DT_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.CB_Estado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LNoches = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Reservas)).BeginInit();
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
            // dg_Reservas
            // 
            this.dg_Reservas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Reservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Descr,
            this.Costo,
            this.Cant,
            this.dia,
            this.todo});
            this.dg_Reservas.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dg_Reservas.Location = new System.Drawing.Point(6, 11);
            this.dg_Reservas.Name = "dg_Reservas";
            this.dg_Reservas.Size = new System.Drawing.Size(631, 183);
            this.dg_Reservas.TabIndex = 9;
            this.dg_Reservas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dg_Reservas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Reserva_CellEndEdit);
            this.dg_Reservas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Descr
            // 
            this.Descr.HeaderText = "Descripcion";
            this.Descr.Name = "Descr";
            this.Descr.ReadOnly = true;
            this.Descr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descr.Width = 200;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 80;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            this.Cant.Width = 50;
            // 
            // dia
            // 
            this.dia.HeaderText = "Por Noche";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            this.dia.Width = 80;
            // 
            // todo
            // 
            this.todo.HeaderText = "Total";
            this.todo.Name = "todo";
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
            this.groupBox3.Controls.Add(this.dg_Reservas);
            this.groupBox3.Location = new System.Drawing.Point(-6, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 234);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LTotal.Location = new System.Drawing.Point(601, 206);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(36, 16);
            this.LTotal.TabIndex = 86;
            this.LTotal.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(532, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 85;
            this.label7.Text = "Total";
            // 
            // LTotalN
            // 
            this.LTotalN.AutoSize = true;
            this.LTotalN.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LTotalN.Location = new System.Drawing.Point(420, 206);
            this.LTotalN.Name = "LTotalN";
            this.LTotalN.Size = new System.Drawing.Size(36, 16);
            this.LTotalN.TabIndex = 84;
            this.LTotalN.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(318, 206);
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
            this.button5.Location = new System.Drawing.Point(14, 200);
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
            this.button6.Location = new System.Drawing.Point(147, 200);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 28);
            this.button6.TabIndex = 11;
            this.button6.Text = "&Borrar Fila";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TdescTAlojamiento
            // 
            this.TdescTAlojamiento.BackColor = System.Drawing.SystemColors.Info;
            this.TdescTAlojamiento.Location = new System.Drawing.Point(192, 86);
            this.TdescTAlojamiento.Name = "TdescTAlojamiento";
            this.TdescTAlojamiento.ReadOnly = true;
            this.TdescTAlojamiento.Size = new System.Drawing.Size(169, 20);
            this.TdescTAlojamiento.TabIndex = 49;
            // 
            // TTAlojamiento
            // 
            this.TTAlojamiento.Location = new System.Drawing.Point(124, 86);
            this.TTAlojamiento.Name = "TTAlojamiento";
            this.TTAlojamiento.Size = new System.Drawing.Size(62, 20);
            this.TTAlojamiento.TabIndex = 48;
            this.TTAlojamiento.Leave += new System.EventHandler(this.TTAlojamiento_Leave);
            // 
            // BTAlojamiento
            // 
            this.BTAlojamiento.Location = new System.Drawing.Point(14, 84);
            this.BTAlojamiento.Name = "BTAlojamiento";
            this.BTAlojamiento.Size = new System.Drawing.Size(107, 23);
            this.BTAlojamiento.TabIndex = 47;
            this.BTAlojamiento.Text = "T Alojamiento";
            this.BTAlojamiento.UseVisualStyleBackColor = true;
            this.BTAlojamiento.Click += new System.EventHandler(this.BTAlojamiento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(95, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "ID";
            // 
            // TReserva
            // 
            this.TReserva.BackColor = System.Drawing.SystemColors.Info;
            this.TReserva.Location = new System.Drawing.Point(124, 32);
            this.TReserva.Name = "TReserva";
            this.TReserva.ReadOnly = true;
            this.TReserva.Size = new System.Drawing.Size(89, 20);
            this.TReserva.TabIndex = 81;
            // 
            // TdescCliente
            // 
            this.TdescCliente.BackColor = System.Drawing.SystemColors.Info;
            this.TdescCliente.Location = new System.Drawing.Point(192, 60);
            this.TdescCliente.Name = "TdescCliente";
            this.TdescCliente.ReadOnly = true;
            this.TdescCliente.Size = new System.Drawing.Size(169, 20);
            this.TdescCliente.TabIndex = 84;
            // 
            // TCliente
            // 
            this.TCliente.Location = new System.Drawing.Point(124, 60);
            this.TCliente.Name = "TCliente";
            this.TCliente.Size = new System.Drawing.Size(62, 20);
            this.TCliente.TabIndex = 83;
            // 
            // BCliente
            // 
            this.BCliente.Location = new System.Drawing.Point(14, 58);
            this.BCliente.Name = "BCliente";
            this.BCliente.Size = new System.Drawing.Size(107, 23);
            this.BCliente.TabIndex = 82;
            this.BCliente.Text = "Cliente";
            this.BCliente.UseVisualStyleBackColor = true;
            this.BCliente.Click += new System.EventHandler(this.BCliente_Click);
            // 
            // DT_Fecha_Ini
            // 
            this.DT_Fecha_Ini.Location = new System.Drawing.Point(417, 57);
            this.DT_Fecha_Ini.Name = "DT_Fecha_Ini";
            this.DT_Fecha_Ini.Size = new System.Drawing.Size(122, 20);
            this.DT_Fecha_Ini.TabIndex = 85;
            this.DT_Fecha_Ini.ValueChanged += new System.EventHandler(this.DT_Fecha_Ini_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Llegada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Salida";
            // 
            // DT_Fecha_Fin
            // 
            this.DT_Fecha_Fin.Location = new System.Drawing.Point(417, 83);
            this.DT_Fecha_Fin.Name = "DT_Fecha_Fin";
            this.DT_Fecha_Fin.Size = new System.Drawing.Size(122, 20);
            this.DT_Fecha_Fin.TabIndex = 87;
            this.DT_Fecha_Fin.ValueChanged += new System.EventHandler(this.DT_Fecha_Fin_ValueChanged);
            // 
            // CB_Estado
            // 
            this.CB_Estado.FormattingEnabled = true;
            this.CB_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CB_Estado.Location = new System.Drawing.Point(288, 32);
            this.CB_Estado.Name = "CB_Estado";
            this.CB_Estado.Size = new System.Drawing.Size(86, 21);
            this.CB_Estado.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(222, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 89;
            this.label9.Text = "Estado:";
            // 
            // LNoches
            // 
            this.LNoches.AutoSize = true;
            this.LNoches.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LNoches.Location = new System.Drawing.Point(583, 61);
            this.LNoches.Name = "LNoches";
            this.LNoches.Size = new System.Drawing.Size(16, 16);
            this.LNoches.TabIndex = 92;
            this.LNoches.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(560, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 91;
            this.label10.Text = "Noches";
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 415);
            this.Controls.Add(this.LNoches);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CB_Estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DT_Fecha_Fin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DT_Fecha_Ini);
            this.Controls.Add(this.TdescCliente);
            this.Controls.Add(this.TCliente);
            this.Controls.Add(this.BCliente);
            this.Controls.Add(this.TReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TdescTAlojamiento);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TTAlojamiento);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BTAlojamiento);
            this.Controls.Add(this.BSeguir);
            this.Name = "Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Reservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BSeguir;
        private System.Windows.Forms.DataGridView dg_Reservas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox TdescTAlojamiento;
        private System.Windows.Forms.TextBox TTAlojamiento;
        private System.Windows.Forms.Button BTAlojamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TdescCliente;
        private System.Windows.Forms.TextBox TCliente;
        private System.Windows.Forms.Button BCliente;
        private System.Windows.Forms.TextBox TReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DT_Fecha_Fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DT_Fecha_Ini;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LTotalN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LNoches;
        private System.Windows.Forms.Label label10;
    }
}