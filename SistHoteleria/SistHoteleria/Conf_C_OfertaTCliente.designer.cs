﻿namespace SistHoteleria
{
    partial class Conf_C_OfertaTCliente
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
            this.DG_Datos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIdentif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDescr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BCrear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TDescOfert = new System.Windows.Forms.TextBox();
            this.TOferta = new System.Windows.Forms.TextBox();
            this.BConsultorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Datos
            // 
            this.DG_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.TIdentif,
            this.Identificacion,
            this.Descuento});
            this.DG_Datos.Location = new System.Drawing.Point(15, 101);
            this.DG_Datos.Name = "DG_Datos";
            this.DG_Datos.Size = new System.Drawing.Size(565, 334);
            this.DG_Datos.TabIndex = 30;
            this.DG_Datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Datos_CellDoubleClick);
            this.DG_Datos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Datos_CellMouseDoubleClick);
            this.DG_Datos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.DG_Datos_PreviewKeyDown);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Descripcion";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // TIdentif
            // 
            this.TIdentif.HeaderText = "id_hab";
            this.TIdentif.Name = "TIdentif";
            this.TIdentif.ReadOnly = true;
            this.TIdentif.Visible = false;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Oferta";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            this.Identificacion.Width = 70;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 70;
            // 
            // TDescr
            // 
            this.TDescr.Location = new System.Drawing.Point(163, 49);
            this.TDescr.Name = "TDescr";
            this.TDescr.Size = new System.Drawing.Size(417, 20);
            this.TDescr.TabIndex = 36;
            this.TDescr.TextChanged += new System.EventHandler(this.TNombreTercero_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "DESCRIPCION:";
            // 
            // TCodigo
            // 
            this.TCodigo.Location = new System.Drawing.Point(163, 19);
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.Size = new System.Drawing.Size(196, 20);
            this.TCodigo.TabIndex = 44;
            this.TCodigo.TextChanged += new System.EventHandler(this.TCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID T CLIENTE :";
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BLimpiar.FlatAppearance.BorderSize = 2;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BLimpiar.Location = new System.Drawing.Point(607, 7);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(172, 36);
            this.BLimpiar.TabIndex = 51;
            this.BLimpiar.Text = "&Limpiar Filtro";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BCrear
            // 
            this.BCrear.BackColor = System.Drawing.Color.Transparent;
            this.BCrear.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BCrear.FlatAppearance.BorderSize = 2;
            this.BCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCrear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BCrear.Location = new System.Drawing.Point(607, 46);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(172, 36);
            this.BCrear.TabIndex = 61;
            this.BCrear.Text = "&CREAR";
            this.BCrear.UseVisualStyleBackColor = false;
            this.BCrear.Click += new System.EventHandler(this.BCrear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(607, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 36);
            this.button1.TabIndex = 60;
            this.button1.Text = "&CONSULTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TDescOfert
            // 
            this.TDescOfert.BackColor = System.Drawing.SystemColors.Window;
            this.TDescOfert.Location = new System.Drawing.Point(231, 75);
            this.TDescOfert.Name = "TDescOfert";
            this.TDescOfert.Size = new System.Drawing.Size(349, 20);
            this.TDescOfert.TabIndex = 79;
            this.TDescOfert.TextChanged += new System.EventHandler(this.TDescConsultorio_TextChanged);
            // 
            // TOferta
            // 
            this.TOferta.Location = new System.Drawing.Point(163, 75);
            this.TOferta.Name = "TOferta";
            this.TOferta.Size = new System.Drawing.Size(62, 20);
            this.TOferta.TabIndex = 78;
            this.TOferta.TextChanged += new System.EventHandler(this.TConsultorio_TextChanged);
            // 
            // BConsultorio
            // 
            this.BConsultorio.Location = new System.Drawing.Point(59, 73);
            this.BConsultorio.Name = "BConsultorio";
            this.BConsultorio.Size = new System.Drawing.Size(98, 23);
            this.BConsultorio.TabIndex = 77;
            this.BConsultorio.Text = "&OFERTA";
            this.BConsultorio.UseVisualStyleBackColor = true;
            this.BConsultorio.Click += new System.EventHandler(this.BConsultorio_Click);
            // 
            // Conf_C_OfertaTCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 447);
            this.Controls.Add(this.TDescOfert);
            this.Controls.Add(this.TOferta);
            this.Controls.Add(this.BConsultorio);
            this.Controls.Add(this.BCrear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TCodigo);
            this.Controls.Add(this.TDescr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DG_Datos);
            this.Name = "Conf_C_OfertaTCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conf_C_OfertaTCliente";
            this.Load += new System.EventHandler(this.Conf_C_OfertaTCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Datos;
        private System.Windows.Forms.TextBox TDescr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BCrear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TDescOfert;
        private System.Windows.Forms.TextBox TOferta;
        private System.Windows.Forms.Button BConsultorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIdentif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
    }
}