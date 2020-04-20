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
    public partial class Conf_OfertaTAloj : Form
    {
        string aa_modo = "a";
        string aa_id = "";
        string Error = "";
        Clases.EOferta aa_EOFerta = new Clases.EOferta();
        List<Clases.EOfertatalojamiento> aa_LETAlojamiento = new List<Clases.EOfertatalojamiento>();
        public Conf_OfertaTAloj(string ii_modo, string ii_id)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_id = ii_id;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //LEE Caracteristicas PARA ENCADENAR
            Mant_C_TipoAlojamiento form = new Mant_C_TipoAlojamiento("e");
            form.ShowDialog();
            string id_T = form.Id.Trim();
            if (!string.IsNullOrWhiteSpace(id_T.Trim()))
            {
                Agrega_Fila(id_T);
            }

        }
        void Agrega_Fila(string id)
        {

            for (int i = 0; i < dg_Caracteristicas.Rows.Count - 1; i++)
            {
                if (dg_Caracteristicas.Rows[i].Cells[0].Value.ToString().Trim() == id.ToString().Trim())
                {
                    MessageBox.Show("Ya Existe Este Tipo ALojamiento para la Oferta");
                    return;
                }
            }

            DataGridViewRow ii_row = new DataGridViewRow();
            ii_row.CreateCells(dg_Caracteristicas);
            ii_row.Cells[0].Value = id;
            ii_row.Cells[1].Value = funciones.Lee_Descr_Tipo(id, "tipo_alojamiento");
            ii_row.Cells[2].Value = "0";
            dg_Caracteristicas.Rows.Add(ii_row);
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //LEE Caracteristicas PARA ENCADENAR
            Mant_C_TipoAlojamiento form = new Mant_C_TipoAlojamiento("e");
            form.ShowDialog();
            string id_T = form.Id.Trim();
            if (!string.IsNullOrWhiteSpace(id_T.Trim()))
            {
                Agrega_Fila(id_T);
            }


        }

        private void Conf_OfertaTAloj_Load(object sender, EventArgs e)
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
            List<Clases.EOfertatalojamiento> aa_LETAlojamientoTHab = new List<Clases.EOfertatalojamiento>();
            Clases.EOfertatalojamiento aa_ECaracteristicasTHab = new Clases.EOfertatalojamiento();
            for (int ii = 0; ii < dg_Caracteristicas.RowCount - 1; ii++)
            {
                aa_ECaracteristicasTHab = new Clases.EOfertatalojamiento();

                aa_ECaracteristicasTHab.id_oferta_det01 = TOferta.Text;
                aa_ECaracteristicasTHab.id_t_aloj_det01 = dg_Caracteristicas.Rows[ii].Cells[0].Value.ToString().Trim();
                aa_ECaracteristicasTHab.descuento_det01 = decimal.Parse(dg_Caracteristicas.Rows[ii].Cells[2].Value.ToString().Trim());

                aa_LETAlojamientoTHab.Add(aa_ECaracteristicasTHab);
            }

            if (funciones.Inserta_Oferta_TAlojamiento(aa_LETAlojamientoTHab, ref Error))
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
                    MessageBox.Show("Debe Indicar Al menos Un Tipo de Alojamiento");
                    return false;
                }



            }
            return true;
        }
        void Pasa_Datos()
        {
            TOferta.Text = aa_EOFerta.id_oferta.ToString();
            TdescOferta.Text = aa_EOFerta.descr_oferta.ToString().ToUpper();
            aa_LETAlojamiento = new List<Clases.EOfertatalojamiento>();
            aa_LETAlojamiento = funciones.Lee_Oferta_Talojamiento(aa_EOFerta.id_oferta);

            if (aa_LETAlojamiento != null)
            {

                dg_Caracteristicas.Rows.Clear();
                foreach (var Caracteristicas in aa_LETAlojamiento)
                {

                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(dg_Caracteristicas);
                    ii_row.Cells[0].Value = Caracteristicas.id_t_aloj_det01.ToString().Trim();
                    ii_row.Cells[1].Value = funciones.Lee_Descr_Tipo(Caracteristicas.id_t_aloj_det01.ToString(), "tipo_alojamiento");
                    ii_row.Cells[2].Value = Caracteristicas.descuento_det01.ToString().Trim();
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
                MessageBox.Show("No Pudo Grabar OFERTA -TIPO ALOJAMIENTO  -->" + Error);
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

            if (e.ColumnIndex == 0 && dg_Caracteristicas.Rows[e.RowIndex].Cells[0] != null && (e.RowIndex < dg_Caracteristicas.Rows.Count - 1))
            {
                if (dg_Caracteristicas.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    for (int i = 0; i < dg_Caracteristicas.Rows.Count - 1; i++)
                    {
                        if (i != e.RowIndex)
                        {
                            string n = dg_Caracteristicas.Rows[e.RowIndex].Cells[0].Value.ToString();
                            if (dg_Caracteristicas.Rows[i].Cells[0].Value.ToString().Trim() == n)
                            {
                                MessageBox.Show("Ya Existe Este Tipo de Alojamiento para la oferta");
                                dg_Caracteristicas.Rows.RemoveAt(e.RowIndex);
                                return;


                            }
                        }

                        string SelectedText = dg_Caracteristicas.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string descr = funciones.Lee_Descr_Tipo(SelectedText, "tipo_alojamiento").ToString().Trim();
                        if (descr == "")
                        {
                            MessageBox.Show("No Existe Este Tipo de ALojamiento");
                            return;

                        }
                        dg_Caracteristicas.Rows[e.RowIndex].Cells[0].Value = int.Parse(SelectedText);
                        dg_Caracteristicas.Rows[e.RowIndex].Cells[1].Value = descr.ToUpper();
                        dg_Caracteristicas.Rows[e.RowIndex].Cells[2].Value = 0;
                    }
                }
                else
                {
                    dg_Caracteristicas.Rows.RemoveAt(e.RowIndex);
                }

            }

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
                    List<Clases.EOfertatalojamiento> int_med_Esp = funciones.Lee_Oferta_Talojamiento(id);
                    if (int_med_Esp != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Ya Existe Asignacion de Tipos de Alojamiento para esta Oferta , Desea Modificar?", "Alerta", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            TOferta.Text = "";
                            return;

                        }
                        aa_modo = "m";
                        TOferta.Enabled = true;
                        aa_EOFerta.id_oferta = int_med_Esp[0].id_oferta_det01;
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
                    List<Clases.EOfertatalojamiento> int_med_Esp = funciones.Lee_Oferta_Talojamiento(TOferta.Text);
                    if (int_med_Esp != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Ya Existe Asignacion de Tipos de Alojamiento para esta Oferta , Desea Modificar?", "Alerta", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            TOferta.Text = "";
                            return;

                        }
                        aa_modo = "m";
                        TOferta.Enabled = true;
                        aa_EOFerta.id_oferta = int_med_Esp[0].id_oferta_det01;
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
