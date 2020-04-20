using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistHoteleria
{
    public partial class Trans_Cancelacion : Form
    {
        public Trans_Cancelacion()
        {
            InitializeComponent();
        }

        private void BTCliente_Click(object sender, EventArgs e)
        {
            tipodecancelar form = new tipodecancelar("e", "reservacion", "Reservacion");
            form.ShowDialog();
            if (form.Id.ToString().Trim() != "")
            {
                Codreservacion.Text = form.Id.ToString().Trim();
            }
        }

        private void Trans_Cancelacion_Load(object sender, EventArgs e)
        {
            CB_Estado.Items.Add("A");
            CB_Estado.Items.Add("I");
            CB_Estado.SelectedIndex = 0;
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Error = "";
            string sql = "";
            errorProvider1.Clear();
            string mensaje = "ESTE CAMPO NO PUEDE ESTAR EN BLANCO";
            if (string.IsNullOrWhiteSpace(textBox3.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(textBox3, mensaje);
                textBox3.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(textBox2, mensaje);
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(Codreservacion.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(Codreservacion, mensaje);
                Codreservacion.Focus();
                return;
            }
           
            if (string.IsNullOrWhiteSpace(textBox1.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(textBox1, mensaje);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(motivo.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(motivo, mensaje);
                motivo.Focus();
                return;
            }
            sql = "EXEC ACTCANCELACION '" +
                            textBox1.Text.ToString() + "','" +
                            Codreservacion.Text.ToString().Trim() + "','" +
                            "" + "','" + motivo.Text.ToString().Trim() + "','" +
                            textBox3.Text.ToString().Trim() + "','" +
                            CB_Estado.SelectedItem.ToString().Trim() + "','" +
                            textBox3.Text.ToString().Trim() + "','" +
                            "" + "','" +
                            "A" + "'";

            if (!Conexion.Inserta_Datos(sql, ref Error))
            {
                MessageBox.Show(Error);
                return;
            }
            if (radioButton1.Checked == true)
            {
                if (string.IsNullOrWhiteSpace(textBox4.Text.ToString().Trim()))
                {
                    MessageBox.Show(mensaje);
                    errorProvider1.SetError(textBox4, mensaje);
                    motivo.Focus();
                    return;
                }
                string coment1 = "";
                string coment2 = "";
                
                
                if (richTextBox1.Text.ToString().Trim().Length > 1999)
                {
                    coment1 = richTextBox1.Text.ToString().Trim().Substring(0, 1999);
                    coment2 = richTextBox1.Text.ToString().Trim().Substring(1999, (richTextBox1.Text.ToString().Trim().Length - coment1.Length));
                }
                else
                {
                    coment1 = richTextBox1.Text.ToString().Trim();
                }
                
                sql = "EXEC ACTARCHIVO '" +
                        textBox1.Text.ToString() + "','" +
                        "1" + "','" + textBox4.Text.ToString().Trim() + "','" +
                        coment1 + "','" +
                        coment2 + "','" +
                        CB_Estado.SelectedItem.ToString().Trim() + "','" +
                        textBox3.Text.ToString().Trim() + "','" + "" + "','" +
                        textBox3.Text.ToString().Trim() + "','" + "" + "','" +
                        "A" + "'";
                if (!Conexion.Inserta_Datos(sql, ref Error))
                {
                    MessageBox.Show(Error);
                    return;
                }
            }
            

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox4.Enabled = true;
                button2.Enabled = true;
                richTextBox1.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox4.Enabled = false;
                button2.Enabled = false;
                richTextBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;
            }
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            Codreservacion.Text = "";
            motivo.Text = "";
            richTextBox1.Text = "";
            radioButton1.Checked = true;
        }
    }
}
