
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
    public partial class Mant_Municipio : Form
    {
        string aa_modo = "";
        Clases.EMunicipio aa_EMunicipio = new Clases.EMunicipio();
        public Mant_Municipio(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;

        }
        public Mant_Municipio(string ii_modo, Clases.EMunicipio ii_EMunicipio)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_EMunicipio = ii_EMunicipio;
        }
        private void Mant_Municipio_Load(object sender, EventArgs e)
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
            tid.Text = aa_EMunicipio.id_municipio;
            tDESCR.Text = aa_EMunicipio.descr_municipio.ToString().Trim().ToUpper();
            if (aa_EMunicipio.estado_municipio.ToUpper() != "A")
            {
                CB_ESTADO.SelectedIndex = 1;
            }
            TProvincia.Text = aa_EMunicipio.id_prov_municipio.ToString().Trim().ToUpper();
            Tdescr_Provincia.Text = funciones.Lee_Provincia(aa_EMunicipio.id_prov_municipio).descr_provincia;
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
            if (string.IsNullOrWhiteSpace(TProvincia.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(tDESCR, mensaje);
                TProvincia.Focus();
            }
            if (aa_modo.ToUpper().Trim() == "A")
            {
                if (CB_ESTADO.SelectedIndex != 0)
                {
                    MessageBox.Show("NO PUEDE REGISTRAR CON ESTADO DIFERENTE DE ACTIVO");
                    return;

                }
            }
            sql = "EXEC ACTMunicipio '" + tid.Text.ToString()
                                        + "','" + tDESCR.Text.ToString().Trim()
                                        + "','" + TProvincia.Text.ToString().Trim() 
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
            TProvincia.Text = "";
            Tdescr_Provincia.Text = "";
        }

        private void tid_Leave(object sender, EventArgs e)
        {
            if (tid.Text.ToString().Trim() != "")
            {
                if (tid.Text.ToString().Trim() == "*")
                {

                    tid.Text = funciones.Prox_Codigo("Municipio").ToString("######");
                }
                else {
                    aa_EMunicipio = funciones.Lee_Municipio(tid.Text.ToString().Trim());
                    if (aa_EMunicipio != null)
                    {
                        aa_modo = "m";
                        tDESCR.Text = aa_EMunicipio.descr_municipio;
                        if (aa_EMunicipio.estado_municipio.ToUpper() == "A")
                            CB_ESTADO.SelectedIndex = 0;
                        else
                            CB_ESTADO.SelectedIndex = 1;
                        TProvincia.Text = aa_EMunicipio.id_prov_municipio;
                        Tdescr_Provincia.Text = funciones.Lee_Provincia(aa_EMunicipio.id_prov_municipio).descr_provincia;
                    }
                    //else
                    //{
                    //    Valida_codigo();
                    //}
                }
            }
        }
        //bool Valida_codigo()
        //{
        //    int id = 0;
        //    if (!int.TryParse(tid.Text.ToString(), out id))
        //    {
        //        MessageBox.Show("SOLO VALORES NUMERICOS");
        //        return false;
        //    }

        //    return true;

        //}
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
            tipob form = new tipob("e", "Provincia", "Provincia");
            form.ShowDialog();
            if(form.Id.ToString().Trim()!="")
            {
                TProvincia.Text = form.Id.ToString().Trim();
                Tdescr_Provincia.Text = funciones.Lee_Provincia(form.Id.ToString().Trim()).descr_provincia;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
