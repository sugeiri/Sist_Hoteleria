namespace SistHoteleria
{
    partial class Trans_Cancelacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.Codreservacion = new System.Windows.Forms.TextBox();
            this.BTCliente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Estado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.motivo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(498, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.BLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BLimpiar.FlatAppearance.BorderSize = 2;
            this.BLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiar.Location = new System.Drawing.Point(498, 8);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(120, 36);
            this.BLimpiar.TabIndex = 13;
            this.BLimpiar.Text = "&Limpiar Todo";
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // Codreservacion
            // 
            this.Codreservacion.Location = new System.Drawing.Point(138, 38);
            this.Codreservacion.Name = "Codreservacion";
            this.Codreservacion.Size = new System.Drawing.Size(83, 20);
            this.Codreservacion.TabIndex = 45;
            // 
            // BTCliente
            // 
            this.BTCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BTCliente.Location = new System.Drawing.Point(25, 38);
            this.BTCliente.Name = "BTCliente";
            this.BTCliente.Size = new System.Drawing.Size(97, 23);
            this.BTCliente.TabIndex = 54;
            this.BTCliente.Text = "C.Reservacion";
            this.BTCliente.UseVisualStyleBackColor = true;
            this.BTCliente.Click += new System.EventHandler(this.BTCliente_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(138, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID Cancelación\r\n";
            // 
            // CB_Estado
            // 
            this.CB_Estado.Enabled = false;
            this.CB_Estado.FormattingEnabled = true;
            this.CB_Estado.Location = new System.Drawing.Point(313, 11);
            this.CB_Estado.Name = "CB_Estado";
            this.CB_Estado.Size = new System.Drawing.Size(86, 21);
            this.CB_Estado.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(247, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "Estado:";
            // 
            // motivo
            // 
            this.motivo.Location = new System.Drawing.Point(138, 64);
            this.motivo.Name = "motivo";
            this.motivo.Size = new System.Drawing.Size(343, 48);
            this.motivo.TabIndex = 89;
            this.motivo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 90;
            this.label2.Text = "Motivo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(463, 20);
            this.textBox4.TabIndex = 95;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(498, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 48);
            this.button2.TabIndex = 98;
            this.button2.Text = "&Adjuntar Documento";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 99;
            this.label5.Text = "Comentario:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(99, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(375, 76);
            this.richTextBox1.TabIndex = 100;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 199);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DOCUMENTO";
            this.groupBox2.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button3.Location = new System.Drawing.Point(13, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 102;
            this.button3.Text = "TArchivo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 101;
            // 
            // Trans_Cancelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 336);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.motivo);
            this.Controls.Add(this.CB_Estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTCliente);
            this.Controls.Add(this.Codreservacion);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.button1);
            this.Name = "Trans_Cancelacion";
            this.Text = "Trans_Cancelacion";
            this.Load += new System.EventHandler(this.Trans_Cancelacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.TextBox Codreservacion;
        private System.Windows.Forms.Button BTCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox motivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
    }
}