﻿namespace SistHoteleria
{
    partial class Mant_Oferta
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
            this.Tdescr_Temporada = new System.Windows.Forms.TextBox();
            this.TTemporada = new System.Windows.Forms.TextBox();
            this.BProvincia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.CB_ESTADO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tDESCR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.TextBox();
            this.LCodigo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.LTitulo.Size = new System.Drawing.Size(52, 16);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Oferta";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tdescr_Temporada);
            this.panel1.Controls.Add(this.TTemporada);
            this.panel1.Controls.Add(this.BProvincia);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CB_ESTADO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tDESCR);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tid);
            this.panel1.Controls.Add(this.LCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 177);
            this.panel1.TabIndex = 1;
            // 
            // Tdescr_Temporada
            // 
            this.Tdescr_Temporada.BackColor = System.Drawing.SystemColors.Info;
            this.Tdescr_Temporada.Location = new System.Drawing.Point(175, 70);
            this.Tdescr_Temporada.Name = "Tdescr_Temporada";
            this.Tdescr_Temporada.ReadOnly = true;
            this.Tdescr_Temporada.Size = new System.Drawing.Size(219, 20);
            this.Tdescr_Temporada.TabIndex = 44;
            // 
            // TTemporada
            // 
            this.TTemporada.Location = new System.Drawing.Point(120, 70);
            this.TTemporada.Name = "TTemporada";
            this.TTemporada.Size = new System.Drawing.Size(49, 20);
            this.TTemporada.TabIndex = 43;
            // 
            // BProvincia
            // 
            this.BProvincia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BProvincia.Location = new System.Drawing.Point(10, 70);
            this.BProvincia.Name = "BProvincia";
            this.BProvincia.Size = new System.Drawing.Size(107, 23);
            this.BProvincia.TabIndex = 42;
            this.BProvincia.Text = "Temporada";
            this.BProvincia.UseVisualStyleBackColor = true;
            this.BProvincia.Click += new System.EventHandler(this.BProvincia_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.BLimpiar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 63);
            this.panel2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(15, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 48);
            this.button2.TabIndex = 54;
            this.button2.Text = "&LIMPIAR TODO";
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
            this.button1.Location = new System.Drawing.Point(164, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 53;
            this.button1.Text = "&CANCELAR";
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
            this.BLimpiar.Location = new System.Drawing.Point(290, 5);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(120, 48);
            this.BLimpiar.TabIndex = 52;
            this.BLimpiar.Text = "&GUARDAR";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // CB_ESTADO
            // 
            this.CB_ESTADO.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB_ESTADO.FormattingEnabled = true;
            this.CB_ESTADO.Location = new System.Drawing.Point(310, 7);
            this.CB_ESTADO.Name = "CB_ESTADO";
            this.CB_ESTADO.Size = new System.Drawing.Size(86, 21);
            this.CB_ESTADO.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ESTADO:";
            // 
            // tDESCR
            // 
            this.tDESCR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tDESCR.Location = new System.Drawing.Point(121, 41);
            this.tDESCR.Name = "tDESCR";
            this.tDESCR.Size = new System.Drawing.Size(275, 20);
            this.tDESCR.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "DESCRIPCION:";
            // 
            // tid
            // 
            this.tid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tid.Location = new System.Drawing.Point(121, 7);
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
            this.LCodigo.Location = new System.Drawing.Point(46, 7);
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
            // Mant_Oferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 212);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Mant_Oferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREAR/MODIFICAR";
            this.Load += new System.EventHandler(this.Mant_Oferta_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox Tdescr_Temporada;
        private System.Windows.Forms.TextBox TTemporada;
        private System.Windows.Forms.Button BProvincia;
    }
}