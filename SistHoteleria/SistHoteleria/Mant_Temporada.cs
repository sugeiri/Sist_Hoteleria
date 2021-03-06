﻿
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
    public partial class Mant_Temporada : Form
    {
        string aa_modo = "";
        Clases.ETemporada aa_ETemporada = new Clases.ETemporada();
        public Mant_Temporada(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;

        }
        public Mant_Temporada(string ii_modo, Clases.ETemporada ii_ETemporada)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_ETemporada = ii_ETemporada;
        }

        private void Mant_Temporada_Load(object sender, EventArgs e)
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
            tid.Text = aa_ETemporada.id_temporada;
            tDESCR.Text = aa_ETemporada.descr_temporada.ToString().Trim().ToUpper();
            FechaIni.Value = DateTime.Parse(aa_ETemporada.fecha_i_temporada);
            FechaFin.Value = DateTime.Parse(aa_ETemporada.fecha_f_temporada);
            if (aa_ETemporada.estado_temporada.ToUpper() != "A")
            {
                CB_ESTADO.SelectedIndex = 1;
            }


        }

        void Limpia()
        {
            tid.Text = "";
            tDESCR.Text = "";
            CB_ESTADO.SelectedIndex = 0;
            FechaIni.Value = DateTime.Now;
            FechaFin.Value = DateTime.Now;
        }

        private void tid_Leave(object sender, EventArgs e)
        {
            if (tid.Text.ToString().Trim() != "")
            {
                aa_ETemporada = funciones.Lee_Temporada(tid.Text.ToString().Trim());
                if (aa_ETemporada != null)
                {
                    aa_modo = "m";
                    tDESCR.Text = aa_ETemporada.descr_temporada;
                    FechaIni.Value = DateTime.Parse(aa_ETemporada.fecha_i_temporada);
                    FechaFin.Value = DateTime.Parse(aa_ETemporada.fecha_f_temporada);
                    if (aa_ETemporada.estado_temporada.ToUpper() == "A")
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

            if (aa_modo.ToUpper().Trim() == "A")
            {
                if (CB_ESTADO.SelectedIndex != 0)
                {
                    MessageBox.Show("NO PUEDE REGISTRAR CON ESTADO DIFERENTE DE ACTIVO");
                    return;

                }
            }
            sql = "EXEC ACTTemporada '" + tid.Text.ToString()
                                       + "','" + tDESCR.Text.ToString().Trim()
                                       + "','" + FechaIni.Value.ToString("yyyy-MM-dd").ToString().Trim()
                                       + "','" + FechaFin.Value.ToString("yyyy-MM-dd").ToString().Trim()
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
