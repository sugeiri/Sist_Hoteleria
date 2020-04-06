namespace SistHoteleria
{
    partial class Mant_Habitacion
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
            this.LTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTHabitacion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TPiso = new System.Windows.Forms.TextBox();
            this.TEdificio = new System.Windows.Forms.TextBox();
            this.TDescr_THabitacion = new System.Windows.Forms.TextBox();
            this.TTHabitacion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.CB_ESTADO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tDESCR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.TextBox();
            this.LCodigo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TDescr_Edificio = new System.Windows.Forms.TextBox();
            this.BEdificio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(161, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(82, 16);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Habitacion";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BEdificio);
            this.panel1.Controls.Add(this.TDescr_Edificio);
            this.panel1.Controls.Add(this.BTHabitacion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TPiso);
            this.panel1.Controls.Add(this.TEdificio);
            this.panel1.Controls.Add(this.TDescr_THabitacion);
            this.panel1.Controls.Add(this.TTHabitacion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CB_ESTADO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tDESCR);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tid);
            this.panel1.Controls.Add(this.LCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 236);
            this.panel1.TabIndex = 1;
            // 
            // BTHabitacion
            // 
            this.BTHabitacion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BTHabitacion.Location = new System.Drawing.Point(8, 95);
            this.BTHabitacion.Name = "BTHabitacion";
            this.BTHabitacion.Size = new System.Drawing.Size(107, 23);
            this.BTHabitacion.TabIndex = 50;
            this.BTHabitacion.Text = "T Habitacion";
            this.BTHabitacion.UseVisualStyleBackColor = true;
            this.BTHabitacion.Click += new System.EventHandler(this.BTHabitacion_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Piso:";
            // 
            // TPiso
            // 
            this.TPiso.Location = new System.Drawing.Point(121, 147);
            this.TPiso.Name = "TPiso";
            this.TPiso.Size = new System.Drawing.Size(58, 20);
            this.TPiso.TabIndex = 48;
            // 
            // TEdificio
            // 
            this.TEdificio.Location = new System.Drawing.Point(121, 123);
            this.TEdificio.Name = "TEdificio";
            this.TEdificio.Size = new System.Drawing.Size(58, 20);
            this.TEdificio.TabIndex = 46;
            // 
            // TDescr_THabitacion
            // 
            this.TDescr_THabitacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TDescr_THabitacion.Location = new System.Drawing.Point(185, 97);
            this.TDescr_THabitacion.Name = "TDescr_THabitacion";
            this.TDescr_THabitacion.ReadOnly = true;
            this.TDescr_THabitacion.Size = new System.Drawing.Size(211, 20);
            this.TDescr_THabitacion.TabIndex = 45;
            // 
            // TTHabitacion
            // 
            this.TTHabitacion.Location = new System.Drawing.Point(121, 97);
            this.TTHabitacion.Name = "TTHabitacion";
            this.TTHabitacion.Size = new System.Drawing.Size(58, 20);
            this.TTHabitacion.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BLimpiar);
            this.panel2.Controls.Add(this.BCancelar);
            this.panel2.Controls.Add(this.BGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 63);
            this.panel2.TabIndex = 9;
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BLimpiar.FlatAppearance.BorderSize = 2;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BLimpiar.Location = new System.Drawing.Point(15, 5);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(143, 48);
            this.BLimpiar.TabIndex = 54;
            this.BLimpiar.Text = "&LIMPIAR TODO";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BCancelar.FlatAppearance.BorderSize = 2;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BCancelar.Location = new System.Drawing.Point(164, 5);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(120, 48);
            this.BCancelar.TabIndex = 53;
            this.BCancelar.Text = "&CANCELAR";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BGuardar.FlatAppearance.BorderSize = 2;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BGuardar.Location = new System.Drawing.Point(290, 5);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(120, 48);
            this.BGuardar.TabIndex = 52;
            this.BGuardar.Text = "&GUARDAR";
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // CB_ESTADO
            // 
            this.CB_ESTADO.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB_ESTADO.FormattingEnabled = true;
            this.CB_ESTADO.Location = new System.Drawing.Point(310, 37);
            this.CB_ESTADO.Name = "CB_ESTADO";
            this.CB_ESTADO.Size = new System.Drawing.Size(86, 21);
            this.CB_ESTADO.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ESTADO:";
            // 
            // tDESCR
            // 
            this.tDESCR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tDESCR.Location = new System.Drawing.Point(121, 71);
            this.tDESCR.Name = "tDESCR";
            this.tDESCR.Size = new System.Drawing.Size(275, 20);
            this.tDESCR.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "DESCRIPCION:";
            // 
            // tid
            // 
            this.tid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tid.Location = new System.Drawing.Point(121, 37);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(119, 20);
            this.tid.TabIndex = 1;
            this.tid.TextChanged += new System.EventHandler(this.tid_TextChanged);
            this.tid.Leave += new System.EventHandler(this.tid_Leave);
            // 
            // LCodigo
            // 
            this.LCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LCodigo.AutoSize = true;
            this.LCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigo.Location = new System.Drawing.Point(46, 37);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(69, 16);
            this.LCodigo.TabIndex = 0;
            this.LCodigo.Text = "CODIGO:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LTitulo);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 34);
            this.panel3.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TDescr_Edificio
            // 
            this.TDescr_Edificio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TDescr_Edificio.Location = new System.Drawing.Point(185, 126);
            this.TDescr_Edificio.Name = "TDescr_Edificio";
            this.TDescr_Edificio.ReadOnly = true;
            this.TDescr_Edificio.Size = new System.Drawing.Size(211, 20);
            this.TDescr_Edificio.TabIndex = 51;
            // 
            // BEdificio
            // 
            this.BEdificio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BEdificio.Location = new System.Drawing.Point(8, 123);
            this.BEdificio.Name = "BEdificio";
            this.BEdificio.Size = new System.Drawing.Size(107, 23);
            this.BEdificio.TabIndex = 52;
            this.BEdificio.Text = "Edificio";
            this.BEdificio.UseVisualStyleBackColor = true;
            this.BEdificio.Click += new System.EventHandler(this.BEdificio_Click);
            // 
            // Mant_Habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 276);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Mant_Habitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREAR/MODIFICAR";
            this.Load += new System.EventHandler(this.Mant_Habitacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tDESCR;
        private System.Windows.Forms.ComboBox CB_ESTADO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TTHabitacion;
        private System.Windows.Forms.TextBox TEdificio;
        private System.Windows.Forms.TextBox TDescr_THabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TPiso;
        private System.Windows.Forms.Button BTHabitacion;
        private System.Windows.Forms.Button BEdificio;
        private System.Windows.Forms.TextBox TDescr_Edificio;
    }
}