namespace SistHoteleria
{
    partial class Mant_TipoHabitacion
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
            this.label3 = new System.Windows.Forms.Label();
            this.TCapacidad = new System.Windows.Forms.TextBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.TCosto = new System.Windows.Forms.TextBox();
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
            this.LTitulo.Size = new System.Drawing.Size(116, 16);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Tipo Habitacion";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TCosto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TCapacidad);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CB_ESTADO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tDESCR);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tid);
            this.panel1.Controls.Add(this.LCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 227);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "CAPACIDAD:";
            // 
            // TCapacidad
            // 
            this.TCapacidad.Location = new System.Drawing.Point(121, 107);
            this.TCapacidad.Name = "TCapacidad";
            this.TCapacidad.Size = new System.Drawing.Size(66, 20);
            this.TCapacidad.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BLimpiar);
            this.panel2.Controls.Add(this.BCancelar);
            this.panel2.Controls.Add(this.BGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 164);
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
            this.CB_ESTADO.Location = new System.Drawing.Point(310, 23);
            this.CB_ESTADO.Name = "CB_ESTADO";
            this.CB_ESTADO.Size = new System.Drawing.Size(86, 21);
            this.CB_ESTADO.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ESTADO:";
            // 
            // tDESCR
            // 
            this.tDESCR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tDESCR.Location = new System.Drawing.Point(121, 64);
            this.tDESCR.Name = "tDESCR";
            this.tDESCR.Size = new System.Drawing.Size(275, 20);
            this.tDESCR.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "DESCRIPCION:";
            // 
            // tid
            // 
            this.tid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tid.Location = new System.Drawing.Point(121, 22);
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
            this.LCodigo.Location = new System.Drawing.Point(46, 22);
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "COSTO:";
            // 
            // TCosto
            // 
            this.TCosto.Location = new System.Drawing.Point(290, 106);
            this.TCosto.Name = "TCosto";
            this.TCosto.Size = new System.Drawing.Size(75, 20);
            this.TCosto.TabIndex = 45;
            // 
            // Mant_TipoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 280);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Mant_TipoHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREAR/MODIFICAR";
            this.Load += new System.EventHandler(this.Mant_TipoHabitacion_Load);
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
        private System.Windows.Forms.TextBox TCapacidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TCosto;
    }
}