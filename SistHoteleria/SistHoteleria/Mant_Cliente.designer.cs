namespace SistHoteleria
{
    partial class Mant_Cliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TEdad = new System.Windows.Forms.TextBox();
            this.BBuscar_P = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_Sexo = new System.Windows.Forms.ComboBox();
            this.DT_Fecha_NAc = new System.Windows.Forms.DateTimePicker();
            this.TIdentificacion = new System.Windows.Forms.TextBox();
            this.CB_TipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.TNombreTercero = new System.Windows.Forms.TextBox();
            this.BSeguir = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TLimite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TDescr_TipoCliente = new System.Windows.Forms.TextBox();
            this.TTipoCliente = new System.Windows.Forms.TextBox();
            this.BTCliente = new System.Windows.Forms.Button();
            this.CB_Estado = new System.Windows.Forms.ComboBox();
            this.TCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BPais = new System.Windows.Forms.Button();
            this.BProvincia = new System.Windows.Forms.Button();
            this.BMunicipio = new System.Windows.Forms.Button();
            this.Tpais = new System.Windows.Forms.TextBox();
            this.Tprovincia = new System.Windows.Forms.TextBox();
            this.Tmunicipio = new System.Windows.Forms.TextBox();
            this.TDireccion = new System.Windows.Forms.RichTextBox();
            this.Tdescr_pais = new System.Windows.Forms.TextBox();
            this.Tdescr_provincia = new System.Windows.Forms.TextBox();
            this.Tdescr_municipio = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.DG_Telefono = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.DG_Email = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Telefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Email)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Identificacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha Nac:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sexo:";
            // 
            // TEdad
            // 
            this.TEdad.Enabled = false;
            this.TEdad.Location = new System.Drawing.Point(369, 99);
            this.TEdad.Name = "TEdad";
            this.TEdad.ReadOnly = true;
            this.TEdad.Size = new System.Drawing.Size(104, 20);
            this.TEdad.TabIndex = 23;
            this.TEdad.TextChanged += new System.EventHandler(this.TEdad_TextChanged);
            // 
            // BBuscar_P
            // 
            this.BBuscar_P.BackColor = System.Drawing.Color.Transparent;
            this.BBuscar_P.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BBuscar_P.FlatAppearance.BorderSize = 2;
            this.BBuscar_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar_P.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar_P.Location = new System.Drawing.Point(489, 12);
            this.BBuscar_P.Name = "BBuscar_P";
            this.BBuscar_P.Size = new System.Drawing.Size(120, 60);
            this.BBuscar_P.TabIndex = 10;
            this.BBuscar_P.Text = "&Buscar Datos de Persona";
            this.BBuscar_P.UseVisualStyleBackColor = false;
            this.BBuscar_P.Click += new System.EventHandler(this.BBuscar_P_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(319, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Edad:";
            // 
            // CB_Sexo
            // 
            this.CB_Sexo.FormattingEnabled = true;
            this.CB_Sexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.CB_Sexo.Location = new System.Drawing.Point(130, 126);
            this.CB_Sexo.Name = "CB_Sexo";
            this.CB_Sexo.Size = new System.Drawing.Size(121, 21);
            this.CB_Sexo.TabIndex = 8;
            // 
            // DT_Fecha_NAc
            // 
            this.DT_Fecha_NAc.Location = new System.Drawing.Point(130, 99);
            this.DT_Fecha_NAc.Name = "DT_Fecha_NAc";
            this.DT_Fecha_NAc.Size = new System.Drawing.Size(122, 20);
            this.DT_Fecha_NAc.TabIndex = 7;
            this.DT_Fecha_NAc.ValueChanged += new System.EventHandler(this.DT_Fecha_NAc_ValueChanged);
            // 
            // TIdentificacion
            // 
            this.TIdentificacion.Location = new System.Drawing.Point(254, 71);
            this.TIdentificacion.Name = "TIdentificacion";
            this.TIdentificacion.Size = new System.Drawing.Size(219, 20);
            this.TIdentificacion.TabIndex = 6;
            // 
            // CB_TipoIdentificacion
            // 
            this.CB_TipoIdentificacion.FormattingEnabled = true;
            this.CB_TipoIdentificacion.Location = new System.Drawing.Point(130, 71);
            this.CB_TipoIdentificacion.Name = "CB_TipoIdentificacion";
            this.CB_TipoIdentificacion.Size = new System.Drawing.Size(122, 21);
            this.CB_TipoIdentificacion.TabIndex = 5;
            // 
            // TNombreTercero
            // 
            this.TNombreTercero.Location = new System.Drawing.Point(130, 46);
            this.TNombreTercero.Name = "TNombreTercero";
            this.TNombreTercero.Size = new System.Drawing.Size(343, 20);
            this.TNombreTercero.TabIndex = 4;
            // 
            // BSeguir
            // 
            this.BSeguir.BackColor = System.Drawing.Color.Transparent;
            this.BSeguir.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BSeguir.FlatAppearance.BorderSize = 2;
            this.BSeguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSeguir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BSeguir.Location = new System.Drawing.Point(489, 136);
            this.BSeguir.Name = "BSeguir";
            this.BSeguir.Size = new System.Drawing.Size(120, 65);
            this.BSeguir.TabIndex = 11;
            this.BSeguir.Text = "&Guardar";
            this.BSeguir.UseVisualStyleBackColor = false;
            this.BSeguir.Click += new System.EventHandler(this.BSeguir_Click);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BLimpiar.FlatAppearance.BorderSize = 2;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.Location = new System.Drawing.Point(489, 78);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(120, 53);
            this.BLimpiar.TabIndex = 9;
            this.BLimpiar.Text = "&Limpiar Todo";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TLimite
            // 
            this.TLimite.Location = new System.Drawing.Point(130, 185);
            this.TLimite.Name = "TLimite";
            this.TLimite.Size = new System.Drawing.Size(88, 20);
            this.TLimite.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Lim Credito:";
            // 
            // TDescr_TipoCliente
            // 
            this.TDescr_TipoCliente.Enabled = false;
            this.TDescr_TipoCliente.Location = new System.Drawing.Point(254, 153);
            this.TDescr_TipoCliente.Name = "TDescr_TipoCliente";
            this.TDescr_TipoCliente.ReadOnly = true;
            this.TDescr_TipoCliente.Size = new System.Drawing.Size(219, 20);
            this.TDescr_TipoCliente.TabIndex = 52;
            // 
            // TTipoCliente
            // 
            this.TTipoCliente.Location = new System.Drawing.Point(130, 153);
            this.TTipoCliente.Name = "TTipoCliente";
            this.TTipoCliente.Size = new System.Drawing.Size(121, 20);
            this.TTipoCliente.TabIndex = 54;
            // 
            // BTCliente
            // 
            this.BTCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BTCliente.Location = new System.Drawing.Point(27, 153);
            this.BTCliente.Name = "BTCliente";
            this.BTCliente.Size = new System.Drawing.Size(97, 23);
            this.BTCliente.TabIndex = 53;
            this.BTCliente.Text = "T.Cliente";
            this.BTCliente.UseVisualStyleBackColor = true;
            this.BTCliente.Click += new System.EventHandler(this.BTCliente_Click_1);
            // 
            // CB_Estado
            // 
            this.CB_Estado.FormattingEnabled = true;
            this.CB_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CB_Estado.Location = new System.Drawing.Point(387, 21);
            this.CB_Estado.Name = "CB_Estado";
            this.CB_Estado.Size = new System.Drawing.Size(86, 21);
            this.CB_Estado.TabIndex = 51;
            // 
            // TCliente
            // 
            this.TCliente.Location = new System.Drawing.Point(130, 21);
            this.TCliente.Name = "TCliente";
            this.TCliente.Size = new System.Drawing.Size(133, 20);
            this.TCliente.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "Direccion:";
            // 
            // BPais
            // 
            this.BPais.Location = new System.Drawing.Point(20, 211);
            this.BPais.Name = "BPais";
            this.BPais.Size = new System.Drawing.Size(107, 23);
            this.BPais.TabIndex = 81;
            this.BPais.Text = "Pais";
            this.BPais.UseVisualStyleBackColor = true;
            this.BPais.Click += new System.EventHandler(this.BPais_Click);
            // 
            // BProvincia
            // 
            this.BProvincia.Location = new System.Drawing.Point(20, 236);
            this.BProvincia.Name = "BProvincia";
            this.BProvincia.Size = new System.Drawing.Size(107, 23);
            this.BProvincia.TabIndex = 82;
            this.BProvincia.Text = "Provincia";
            this.BProvincia.UseVisualStyleBackColor = true;
            this.BProvincia.Click += new System.EventHandler(this.BProvincia_Click);
            // 
            // BMunicipio
            // 
            this.BMunicipio.Location = new System.Drawing.Point(20, 262);
            this.BMunicipio.Name = "BMunicipio";
            this.BMunicipio.Size = new System.Drawing.Size(107, 23);
            this.BMunicipio.TabIndex = 83;
            this.BMunicipio.Text = "Municipio";
            this.BMunicipio.UseVisualStyleBackColor = true;
            this.BMunicipio.Click += new System.EventHandler(this.BMunicipio_Click);
            // 
            // Tpais
            // 
            this.Tpais.Location = new System.Drawing.Point(130, 212);
            this.Tpais.Name = "Tpais";
            this.Tpais.Size = new System.Drawing.Size(62, 20);
            this.Tpais.TabIndex = 85;
            this.Tpais.Leave += new System.EventHandler(this.Tpais_Leave);
            // 
            // Tprovincia
            // 
            this.Tprovincia.Location = new System.Drawing.Point(130, 237);
            this.Tprovincia.Name = "Tprovincia";
            this.Tprovincia.Size = new System.Drawing.Size(62, 20);
            this.Tprovincia.TabIndex = 86;
            this.Tprovincia.Leave += new System.EventHandler(this.Tprovincia_Leave);
            // 
            // Tmunicipio
            // 
            this.Tmunicipio.Location = new System.Drawing.Point(130, 263);
            this.Tmunicipio.Name = "Tmunicipio";
            this.Tmunicipio.Size = new System.Drawing.Size(62, 20);
            this.Tmunicipio.TabIndex = 87;
            this.Tmunicipio.Leave += new System.EventHandler(this.Tmunicipio_Leave);
            // 
            // TDireccion
            // 
            this.TDireccion.Location = new System.Drawing.Point(130, 289);
            this.TDireccion.Name = "TDireccion";
            this.TDireccion.Size = new System.Drawing.Size(343, 48);
            this.TDireccion.TabIndex = 88;
            this.TDireccion.Text = "";
            // 
            // Tdescr_pais
            // 
            this.Tdescr_pais.BackColor = System.Drawing.SystemColors.Info;
            this.Tdescr_pais.Location = new System.Drawing.Point(198, 212);
            this.Tdescr_pais.Name = "Tdescr_pais";
            this.Tdescr_pais.ReadOnly = true;
            this.Tdescr_pais.Size = new System.Drawing.Size(275, 20);
            this.Tdescr_pais.TabIndex = 89;
            // 
            // Tdescr_provincia
            // 
            this.Tdescr_provincia.BackColor = System.Drawing.SystemColors.Info;
            this.Tdescr_provincia.Location = new System.Drawing.Point(198, 237);
            this.Tdescr_provincia.Name = "Tdescr_provincia";
            this.Tdescr_provincia.ReadOnly = true;
            this.Tdescr_provincia.Size = new System.Drawing.Size(275, 20);
            this.Tdescr_provincia.TabIndex = 90;
            // 
            // Tdescr_municipio
            // 
            this.Tdescr_municipio.BackColor = System.Drawing.SystemColors.Info;
            this.Tdescr_municipio.Location = new System.Drawing.Point(198, 263);
            this.Tdescr_municipio.Name = "Tdescr_municipio";
            this.Tdescr_municipio.ReadOnly = true;
            this.Tdescr_municipio.Size = new System.Drawing.Size(275, 20);
            this.Tdescr_municipio.TabIndex = 91;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(34, 472);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 28);
            this.button5.TabIndex = 4;
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
            this.button6.Location = new System.Drawing.Point(167, 472);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "&Borrar Fila";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // DG_Telefono
            // 
            this.DG_Telefono.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG_Telefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Telefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.TipoTel});
            this.DG_Telefono.GridColor = System.Drawing.Color.DarkSlateGray;
            this.DG_Telefono.Location = new System.Drawing.Point(12, 344);
            this.DG_Telefono.Name = "DG_Telefono";
            this.DG_Telefono.Size = new System.Drawing.Size(294, 122);
            this.DG_Telefono.TabIndex = 3;
            this.DG_Telefono.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Telefono_CellDoubleClick);
            this.DG_Telefono.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Telefono_CellEndEdit);
            this.DG_Telefono.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Telefono_CellMouseDoubleClick);
            this.DG_Telefono.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Telefono_CellValueChanged);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MaxInputLength = 17;
            this.Numero.Name = "Numero";
            this.Numero.Width = 150;
            // 
            // TipoTel
            // 
            this.TipoTel.HeaderText = "Tipo Tel";
            this.TipoTel.Name = "TipoTel";
            this.TipoTel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoTel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(334, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 28);
            this.button3.TabIndex = 94;
            this.button3.Text = "&Limpiar Datos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // DG_Email
            // 
            this.DG_Email.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG_Email.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Email.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.TipoEmail});
            this.DG_Email.GridColor = System.Drawing.Color.DarkSlateGray;
            this.DG_Email.Location = new System.Drawing.Point(311, 343);
            this.DG_Email.Name = "DG_Email";
            this.DG_Email.Size = new System.Drawing.Size(301, 123);
            this.DG_Email.TabIndex = 93;
            this.DG_Email.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Email_CellDoubleClick);
            this.DG_Email.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Email_CellEndEdit);
            this.DG_Email.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Email_CellMouseDoubleClick);
            this.DG_Email.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Email_CellValueChanged);
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // TipoEmail
            // 
            this.TipoEmail.HeaderText = "TipoEmail";
            this.TipoEmail.Name = "TipoEmail";
            this.TipoEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(482, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 28);
            this.button4.TabIndex = 95;
            this.button4.Text = "&Borrar Fila";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Mant_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 529);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DG_Telefono);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.DG_Email);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Tdescr_municipio);
            this.Controls.Add(this.Tdescr_provincia);
            this.Controls.Add(this.Tdescr_pais);
            this.Controls.Add(this.TDireccion);
            this.Controls.Add(this.Tmunicipio);
            this.Controls.Add(this.Tprovincia);
            this.Controls.Add(this.Tpais);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BMunicipio);
            this.Controls.Add(this.BProvincia);
            this.Controls.Add(this.BPais);
            this.Controls.Add(this.BBuscar_P);
            this.Controls.Add(this.TEdad);
            this.Controls.Add(this.TLimite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TDescr_TipoCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TTipoCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTCliente);
            this.Controls.Add(this.CB_Estado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TCliente);
            this.Controls.Add(this.CB_Sexo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_Fecha_NAc);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.TIdentificacion);
            this.Controls.Add(this.BSeguir);
            this.Controls.Add(this.TNombreTercero);
            this.Controls.Add(this.CB_TipoIdentificacion);
            this.Name = "Mant_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mant_Cliente";
            this.Load += new System.EventHandler(this.Mant_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Telefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TIdentificacion;
        private System.Windows.Forms.ComboBox CB_TipoIdentificacion;
        private System.Windows.Forms.TextBox TNombreTercero;
        private System.Windows.Forms.DateTimePicker DT_Fecha_NAc;
        private System.Windows.Forms.ComboBox CB_Sexo;
        private System.Windows.Forms.Button BBuscar_P;
        private System.Windows.Forms.Button BSeguir;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TEdad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TLimite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TDescr_TipoCliente;
        private System.Windows.Forms.TextBox TTipoCliente;
        private System.Windows.Forms.Button BTCliente;
        private System.Windows.Forms.ComboBox CB_Estado;
        private System.Windows.Forms.TextBox TCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView DG_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox Tdescr_municipio;
        private System.Windows.Forms.TextBox Tdescr_provincia;
        private System.Windows.Forms.TextBox Tdescr_pais;
        private System.Windows.Forms.RichTextBox TDireccion;
        private System.Windows.Forms.TextBox Tmunicipio;
        private System.Windows.Forms.TextBox Tprovincia;
        private System.Windows.Forms.TextBox Tpais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BMunicipio;
        private System.Windows.Forms.Button BProvincia;
        private System.Windows.Forms.Button BPais;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DG_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEmail;
        private System.Windows.Forms.Button button4;
    }
}