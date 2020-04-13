
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
    public partial class Mant_Cama : Form
    {
        string aa_modo = "";
        Clases.ECama aa_ECama = new Clases.ECama();
        public Mant_Cama(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;

        }
        public Mant_Cama(string ii_modo, Clases.ECama ii_ECama)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_ECama = ii_ECama;
        }

        private void Mant_Cama_Load(object sender, EventArgs e)
        {
            CB_ESTADO.Items.Add("A");
            CB_ESTADO.Items.Add("I");
            CB_ESTADO.SelectedIndex = 0;
            if (aa_modo.ToString().Trim().ToLower() != "a")
            {

                Pasa_Datos();

            }
        }
        void Pasa_Datos()
        {
            tid.Text = aa_ECama.id_cama;
            tDESCR.Text = aa_ECama.descr_cama.ToString().Trim().ToUpper();
            TCapacidad.Text = aa_ECama.capacidad_cama.ToString().Trim().ToUpper();
            if (aa_ECama.estado_cama.ToUpper() != "A")
            {
                CB_ESTADO.SelectedIndex = 1;
            }


        }

        void Limpia()
        {
            tid.Text = "";
            tDESCR.Text = "";
            CB_ESTADO.SelectedIndex = 0;
            TCapacidad.Text = "";
        }

        private void tid_Leave(object sender, EventArgs e)
        {
            if (tid.Text.ToString().Trim() != "")
            {
                if (tid.Text.ToString().Trim() == "*")
                {

                    tid.Text = funciones.Prox_Codigo("Cama").ToString("######");
                }
                else
                {
                    aa_ECama = funciones.Lee_Cama(tid.Text.ToString().Trim());
                    if (aa_ECama != null)
                    {
                        aa_modo = "m";
                        tDESCR.Text = aa_ECama.descr_cama;
                        TCapacidad.Text = aa_ECama.capacidad_cama.ToString();
                        if (aa_ECama.estado_cama.ToUpper() == "A")
                            CB_ESTADO.SelectedIndex = 0;
                        else
                            CB_ESTADO.SelectedIndex = 1;
                    }
                    else
                    {
                        Valida_codigo();
                    }
                }
            }
        }
        bool Valida_codigo()
        {
            int id = 0;
            if (!int.TryParse(tid.Text.ToString(), out id))
            {
                MessageBox.Show("SOLO VALORES NUMERICOS");
                return false;
            }

            return true;

        }
        private void tid_TextChanged(object sender, EventArgs e)
        {
            //if (tid.Text.ToString().IndexOf("*") < 0 && tid.Text.ToString().Trim() != "")
            //    Valida_codigo();
        }


        private void BGuardar_Click(object sender, EventArgs e)
        {
            string sql = "";
            string Error = "";
            errorProvider1.Clear();
            string mensaje = "ESTE CAMPO NO PUEDE ESTAR EN BLANCO";
            if (string.IsNullOrWhiteSpace(tid.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(tid, mensaje);
                tid.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tDESCR.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(tDESCR, mensaje);
                tDESCR.Focus();
            }
            if (aa_modo.ToUpper().Trim() == "A")
            {
                if (CB_ESTADO.SelectedIndex != 0)
                {
                    MessageBox.Show("NO PUEDE REGISTRAR CON ESTADO DIFERENTE DE ACTIVO");
                    return;

                }
            }

            sql = "EXEC ACTCAMA '" +
                            tid.Text.ToString() + "','" +
                            tDESCR.Text.ToString().Trim() + "','" +
                            TCapacidad.Text.ToString().Trim() + "','" +
                            CB_ESTADO.SelectedItem.ToString().Trim() + "','" +
                            aa_modo.ToUpper().Trim() + "'";


            if (!Conexion.Inserta_Datos(sql, ref Error))
            {
                MessageBox.Show(Error);
                return;
            }
            if (aa_modo.Trim().ToLower() == "a")
            {
                Limpia();

            }
            else
            {
                this.DialogResult = DialogResult.OK;
                return;

            }


        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
            aa_modo = "a";
        }
    }
}
