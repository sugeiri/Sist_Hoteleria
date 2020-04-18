
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
    public partial class Mant_TipoAlojamiento : Form
    {
        string aa_modo = "";
        Clases.ETipoAlojamiento aa_ETipoAlojamiento = new Clases.ETipoAlojamiento();
        public Mant_TipoAlojamiento(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;

        }
        public Mant_TipoAlojamiento(string ii_modo, Clases.ETipoAlojamiento ii_ETipoAlojamiento)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_ETipoAlojamiento = ii_ETipoAlojamiento;
        }

        private void Mant_TipoAlojamiento_Load(object sender, EventArgs e)
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
            tid.Text = aa_ETipoAlojamiento.id_t_alojamiento;
            tDESCR.Text = aa_ETipoAlojamiento.descr_t_alojamiento.ToString().Trim().ToUpper();
            TCosto.Text = aa_ETipoAlojamiento.costo_t_alojamiento.ToString().Trim().ToUpper();
            if (aa_ETipoAlojamiento.estado_t_alojamiento.ToUpper() != "A")
            {
                CB_ESTADO.SelectedIndex = 1;
            }


        }

        void Limpia()
        {
            tid.Text = "";
            tDESCR.Text = "";
            CB_ESTADO.SelectedIndex = 0;
            TCosto.Text = "";
        }

        private void tid_Leave(object sender, EventArgs e)
        {
            if (tid.Text.ToString().Trim() != "")
            {
                if (tid.Text.ToString().Trim() == "*")
                {

                    tid.Text = funciones.Prox_Codigo("tipo_alojamiento").ToString("######");
                }
                else
                {
                    aa_ETipoAlojamiento = funciones.Lee_TipoAlojamiento(tid.Text.ToString().Trim());
                    if (aa_ETipoAlojamiento != null)
                    {
                        aa_modo = "m";
                        tDESCR.Text = aa_ETipoAlojamiento.descr_t_alojamiento;
                        TCosto.Text = aa_ETipoAlojamiento.costo_t_alojamiento.ToString();
                        if (aa_ETipoAlojamiento.estado_t_alojamiento.ToUpper() == "A")
                            CB_ESTADO.SelectedIndex = 0;
                        else
                            CB_ESTADO.SelectedIndex = 1;
                    }

                }
            }
        }
       
        private void tid_TextChanged(object sender, EventArgs e)
        {
            
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
            sql = "EXEC ACTtipo_alojamiento '" + tid.Text.ToString()
                                               + "','" + tDESCR.Text.ToString().Trim()
                                               + "','" + TCosto.Text.ToString().Trim()
                                               + "','" + CB_ESTADO.SelectedItem.ToString().Trim() + "',"
                                               + "'" + aa_modo.ToUpper() + "'";


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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
