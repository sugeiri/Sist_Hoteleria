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
        string aa_modo = "a";
        public Trans_Cancelacion(string modo)
        {
            InitializeComponent();
            aa_modo = modo;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Error = "";
            string sql = "";
            errorProvider1.Clear();
            string mensaje = "ESTE CAMPO NO PUEDE ESTAR EN BLANCO";
            if (string.IsNullOrWhiteSpace(Codreservacion.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(Codreservacion, mensaje);
                Codreservacion.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(motivo.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(motivo, mensaje);
                motivo.Focus();
                return;
            }
            if (groupBox2.Visible)
            {
                if (string.IsNullOrWhiteSpace(textBox4.Text.ToString().Trim()))
                {
                    MessageBox.Show(mensaje);
                    errorProvider1.SetError(textBox4, mensaje);
                    textBox4.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(richTextBox1.Text.ToString().Trim()))
                {
                    MessageBox.Show(mensaje);
                    errorProvider1.SetError(richTextBox1, mensaje);
                    richTextBox1.Focus();
                    return;
                }
            }
            int Cod = funciones.Prox_Codigo("cancelacion");
            string ii_arch = "";
            if (groupBox2.Visible)
                ii_arch = funciones.Prox_Codigo("archivo").ToString();
            
            sql = "EXEC ACTCANCELACION " +
                            Cod + "," +
                            Codreservacion.Text.ToString().Trim() + ",'" +
                            motivo.Text.ToString().Trim() + "','" +
                            ii_arch.ToString().Trim() + "','" +
                            Clases.Usuario + "','" +
                            CB_Estado.SelectedItem.ToString().Substring(0,1).Trim() + "','" +
                            Clases.Usuario + "','" +
                            aa_modo + "'";

            if (!Conexion.Inserta_Datos(sql, ref Error))
            {
                MessageBox.Show(Error);
                return;
            }
            if (ii_arch.Trim()!="")
            {
               
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
                
                sql = "EXEC ACTARCHIVO " +
                        ii_arch + "," +
                        textBox2.Text.ToString().Trim() + ",'" +
                        textBox4.Text.ToString().Trim() + "','" +
                        coment1 + "','" +
                        coment2 + "','" +
                        "A','" +
                        Clases.Usuario + "','"+
                        "A'";
                if (!Conexion.Inserta_Datos(sql, ref Error))
                {
                    MessageBox.Show(Error);
                    return;
                }
            }
            

            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;
            }
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            Codreservacion.Text = "";
            motivo.Text = "";
            richTextBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tipob form = new tipob("e", "tipo_archivo", "Tipo Archivo");
            form.ShowDialog();
            if (form.Id.ToString().Trim() != "")
            {
                textBox2.Text = form.Id.ToString().Trim();
                
            }
        }
    }
}
