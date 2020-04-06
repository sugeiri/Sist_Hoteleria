
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
    public partial class Mant_Provincia : Form
    {
        string aa_modo = "";
        Clases.EProvincia aa_EProvincia = new Clases.EProvincia();
        public Mant_Provincia(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;

        }
        public Mant_Provincia(string ii_modo, Clases.EProvincia ii_EProvincia)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_EProvincia = ii_EProvincia;
        }
        private void Mant_Provincia_Load(object sender, EventArgs e)
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
            tid.Text = aa_EProvincia.id_provincia;
            tDESCR.Text = aa_EProvincia.descr_provincia.ToString().Trim().ToUpper();
            if (aa_EProvincia.estado_provincia.ToUpper() != "A")
            {
                CB_ESTADO.SelectedIndex = 1;
            }
            Tpais.Text = aa_EProvincia.id_pais_provincia.ToString().Trim().ToUpper();
            Tdescr_pais.Text = funciones.Lee_Descr_Pais(aa_EProvincia.id_pais_provincia);
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
            if (string.IsNullOrWhiteSpace(Tpais.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(tDESCR, mensaje);
                Tpais.Focus();
            }
            if (aa_modo.ToUpper().Trim() == "A")
            {
                if (CB_ESTADO.SelectedIndex != 0)
                {
                    MessageBox.Show("NO PUEDE REGISTRAR CON ESTADO DIFERENTE DE ACTIVO");
                    return;

                }
                sql = "INSERT INTO PROVINCIA VALUES('" + tid.Text.ToString() + "','" + tDESCR.Text.ToString().Trim() + "','" + CB_ESTADO.SelectedItem.ToString().Trim() + "'," + Tpais.Text.ToString().Trim() + ")";

            }
            else
            {

                sql = "UPDATE PROVINCIA SET " +
                        "descr_provincia='" + tDESCR.Text.ToUpper() + "'," +
                        "estado_provincia='" + CB_ESTADO.SelectedItem.ToString().ToUpper() + "'," +
                        "id_pais_provincia=" + Tpais.Text.ToString().ToUpper() + "'" +
                        " WHERE id_provincia=" + tid.Text.ToString().Trim() + "";


            }
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

            }

        }
        void Limpia()
        {
            tid.Text = "";
            tDESCR.Text = "";
            CB_ESTADO.SelectedIndex = 0;
            Tpais.Text = "";
            Tdescr_pais.Text = "";
        }

        private void tid_Leave(object sender, EventArgs e)
        {
            if (tid.Text.ToString().Trim() != "")
            {
                if (tid.Text.ToString().Trim() == "*")
                {

                    tid.Text = funciones.Prox_Codigo("PROVINCIA").ToString("######");
                }
                else {
                    aa_EProvincia = funciones.Lee_Provincia(tid.Text.ToString().Trim());
                    if (aa_EProvincia != null)
                    {
                        aa_modo = "m";
                        tDESCR.Text = aa_EProvincia.descr_provincia;
                        if (aa_EProvincia.estado_provincia.ToUpper() == "A")
                            CB_ESTADO.SelectedIndex = 0;
                        else
                            CB_ESTADO.SelectedIndex = 1;
                        Tpais.Text = aa_EProvincia.id_pais_provincia;
                        Tdescr_pais.Text = funciones.Lee_Descr_Pais(aa_EProvincia.id_pais_provincia);
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
            if (tid.Text.ToString().IndexOf("*") < 0 && tid.Text.ToString().Trim() != "")
                Valida_codigo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpia();
            aa_modo = "a";
        }

        private void BPais_Click(object sender, EventArgs e)
        {
            tipob form = new tipob("e", "PAIS", "PAIS");
            form.ShowDialog();
            if(form.Id.ToString().Trim()!="")
            {
                Tpais.Text = form.Id.ToString().Trim();
                Tdescr_pais.Text = funciones.Lee_Descr_Pais(form.Id.ToString().Trim());
            }
        }
    }
}
