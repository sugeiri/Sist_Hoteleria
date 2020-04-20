
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
    public partial class Mant_Oferta : Form
    {
        string aa_modo = "";
        Clases.EOferta aa_EOferta = new Clases.EOferta();
        public Mant_Oferta(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;

        }
        public Mant_Oferta(string ii_modo, Clases.EOferta ii_EOferta)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_EOferta = ii_EOferta;
        }
        private void Mant_Oferta_Load(object sender, EventArgs e)
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
            tid.Text = aa_EOferta.id_oferta;
            tDESCR.Text = aa_EOferta.descr_oferta.ToString().Trim().ToUpper();
            if (aa_EOferta.estado_oferta.ToUpper() != "A")
            {
                CB_ESTADO.SelectedIndex = 1;
            }
            TTemporada.Text = aa_EOferta.id_temp_oferta.ToString().Trim().ToUpper();
            Tdescr_Temporada.Text = funciones.Lee_Descr_Tipo(aa_EOferta.id_temp_oferta,"Temporada");
        }
        private void BLimpiar_Click(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(TTemporada.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(tDESCR, mensaje);
                TTemporada.Focus();
            }
            if (aa_modo.ToUpper().Trim() == "A")
            {
                if (CB_ESTADO.SelectedIndex != 0)
                {
                    MessageBox.Show("NO PUEDE REGISTRAR CON ESTADO DIFERENTE DE ACTIVO");
                    return;

                }
            }
            sql = "EXEC ACTOferta '" + tid.Text.ToString()
                                        + "','" + tDESCR.Text.ToString().Trim()
                                        + "','" + TTemporada.Text.ToString().Trim() 
                                        + "','" + CB_ESTADO.SelectedItem.ToString().Trim()
                                        + "','"+aa_modo.ToUpper() + "'";



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
        void Limpia()
        {
            tid.Text = "";
            tDESCR.Text = "";
            CB_ESTADO.SelectedIndex = 0;
            TTemporada.Text = "";
            Tdescr_Temporada.Text = "";
        }

        private void tid_Leave(object sender, EventArgs e)
        {
            if (tid.Text.ToString().Trim() != "")
            {
                
                    aa_EOferta = funciones.Lee_Oferta(tid.Text.ToString().Trim());
                    if (aa_EOferta != null)
                    {
                        aa_modo = "m";
                        tDESCR.Text = aa_EOferta.descr_oferta;
                        if (aa_EOferta.estado_oferta.ToUpper() == "A")
                            CB_ESTADO.SelectedIndex = 0;
                        else
                            CB_ESTADO.SelectedIndex = 1;
                        TTemporada.Text = aa_EOferta.id_temp_oferta;
                        Tdescr_Temporada.Text = funciones.Lee_Descr_Tipo(aa_EOferta.id_temp_oferta,"Temporada");
                    }
                    
            }
        }
       
        private void tid_TextChanged(object sender, EventArgs e)
        {
            //if (tid.Text.ToString().IndexOf("*") < 0 && tid.Text.ToString().Trim() != "")
            //    Valida_codigo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpia();
            aa_modo = "a";
        }

        private void BProvincia_Click(object sender, EventArgs e)
        {
            Mant_C_Temporada form = new Mant_C_Temporada("","e");
            form.ShowDialog();
            if(form.Id.ToString().Trim()!="")
            {
                TTemporada.Text = form.Id.ToString().Trim();
                Tdescr_Temporada.Text = funciones.Lee_Descr_Tipo(form.Id.ToString().Trim(),"temporada");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
