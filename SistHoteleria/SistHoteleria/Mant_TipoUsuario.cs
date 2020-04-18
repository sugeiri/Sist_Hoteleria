
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
    public partial class Mant_TipoUsuario : Form
    {
        string aa_modo = "";
        string aa_id = "";
        Clases.ETipoUsuario aa_ETipoUsuario = new Clases.ETipoUsuario();
        public Mant_TipoUsuario(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;

        }
        public Mant_TipoUsuario(string ii_modo, Clases.ETipoUsuario ii_ETipoUsuario)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_ETipoUsuario = ii_ETipoUsuario;
        }

        private void Mant_TipoUsuario_Load(object sender, EventArgs e)
        {
            CB_ESTADO.Items.Add("A");
            CB_ESTADO.Items.Add("I");
            CB_ESTADO.SelectedIndex = 0;
            rb_un.Checked = true;
            if (aa_modo.ToString().Trim().ToLower() != "a")
            {

                Pasa_Datos();

            }
        }
        void Pasa_Datos()
        {
            tid.Text = aa_ETipoUsuario.id_T_Usuario;
            tDESCR.Text = aa_ETipoUsuario.Descripcion_T_Usuario.ToString().Trim().ToUpper();
            if (aa_ETipoUsuario.Estado_T_Usuario.ToUpper() != "A")
            {
                CB_ESTADO.SelectedIndex = 1;
            }

            switch (aa_ETipoUsuario.Nivel_Acceso_T_Usuario.ToUpper())
            {
                case "A":
                    rb_adm.Checked = true;
                    break;
                case "E":
                    rb_enc.Checked = true;
                    break;
                case "O":
                    rb_obs.Checked = true;
                    break;
                case "U":
                    rb_un.Checked = true;
                    break;
            }


        }

        void Limpia()
        {
            tid.Text = "";
            tDESCR.Text = "";
            CB_ESTADO.SelectedIndex = 0;
            rb_adm.Checked = false;
            rb_enc.Checked = false;
            rb_obs.Checked = false;
            rb_un.Checked = true;
        }

        private void tid_Leave(object sender, EventArgs e)
        {
            if (tid.Text.ToString().Trim() != "")
            {

                aa_ETipoUsuario = funciones.Lee_TipoUsuario(tid.Text.ToString().Trim());
                if (aa_ETipoUsuario != null)
                {
                    aa_modo = "m";
                    tDESCR.Text = aa_ETipoUsuario.Descripcion_T_Usuario;
                    switch (aa_ETipoUsuario.Nivel_Acceso_T_Usuario.ToUpper().Trim())
                    {
                        case "A":
                            rb_adm.Checked = true;
                            break;
                        case "E":
                            rb_enc.Checked = true;
                            break;
                        case "O":
                            rb_obs.Checked = true;
                            break;
                        case "U":
                            rb_un.Checked = true;
                            break;
                    }
                    if (aa_ETipoUsuario.Estado_T_Usuario.ToUpper() == "A")
                        CB_ESTADO.SelectedIndex = 0;
                    else
                        CB_ESTADO.SelectedIndex = 1;

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
            string nivel = "";
            if (rb_adm.Checked)
                nivel = "A";
            if (rb_enc.Checked)
                nivel = "E";
            if (rb_obs.Checked)
                nivel = "O";
            if (rb_un.Checked)
                nivel = "U";

            if (aa_modo.ToUpper().Trim() == "A")
            {
                if (CB_ESTADO.SelectedIndex != 0)
                {
                    MessageBox.Show("NO PUEDE REGISTRAR CON ESTADO DIFERENTE DE ACTIVO");
                    return;

                }
            }
            sql = "EXEC ACTTipo_Usuario '" + tid.Text.ToString() + "','"
                                       + tDESCR.Text.ToString().Trim() + "','"
                                       + nivel.ToString().Trim() + "','"
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
