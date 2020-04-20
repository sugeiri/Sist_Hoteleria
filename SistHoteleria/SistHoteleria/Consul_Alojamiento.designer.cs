namespace SistHoteleria
{
    partial class Consul_Alojamiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.TAlojamiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TFecha_Ini = new System.Windows.Forms.TextBox();
            this.TFecha_Fin = new System.Windows.Forms.TextBox();
            this.TStatus = new System.Windows.Forms.TextBox();
            this.BReserva = new System.Windows.Forms.Button();
            this.TReserva = new System.Windows.Forms.TextBox();
            this.TIng_por = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TSal_por = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.BLimpiar.Location = new System.Drawing.Point(16, 239);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(99, 38);
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
            this.BSeguir.Location = new System.Drawing.Point(121, 239);
            this.BSeguir.Name = "BSeguir";
            this.BSeguir.Size = new System.Drawing.Size(99, 38);
            this.BSeguir.TabIndex = 12;
            this.BSeguir.Text = "&Consultar";
            this.BSeguir.UseVisualStyleBackColor = false;
            this.BSeguir.Click += new System.EventHandler(this.BSeguir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // TAlojamiento
            // 
            this.TAlojamiento.BackColor = System.Drawing.SystemColors.Window;
            this.TAlojamiento.Location = new System.Drawing.Point(124, 32);
            this.TAlojamiento.Name = "TAlojamiento";
            this.TAlojamiento.Size = new System.Drawing.Size(79, 20);
            this.TAlojamiento.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(55, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Llegada";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(68, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "Salida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 89;
            this.label9.Text = "Estado:";
            // 
            // TFecha_Ini
            // 
            this.TFecha_Ini.Location = new System.Drawing.Point(124, 84);
            this.TFecha_Ini.Name = "TFecha_Ini";
            this.TFecha_Ini.Size = new System.Drawing.Size(101, 20);
            this.TFecha_Ini.TabIndex = 95;
            this.TFecha_Ini.TextChanged += new System.EventHandler(this.TFecha_Ini_TextChanged);
            // 
            // TFecha_Fin
            // 
            this.TFecha_Fin.Location = new System.Drawing.Point(124, 136);
            this.TFecha_Fin.Name = "TFecha_Fin";
            this.TFecha_Fin.Size = new System.Drawing.Size(101, 20);
            this.TFecha_Fin.TabIndex = 96;
            // 
            // TStatus
            // 
            this.TStatus.Location = new System.Drawing.Point(124, 188);
            this.TStatus.Name = "TStatus";
            this.TStatus.Size = new System.Drawing.Size(101, 20);
            this.TStatus.TabIndex = 97;
            // 
            // BReserva
            // 
            this.BReserva.Location = new System.Drawing.Point(11, 57);
            this.BReserva.Name = "BReserva";
            this.BReserva.Size = new System.Drawing.Size(107, 23);
            this.BReserva.TabIndex = 103;
            this.BReserva.Text = "Reserva";
            this.BReserva.UseVisualStyleBackColor = true;
            this.BReserva.Click += new System.EventHandler(this.BReserva_Click);
            // 
            // TReserva
            // 
            this.TReserva.Location = new System.Drawing.Point(124, 58);
            this.TReserva.Name = "TReserva";
            this.TReserva.Size = new System.Drawing.Size(79, 20);
            this.TReserva.TabIndex = 102;
            // 
            // TIng_por
            // 
            this.TIng_por.Location = new System.Drawing.Point(124, 110);
            this.TIng_por.Name = "TIng_por";
            this.TIng_por.Size = new System.Drawing.Size(101, 20);
            this.TIng_por.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(55, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 104;
            this.label4.Text = "Ing Por";
            // 
            // TSal_por
            // 
            this.TSal_por.Location = new System.Drawing.Point(124, 162);
            this.TSal_por.Name = "TSal_por";
            this.TSal_por.Size = new System.Drawing.Size(101, 20);
            this.TSal_por.TabIndex = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(58, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 106;
            this.label5.Text = "Sal Por";
            // 
            // Consul_Alojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 289);
            this.Controls.Add(this.TSal_por);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TIng_por);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BReserva);
            this.Controls.Add(this.TReserva);
            this.Controls.Add(this.TStatus);
            this.Controls.Add(this.TFecha_Fin);
            this.Controls.Add(this.TFecha_Ini);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TAlojamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BSeguir);
            this.Name = "Consul_Alojamiento";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TAlojamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TFecha_Fin;
        private System.Windows.Forms.TextBox TFecha_Ini;
        private System.Windows.Forms.TextBox TStatus;
        private System.Windows.Forms.Button BReserva;
        private System.Windows.Forms.TextBox TReserva;
        private System.Windows.Forms.TextBox TIng_por;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TSal_por;
        private System.Windows.Forms.Label label5;
    }
}