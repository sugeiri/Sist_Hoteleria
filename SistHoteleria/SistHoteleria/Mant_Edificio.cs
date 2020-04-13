
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
    public partial class Mant_Edificio : Form
    {
        string aa_modo = "";
        string aa_id = "";
        Clases.EEdificio aa_EEdificio = new Clases.EEdificio();
        public Mant_Edificio(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;

        }
        public Mant_Edificio(string ii_modo, Clases.EEdificio ii_EEdificio)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_EEdificio = ii_EEdificio;
        }

        private void Mant_Edificio_Load(object sender, EventArgs e)
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
            tid.Text = aa_EEdificio.id_edificio;
            tDESCR.Text = aa_EEdificio.descr_edificio.ToString().Trim().ToUpper();
            TNiveles.Text = aa_EEdificio.cant_nivel_edificio.ToString().Trim().ToUpper();
            if (aa_EEdificio.estado_edificio.ToUpper() != "A")
            {
                CB_ESTADO.SelectedIndex = 1;
            }


        }

        void Limpia()
        {
            tid.Text = "";
            tDESCR.Text = "";
            CB_ESTADO.SelectedIndex = 0;
            TNiveles.Text = "";
        }

        private void tid_Leave(object sender, EventArgs e)
        {
            if (tid.Text.ToString().Trim() != "")
            {
                if (tid.Text.ToString().Trim() == "*")
                {

                    tid.Text = funciones.Prox_Codigo("Edificio").ToString("######");
                }
                else
                {
                    aa_EEdificio = funciones.Lee_Edificio(tid.Text.ToString().Trim());
                    if (aa_EEdificio != null)
                    {
                        aa_modo = "m";
                        tDESCR.Text = aa_EEdificio.descr_edificio;
                        TNiveles.Text = aa_EEdificio.cant_nivel_edificio.ToString();
                        if (aa_EEdificio.estado_edificio.ToUpper() == "A")
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
            sql = "EXEC ACTEdificio '" + tid.Text.ToString() + "','"
                                       + tDESCR.Text.ToString().Trim() + "','"
                                       + TNiveles.Text.ToString().Trim() + "','"
                                       + CB_ESTADO.SelectedItem.ToString().Trim() + "','"
                                       + aa_modo.ToUpper().Trim() + "'";



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
