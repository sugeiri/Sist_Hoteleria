
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
    public partial class Mant_Habitacion : Form
    {
        string aa_modo = "";
        Clases.EHabitacion aa_EHabitacion = new Clases.EHabitacion();
        public Mant_Habitacion(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;

        }
        public Mant_Habitacion(string ii_modo, Clases.EHabitacion ii_EHabitacion)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_EHabitacion = ii_EHabitacion;
        }

        private void Mant_Habitacion_Load(object sender, EventArgs e)
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
            tid.Text = aa_EHabitacion.id_habitacion;
            tDESCR.Text = aa_EHabitacion.descr_habitacion.ToString().Trim().ToUpper();
            TTHabitacion.Text = aa_EHabitacion.t_habitacion.ToString().Trim().ToUpper();
            TEdificio.Text = aa_EHabitacion.edificio_habitacion.ToString().Trim().ToUpper();
            TPiso.Text = aa_EHabitacion.piso_habitacion.ToString().Trim().ToUpper();
            if (aa_EHabitacion.estado_habitacion.ToUpper() != "A")
            {
                CB_ESTADO.SelectedIndex = 1;
            }
            TDescr_Edificio.Text = funciones.Lee_Edificio(aa_EHabitacion.edificio_habitacion).descr_edificio;
            TDescr_THabitacion.Text = funciones.Lee_TipoHabitacion(aa_EHabitacion.t_habitacion).descr_t_hab;

        }
        
        void Limpia()
        {
            tid.Text = "";
            tDESCR.Text = "";
            TTHabitacion.Text = "";
            TEdificio.Text = "";
            TPiso.Text = "";
            CB_ESTADO.SelectedIndex = 0;
            
        }

        private void tid_Leave(object sender, EventArgs e)
        {
            if (tid.Text.ToString().Trim() != "")
            {
                if (tid.Text.ToString().Trim() == "*")
                {

                    tid.Text = funciones.Prox_Codigo("habitacion").ToString("######");
                }
                else {
                    aa_EHabitacion = funciones.Lee_Habitacion(tid.Text.ToString().Trim());
                    if (aa_EHabitacion != null)
                    {
                        aa_modo = "m";
                        tDESCR.Text = aa_EHabitacion.descr_habitacion;
                        TTHabitacion.Text = aa_EHabitacion.t_habitacion;
                        TEdificio.Text = aa_EHabitacion.edificio_habitacion;
                        TPiso.Text = aa_EHabitacion.piso_habitacion.ToString();
                        if (aa_EHabitacion.estado_habitacion.ToUpper() == "A")
                            CB_ESTADO.SelectedIndex = 0;
                        else
                            CB_ESTADO.SelectedIndex = 1;
                        TDescr_Edificio.Text = funciones.Lee_Edificio(aa_EHabitacion.edificio_habitacion).descr_edificio;
                        TDescr_THabitacion.Text = funciones.Lee_TipoHabitacion(aa_EHabitacion.t_habitacion).descr_t_hab;

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
                sql = "EXEC ACTHabitacion '" + tid.Text.ToString() + "','"  
                                             + tDESCR.Text.ToString().Trim() + "','" 
                                             + TTHabitacion.Text.ToString().Trim()+"','" 
                                             + TEdificio.Text.ToString().Trim() + "','"
                                             + TPiso.Text.ToString().Trim() + "','"
                                             + CB_ESTADO.SelectedItem.ToString().Trim() + "','"
                                             + aa_modo.ToUpper().Trim()+"'";

           
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

        private void BTHabitacion_Click(object sender, EventArgs e)
        {
            Mant_C_TipoHabitacion form = new Mant_C_TipoHabitacion("e");
            form.ShowDialog();
            if (form.Id.ToString().Trim() != "")
            {
                TTHabitacion.Text = form.Id.ToString().Trim();
                TDescr_THabitacion.Text = funciones.Lee_TipoHabitacion(form.Id.ToString().Trim()).descr_t_hab;
            }
        }

        private void BEdificio_Click(object sender, EventArgs e)
        {
            Mant_C_TipoUsuario form = new Mant_C_TipoUsuario("e");
            form.ShowDialog();
            if (form.Id.ToString().Trim() != "")
            {
                TEdificio.Text = form.Id.ToString().Trim();
                TDescr_Edificio.Text = funciones.Lee_Edificio(form.Id.ToString().Trim()).descr_edificio;
            }
        }
    }
}
