namespace SistHoteleria
{
    partial class tipob
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BCrear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_ESTADO = new System.Windows.Forms.ComboBox();
            this.DG_DATOS = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tDESCR = new System.Windows.Forms.TextBox();
            this.tid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LCodigo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_DATOS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BCrear);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.BLimpiar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 44);
            this.panel2.TabIndex = 9;
            // 
            // BCrear
            // 
            this.BCrear.BackColor = System.Drawing.Color.Transparent;
            this.BCrear.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BCrear.FlatAppearance.BorderSize = 2;
            this.BCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCrear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BCrear.Location = new System.Drawing.Point(143, 3);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(80, 36);
            this.BCrear.TabIndex = 55;
            this.BCrear.Text = "&CREAR";
            this.BCrear.UseVisualStyleBackColor = false;
            this.BCrear.Click += new System.EventHandler(this.BCrear_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(6, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 36);
            this.button2.TabIndex = 54;
            this.button2.Text = "&LIMPIAR FILTRO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(227, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 53;
            this.button1.Text = "&CONSULTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BLimpiar.FlatAppearance.BorderSize = 2;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BLimpiar.Location = new System.Drawing.Point(338, 3);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(97, 36);
            this.BLimpiar.TabIndex = 52;
            this.BLimpiar.Text = "&CANCELAR";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LTitulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 34);
            this.panel3.TabIndex = 6;
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(3, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(47, 16);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Titulo";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CB_ESTADO);
            this.panel1.Controls.Add(this.DG_DATOS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tDESCR);
            this.panel1.Controls.Add(this.tid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 375);
            this.panel1.TabIndex = 5;
            // 
            // CB_ESTADO
            // 
            this.CB_ESTADO.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB_ESTADO.FormattingEnabled = true;
            this.CB_ESTADO.Location = new System.Drawing.Point(347, 29);
            this.CB_ESTADO.Name = "CB_ESTADO";
            this.CB_ESTADO.Size = new System.Drawing.Size(86, 21);
            this.CB_ESTADO.TabIndex = 22;
            this.CB_ESTADO.SelectedIndexChanged += new System.EventHandler(this.CB_ESTADO_SelectedIndexChanged);
            // 
            // DG_DATOS
            // 
            this.DG_DATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_DATOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Descr,
            this.estado});
            this.DG_DATOS.Location = new System.Drawing.Point(6, 97);
            this.DG_DATOS.Name = "DG_DATOS";
            this.DG_DATOS.Size = new System.Drawing.Size(429, 228);
            this.DG_DATOS.TabIndex = 10;
            this.DG_DATOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_DATOS_CellDoubleClick);
            this.DG_DATOS.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_DATOS_CellMouseDoubleClick);
            this.DG_DATOS.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.DG_DATOS_PreviewKeyDown);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // Descr
            // 
            this.Descr.HeaderText = "Descripcion";
            this.Descr.Name = "Descr";
            this.Descr.ReadOnly = true;
            this.Descr.Width = 230;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 70;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "ESTADO:";
            // 
            // tDESCR
            // 
            this.tDESCR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tDESCR.Location = new System.Drawing.Point(113, 63);
            this.tDESCR.Name = "tDESCR";
            this.tDESCR.Size = new System.Drawing.Size(318, 20);
            this.tDESCR.TabIndex = 20;
            this.tDESCR.TextChanged += new System.EventHandler(this.tDESCR_TextChanged);
            // 
            // tid
            // 
            this.tid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tid.Location = new System.Drawing.Point(113, 29);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(164, 20);
            this.tid.TabIndex = 18;
            this.tid.TextChanged += new System.EventHandler(this.tid_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "DESCRIPCION:";
            // 
            // LCodigo
            // 
            this.LCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LCodigo.AutoSize = true;
            this.LCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigo.Location = new System.Drawing.Point(49, 29);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(69, 16);
            this.LCodigo.TabIndex = 17;
            this.LCodigo.Text = "CODIGO:";
            // 
            // tipob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 403);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "tipob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA";
            this.Load += new System.EventHandler(this.tipob_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_DATOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DG_DATOS;
        private System.Windows.Forms.ComboBox CB_ESTADO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tDESCR;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BCrear;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}