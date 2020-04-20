using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistHoteleria
{
    public partial class Conf_OfertaxCantAlojamiento : Form
    {
        string aa_modo = "a";
        string aa_id = "";
        string Error = "";
        Clases.EOferta aa_EOFerta = new Clases.EOferta();
        List<Clases.EOfertaxRangoAlojamientos> aa_Rango = new List<Clases.EOfertaxRangoAlojamientos>();
        public Conf_OfertaxCantAlojamiento(string ii_modo, string ii_id)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_id = ii_id;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        void Agrega_Fila(string id)
        {


        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {



        }

        private void Conf_OfertaxCantAlojamiento_Load(object sender, EventArgs e)
        {


            if (aa_modo.ToUpper() == "A")
            {
                TOferta.Enabled = true;

            }
            else
            {
                aa_EOFerta = funciones.Lee_Oferta(aa_id.ToString());
                Pasa_Datos();


            }


        }

        bool Inserta_Datos()
        {
            Error = "";
            List<Clases.EOfertaxRangoAlojamientos> aa_RangoTHab = new List<Clases.EOfertaxRangoAlojamientos>();
            Clases.EOfertaxRangoAlojamientos aa_ECaracteristicasTHab = new Clases.EOfertaxRangoAlojamientos();
            for (int ii = 0; ii < dg_Caracteristicas.RowCount - 1; ii++)
            {
                aa_ECaracteristicasTHab = new Clases.EOfertaxRangoAlojamientos();

                aa_ECaracteristicasTHab.id_oferta_det03 = TOferta.Text;
                aa_ECaracteristicasTHab.c_ini_aloj_det03 = int.Parse(dg_Caracteristicas.Rows[ii].Cells[0].Value.ToString().Trim());
                aa_ECaracteristicasTHab.c_fin_aloj_det03 = int.Parse(dg_Caracteristicas.Rows[ii].Cells[1].Value.ToString().Trim());
                aa_ECaracteristicasTHab.descuento_det03 = decimal.Parse(dg_Caracteristicas.Rows[ii].Cells[2].Value.ToString().Trim());

                aa_RangoTHab.Add(aa_ECaracteristicasTHab);
            }

            if (funciones.Inserta_Oferta_xRango(aa_RangoTHab, ref Error))
            {
                return true;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(Error.Trim()))
                {
                    MessageBox.Show(Error.ToString().Trim());
                }
            }
            return false;
        }

        bool Valida_Datos()
        {
            errorProvider1.Clear();
            string Msj = "Este Campo No Puede Estar en Blanco";
            if (aa_modo.ToUpper() == "A")
            {

                if (TOferta.Text.ToString().Trim() == "")
                {
                    MessageBox.Show(Msj);
                    errorProvider1.SetError(TOferta, Msj);
                    return false;
                }


                if (dg_Caracteristicas.RowCount <= 1)
                {
                    MessageBox.Show("Debe Indicar Al menos Un Rango");
                    return false;
                }



            }
            return true;
        }
        void Pasa_Datos()
        {
            TOferta.Text = aa_EOFerta.id_oferta.ToString();
            TdescOferta.Text = aa_EOFerta.descr_oferta.ToString().ToUpper();
            aa_Rango = new List<Clases.EOfertaxRangoAlojamientos>();
            aa_Rango = funciones.Lee_Oferta_xRango(aa_EOFerta.id_oferta);

            if (aa_Rango != null)
            {

                dg_Caracteristicas.Rows.Clear();
                foreach (var Caracteristicas in aa_Rango)
                {

                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(dg_Caracteristicas);
                    ii_row.Cells[0].Value = Caracteristicas.c_ini_aloj_det03.ToString().Trim();
                    ii_row.Cells[1].Value = Caracteristicas.c_fin_aloj_det03.ToString().Trim();
                    ii_row.Cells[2].Value = Caracteristicas.descuento_det03.ToString().Trim();
                    dg_Caracteristicas.Rows.Add(ii_row);
                }
            }

        }


        private void BSeguir_Click(object sender, EventArgs e)
        {
            if (Valida_Datos())
            {
                if (Inserta_Datos())
                {
                    MessageBox.Show("DATOS GUARDADOS");
                    if (aa_modo.ToUpper() != "A")
                    {
                        this.DialogResult = DialogResult.OK;
                        return;

                    }
                    Limpia_Datos();

                }

            }
            else
            {
                MessageBox.Show("No Pudo Grabar OFERTA x Rango -->" + Error);
            }




        }

        void Limpia_Datos()
        {
            aa_EOFerta = new Clases.EOferta();
            aa_id = "";
            aa_modo = "a";
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }

                }
                catch { }
            }

            dg_Caracteristicas.Rows.Clear();
            TOferta.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE QUERER LIMPIAR LOS DATOS?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            dg_Caracteristicas.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dg_Caracteristicas.Rows.Count - 1; i++)
            {
                if (dg_Caracteristicas.Rows[i].Cells[0].Selected || dg_Caracteristicas.Rows[i].Cells[1].Selected)
                {
                    dg_Caracteristicas.Rows.RemoveAt(i);

                }
            }
        }

        private void dg_Caracteristicas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void BTHabitacion_Click(object sender, EventArgs e)
        {
            Mant_C_Oferta CP = new Mant_C_Oferta("", "e");
            CP.ShowDialog();
            string id = CP.Id.ToString().Trim();
            if (id.Trim() != "0")
            {
                string descr = funciones.Lee_Descr_Tipo(id, "Oferta");
                if (descr.Trim() != "")
                {
                    TOferta.Text = id;
                    TdescOferta.Text = descr;
                    List<Clases.EOfertaxRangoAlojamientos> int_med_Esp = funciones.Lee_Oferta_xRango(id);
                    if (int_med_Esp != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Ya Existe Asignacion de Rangos para esta Oferta , Desea Modificar?", "Alerta", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            TOferta.Text = "";
                            return;

                        }
                        aa_modo = "m";
                        TOferta.Enabled = true;
                        aa_EOFerta.id_oferta = int_med_Esp[0].id_oferta_det03;
                        Pasa_Datos();
                    }
                }
                else
                {
                    MessageBox.Show("No Existe esta Oferta en la Base de Datos");
                    return;
                }

            }
        }

        private void TTHabitacion_Leave(object sender, EventArgs e)
        {
            if (TOferta.Text.ToString().Trim() != "")
            {
                string descr = funciones.Lee_Descr_Tipo(TOferta.Text, "Oferta");
                if (descr.Trim() != "")
                {
                    TdescOferta.Text = descr;
                    List<Clases.EOfertaxRangoAlojamientos> int_med_Esp = funciones.Lee_Oferta_xRango(TOferta.Text);
                    if (int_med_Esp != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Ya Existe Asignacion de Rangos para esta Oferta , Desea Modificar?", "Alerta", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            TOferta.Text = "";
                            return;

                        }
                        aa_modo = "m";
                        TOferta.Enabled = true;
                        aa_EOFerta.id_oferta = int_med_Esp[0].id_oferta_det03;
                        Pasa_Datos();
                    }
                }
                else
                {
                    MessageBox.Show("No Existe esta Oferta en la Base de Datos");
                    return;
                }
            }

        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            Limpia_Datos();
        }
    }
}
