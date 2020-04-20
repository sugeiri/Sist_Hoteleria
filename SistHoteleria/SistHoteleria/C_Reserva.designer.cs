namespace SistHoteleria
{
    partial class C_Reserva
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TdescTAlojamiento = new System.Windows.Forms.TextBox();
            this.TTAlojamiento = new System.Windows.Forms.TextBox();
            this.BTAlojamiento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TReserva = new System.Windows.Forms.TextBox();
            this.TdescCliente = new System.Windows.Forms.TextBox();
            this.TCliente = new System.Windows.Forms.TextBox();
            this.BCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Estado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TNoches = new System.Windows.Forms.TextBox();
            this.TTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TFecha_Ini = new System.Windows.Forms.TextBox();
            this.TFecha_Fin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BLimpiar.FlatAppearance.BorderSize = 2;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.Location = new System.Drawing.Point(115, 204);
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
            this.BSeguir.Location = new System.Drawing.Point(241, 204);
            this.BSeguir.Name = "BSeguir";
            this.BSeguir.Size = new System.Drawing.Size(120, 38);
            this.BSeguir.TabIndex = 12;
            this.BSeguir.Text = "&Consultar";
            this.BSeguir.UseVisualStyleBackColor = false;
            this.BSeguir.Click += new System.EventHandler(this.BSeguir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.TReserva.BackColor = System.Drawing.SystemColors.Window;
            this.TReserva.Location = new System.Drawing.Point(124, 32);
            this.TReserva.Name = "TReserva";
            this.TReserva.Size = new System.Drawing.Size(79, 20);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(196, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Llegada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(204, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "Salida";
            // 
            // CB_Estado
            // 
            this.CB_Estado.FormattingEnabled = true;
            this.CB_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CB_Estado.Location = new System.Drawing.Point(275, 31);
            this.CB_Estado.Name = "CB_Estado";
            this.CB_Estado.Size = new System.Drawing.Size(86, 21);
            this.CB_Estado.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(209, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 89;
            this.label9.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(60, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 91;
            this.label10.Text = "Noches";
            // 
            // TNoches
            // 
            this.TNoches.Location = new System.Drawing.Point(124, 115);
            this.TNoches.Name = "TNoches";
            this.TNoches.Size = new System.Drawing.Size(62, 20);
            this.TNoches.TabIndex = 92;
            // 
            // TTotal
            // 
            this.TTotal.Location = new System.Drawing.Point(124, 147);
            this.TTotal.Name = "TTotal";
            this.TTotal.Size = new System.Drawing.Size(62, 20);
            this.TTotal.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(76, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 94;
            this.label4.Text = "Total";
            // 
            // TFecha_Ini
            // 
            this.TFecha_Ini.Location = new System.Drawing.Point(260, 118);
            this.TFecha_Ini.Name = "TFecha_Ini";
            this.TFecha_Ini.Size = new System.Drawing.Size(101, 20);
            this.TFecha_Ini.TabIndex = 95;
            // 
            // TFecha_Fin
            // 
            this.TFecha_Fin.Location = new System.Drawing.Point(260, 145);
            this.TFecha_Fin.Name = "TFecha_Fin";
            this.TFecha_Fin.Size = new System.Drawing.Size(101, 20);
            this.TFecha_Fin.TabIndex = 96;
            // 
            // C_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 268);
            this.Controls.Add(this.TFecha_Fin);
            this.Controls.Add(this.TFecha_Ini);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TTotal);
            this.Controls.Add(this.TNoches);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CB_Estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TdescCliente);
            this.Controls.Add(this.TCliente);
            this.Controls.Add(this.BCliente);
            this.Controls.Add(this.TReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TdescTAlojamiento);
            this.Controls.Add(this.TTAlojamiento);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BTAlojamiento);
            this.Controls.Add(this.BSeguir);
            this.Name = "C_Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BSeguir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TdescTAlojamiento;
        private System.Windows.Forms.TextBox TTAlojamiento;
        private System.Windows.Forms.Button BTAlojamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TdescCliente;
        private System.Windows.Forms.TextBox TCliente;
        private System.Windows.Forms.Button BCliente;
        private System.Windows.Forms.TextBox TReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TFecha_Fin;
        private System.Windows.Forms.TextBox TFecha_Ini;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TTotal;
        private System.Windows.Forms.TextBox TNoches;
    }
}