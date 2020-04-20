namespace SistHoteleria
{
    partial class Mant_Mantenimiento
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TdescHabitacion = new System.Windows.Forms.TextBox();
            this.THabitacion = new System.Windows.Forms.TextBox();
            this.BHabitacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Estado = new System.Windows.Forms.ComboBox();
            this.TEmpleado = new System.Windows.Forms.TextBox();
            this.BEmpleado = new System.Windows.Forms.Button();
            this.Tnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TFechaC = new System.Windows.Forms.TextBox();
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
            this.BLimpiar.Location = new System.Drawing.Point(421, 288);
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
            this.BSeguir.Location = new System.Drawing.Point(547, 288);
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
            this.CodEmp,
            this.Nombre,
            this.Finalizado});
            this.dg_Caracteristicas.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dg_Caracteristicas.Location = new System.Drawing.Point(18, 0);
            this.dg_Caracteristicas.Name = "dg_Caracteristicas";
            this.dg_Caracteristicas.Size = new System.Drawing.Size(645, 166);
            this.dg_Caracteristicas.TabIndex = 9;
            this.dg_Caracteristicas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dg_Caracteristicas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Caracteristicas_CellEndEdit);
            this.dg_Caracteristicas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TMant";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // Descr
            // 
            this.Descr.HeaderText = "Descripcion";
            this.Descr.Name = "Descr";
            this.Descr.Width = 200;
            // 
            // CodEmp
            // 
            this.CodEmp.HeaderText = "Empleado";
            this.CodEmp.Name = "CodEmp";
            this.CodEmp.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Finalizado
            // 
            this.Finalizado.HeaderText = "Finalizado";
            this.Finalizado.Name = "Finalizado";
            this.Finalizado.Width = 70;
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
            this.groupBox3.Location = new System.Drawing.Point(-6, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 208);
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
            // TdescHabitacion
            // 
            this.TdescHabitacion.BackColor = System.Drawing.SystemColors.Info;
            this.TdescHabitacion.Location = new System.Drawing.Point(190, 11);
            this.TdescHabitacion.Name = "TdescHabitacion";
            this.TdescHabitacion.ReadOnly = true;
            this.TdescHabitacion.Size = new System.Drawing.Size(315, 20);
            this.TdescHabitacion.TabIndex = 49;
            // 
            // THabitacion
            // 
            this.THabitacion.Location = new System.Drawing.Point(122, 11);
            this.THabitacion.Name = "THabitacion";
            this.THabitacion.Size = new System.Drawing.Size(62, 20);
            this.THabitacion.TabIndex = 48;
            this.THabitacion.Leave += new System.EventHandler(this.THabitacion_Leave);
            // 
            // BHabitacion
            // 
            this.BHabitacion.Location = new System.Drawing.Point(12, 9);
            this.BHabitacion.Name = "BHabitacion";
            this.BHabitacion.Size = new System.Drawing.Size(107, 23);
            this.BHabitacion.TabIndex = 47;
            this.BHabitacion.Text = "Habitacion";
            this.BHabitacion.UseVisualStyleBackColor = true;
            this.BHabitacion.Click += new System.EventHandler(this.BHabitacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 80;
            this.label1.Text = "Estado:";
            // 
            // CB_Estado
            // 
            this.CB_Estado.FormattingEnabled = true;
            this.CB_Estado.Location = new System.Drawing.Point(563, 12);
            this.CB_Estado.Name = "CB_Estado";
            this.CB_Estado.Size = new System.Drawing.Size(94, 21);
            this.CB_Estado.TabIndex = 81;
            // 
            // TEmpleado
            // 
            this.TEmpleado.Location = new System.Drawing.Point(122, 40);
            this.TEmpleado.Name = "TEmpleado";
            this.TEmpleado.Size = new System.Drawing.Size(62, 20);
            this.TEmpleado.TabIndex = 83;
            this.TEmpleado.Leave += new System.EventHandler(this.TEmpleado_Leave);
            // 
            // BEmpleado
            // 
            this.BEmpleado.Location = new System.Drawing.Point(12, 38);
            this.BEmpleado.Name = "BEmpleado";
            this.BEmpleado.Size = new System.Drawing.Size(107, 23);
            this.BEmpleado.TabIndex = 82;
            this.BEmpleado.Text = "Empleado";
            this.BEmpleado.UseVisualStyleBackColor = true;
            this.BEmpleado.Click += new System.EventHandler(this.BEmpleado_Click);
            // 
            // Tnombre
            // 
            this.Tnombre.BackColor = System.Drawing.SystemColors.Info;
            this.Tnombre.Location = new System.Drawing.Point(190, 41);
            this.Tnombre.Name = "Tnombre";
            this.Tnombre.ReadOnly = true;
            this.Tnombre.Size = new System.Drawing.Size(315, 20);
            this.Tnombre.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Creado:";
            // 
            // TFechaC
            // 
            this.TFechaC.Location = new System.Drawing.Point(563, 42);
            this.TFechaC.Name = "TFechaC";
            this.TFechaC.Size = new System.Drawing.Size(94, 20);
            this.TFechaC.TabIndex = 86;
            // 
            // Mant_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 356);
            this.Controls.Add(this.TFechaC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tnombre);
            this.Controls.Add(this.TEmpleado);
            this.Controls.Add(this.BEmpleado);
            this.Controls.Add(this.CB_Estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TdescHabitacion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.THabitacion);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.BHabitacion);
            this.Controls.Add(this.BSeguir);
            this.Name = "Mant_Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mant_Mantenimiento";
            this.Load += new System.EventHandler(this.Mant_Mantenimiento_Load);
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
        private System.Windows.Forms.TextBox TdescHabitacion;
        private System.Windows.Forms.TextBox THabitacion;
        private System.Windows.Forms.Button BHabitacion;
        private System.Windows.Forms.ComboBox CB_Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tnombre;
        private System.Windows.Forms.TextBox TEmpleado;
        private System.Windows.Forms.Button BEmpleado;
        private System.Windows.Forms.TextBox TFechaC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finalizado;
    }
}