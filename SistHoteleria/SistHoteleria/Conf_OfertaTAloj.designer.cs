namespace SistHoteleria
{
    partial class Conf_OfertaTAloj
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
            this.dg_Caracteristicas = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TdescOferta = new System.Windows.Forms.TextBox();
            this.TOferta = new System.Windows.Forms.TextBox();
            this.BTHabitacion = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Caracteristicas)).BeginInit();
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
            this.BLimpiar.Location = new System.Drawing.Point(370, 255);
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
            this.BSeguir.Location = new System.Drawing.Point(496, 255);
            this.BSeguir.Name = "BSeguir";
            this.BSeguir.Size = new System.Drawing.Size(120, 38);
            this.BSeguir.TabIndex = 12;
            this.BSeguir.Text = "&Guardar";
            this.BSeguir.UseVisualStyleBackColor = false;
            this.BSeguir.Click += new System.EventHandler(this.BSeguir_Click);
            // 
            // dg_Caracteristicas
            // 
            this.dg_Caracteristicas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_Caracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Caracteristicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Descr,
            this.Des});
            this.dg_Caracteristicas.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dg_Caracteristicas.Location = new System.Drawing.Point(18, 0);
            this.dg_Caracteristicas.Name = "dg_Caracteristicas";
            this.dg_Caracteristicas.Size = new System.Drawing.Size(601, 166);
            this.dg_Caracteristicas.TabIndex = 9;
            this.dg_Caracteristicas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dg_Caracteristicas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Caracteristicas_CellEndEdit);
            this.dg_Caracteristicas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.dg_Caracteristicas);
            this.groupBox3.Location = new System.Drawing.Point(-6, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(622, 208);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(25, 172);
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
            this.button6.Location = new System.Drawing.Point(158, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 28);
            this.button6.TabIndex = 11;
            this.button6.Text = "&Borrar Fila";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TdescOferta
            // 
            this.TdescOferta.BackColor = System.Drawing.SystemColors.Info;
            this.TdescOferta.Location = new System.Drawing.Point(190, 12);
            this.TdescOferta.Name = "TdescOferta";
            this.TdescOferta.ReadOnly = true;
            this.TdescOferta.Size = new System.Drawing.Size(417, 20);
            this.TdescOferta.TabIndex = 49;
            // 
            // TOferta
            // 
            this.TOferta.Location = new System.Drawing.Point(122, 12);
            this.TOferta.Name = "TOferta";
            this.TOferta.Size = new System.Drawing.Size(62, 20);
            this.TOferta.TabIndex = 48;
            this.TOferta.Leave += new System.EventHandler(this.TTHabitacion_Leave);
            // 
            // BTHabitacion
            // 
            this.BTHabitacion.Location = new System.Drawing.Point(12, 10);
            this.BTHabitacion.Name = "BTHabitacion";
            this.BTHabitacion.Size = new System.Drawing.Size(107, 23);
            this.BTHabitacion.TabIndex = 47;
            this.BTHabitacion.Text = "Oferta";
            this.BTHabitacion.UseVisualStyleBackColor = true;
            this.BTHabitacion.Click += new System.EventHandler(this.BTHabitacion_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // Descr
            // 
            this.Descr.HeaderText = "Tipo Alojamiento";
            this.Descr.Name = "Descr";
            this.Descr.Width = 400;
            // 
            // Des
            // 
            this.Des.HeaderText = "Descuento";
            this.Des.Name = "Des";
            this.Des.Width = 70;
            // 
            // Conf_OfertaTAloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 314);
            this.Controls.Add(this.TdescOferta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TOferta);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BTHabitacion);
            this.Controls.Add(this.BSeguir);
            this.Name = "Conf_OfertaTAloj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conf_OfertaTAloj";
            this.Load += new System.EventHandler(this.Conf_OfertaTAloj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Caracteristicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BSeguir;
        private System.Windows.Forms.DataGridView dg_Caracteristicas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox TdescOferta;
        private System.Windows.Forms.TextBox TOferta;
        private System.Windows.Forms.Button BTHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des;
    }
}