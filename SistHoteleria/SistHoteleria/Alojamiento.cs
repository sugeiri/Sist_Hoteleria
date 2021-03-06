﻿using System;
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
    public partial class Alojamiento : Form
    {
        string aa_modo = "a";
        string aa_id = "";
        string Error = "";
        Clases.EAlojamiento aa_EAlojamiento = new Clases.EAlojamiento();
        Clases.EReserva aa_EReserva = new Clases.EReserva();
        List<Clases.EAlojamiento_Detalle> aa_LEAlojamiento_Detalle = new List<Clases.EAlojamiento_Detalle>();
        public Alojamiento(string ii_modo, string ii_id)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_id = ii_id;
        }
        public Alojamiento(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        //    //LEE Caracteristicas PARA ENCADENAR
        //    Mant_C_TipoHabitacion form = new Mant_C_TipoHabitacion("e");
        //    form.ShowDialog();
        //    string id_T = form.Id.Trim();
        //    if (!string.IsNullOrWhiteSpace(id_T.Trim()))
        //    {
        //        Agrega_Fila(id_T);
        //    }

        }
      

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ////LEE Caracteristicas PARA ENCADENAR
            //Mant_C_TipoHabitacion form = new Mant_C_TipoHabitacion("e");
            //form.ShowDialog();
            //string id_T = form.Id.Trim();
            //if (!string.IsNullOrWhiteSpace(id_T.Trim()))
            //{
            //    Agrega_Fila(id_T);
            //}


        }

        private void Alojamiento_Load(object sender, EventArgs e)
        {


            if (aa_modo.ToUpper() == "A")
            {
                CB_Estado.SelectedIndex = 0;
                TAlojamiento.Text = funciones.Prox_Codigo("alojamiento").ToString();
                DateTime fecha = DateTime.Today;
               // DT_Fecha_Ini.Value = fecha;

             //TFecha_Fin_Reserva.Text= fecha.AddDays(1);
                

            }
            
            else
            {

                aa_EAlojamiento = funciones.Lee_Alojamiento(aa_id.ToString());
                Pasa_Datos();


            }


        }

      
        void Pasa_Datos()
        {
            TAlojamiento.Text = aa_EAlojamiento.id_alojamiento;
            TReserva.Text = aa_EAlojamiento.id_reserv_alojamiento;
          
               aa_EReserva= funciones.Lee_Reserva(TReserva.Text.ToString());
            TFecha_ini_Reserva.Text = aa_EReserva.fecha_lleg_reservacion;
            TFecha_Fin_Reserva.Text = aa_EReserva.fecha_sal_reservacion;
            TimeSpan dias = DateTime.Parse(TFecha_Fin_Reserva.Text) - DateTime.Parse(TFecha_ini_Reserva.Text);
            LNoches.Text = dias.Days.ToString();
            LTotalN.Text = (double.Parse(aa_EReserva.Monto_apagar) / int.Parse(LNoches.Text.ToString())).ToString();
            LTotal.Text = aa_EReserva.Monto_apagar;

            
            if (aa_EAlojamiento.estado_alojamiento.ToString().Trim().ToUpper() == "A")
            {
                CB_Estado.SelectedIndex = 0;
            }
            else
            {
                CB_Estado.SelectedIndex = 1;
            }
            foreach (var Det in aa_EAlojamiento.LEDetalle)
            {

                DataGridViewRow ii_row = new DataGridViewRow();
                ii_row.CreateCells(dg_Alojamientos);
                ii_row.Cells[0].Value = Det.id_hab_det.ToString().Trim();
                ii_row.Cells[1].Value = funciones.Lee_Descr_Tipo(Det.id_hab_det.ToString(), "habitacion");
                ii_row.Cells[2].Value = Det.id_clie_det.ToString().Trim();
                ii_row.Cells[3].Value = funciones.Lee_Descr_Tercero(Det.id_clie_det.ToString(),"cliente");
              
                dg_Alojamientos.Rows.Add(ii_row);



             
            }
            
            LNoches.Text = dias.Days.ToString();
            LTotalN.Text = (double.Parse(aa_EReserva.Monto_apagar) / int.Parse(LNoches.Text.ToString())).ToString();
            LTotal.Text = aa_EReserva.Monto_apagar;


        }


        private void BSeguir_Click(object sender, EventArgs e)
        {
            if (Valida_Datos())
            {
                if (Inserta_Datos())
                {
                    MessageBox.Show("DATOS GUARDADOS, Alojamiento -->" + TAlojamiento.Text.ToString());
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
                MessageBox.Show("No Pudo Grabar Alojamiento-->" + Error);
            }




        }
        bool Valida_Datos()
        {
            errorProvider1.Clear();
            bool if_clien = true;
            string Msj = "Este Campo No Puede Estar en Blanco";
            if (aa_modo.ToUpper() == "A")
            {

                if (dg_Alojamientos.RowCount <= 1)
                {
                    MessageBox.Show("Debe Alojamientor al menos 1 habitacion");
                    return false;
                }


                for (int i = 0; i < dg_Alojamientos.Rows.Count - 1; i++)
                {
                    if (dg_Alojamientos.Rows[i].Cells[2].Value == null)
                    {

                        if_clien = false;
                        break;


                    }
                }
                if (!if_clien)
                {
                    MessageBox.Show("Debe asignar cliente");
                    return false;
                }





            }
            return true;
        }
        bool Inserta_Datos()
        {
            Error = "";
            aa_EAlojamiento = new Clases.EAlojamiento();
            aa_EAlojamiento.id_alojamiento = TAlojamiento.Text.ToString();
            aa_EAlojamiento.id_reserv_alojamiento = TReserva.Text.ToString();
            aa_EAlojamiento.ing_por_alojamiento = Clases.Usuario;
            aa_EAlojamiento.fecha_i_alojamiento = (DateTime.Parse(TFecha_ini_Reserva.Text)).ToString("yyyy/MM/dd").Trim();
            aa_EAlojamiento.sal_por_alojamiento = Clases.Usuario;
            aa_EAlojamiento.fecha_s_alojamiento = (DateTime.Parse(TFecha_Fin_Reserva.Text)).ToString("yyyy/MM/dd").Trim();
            aa_EAlojamiento.estado_alojamiento = CB_Estado.SelectedItem.ToString().Substring(0, 1).Trim();

            List<Clases.EAlojamiento_Detalle> aa_LEAlojamiento_Detalle = new List<Clases.EAlojamiento_Detalle>();
            Clases.EAlojamiento_Detalle aa_EAlojamiento_Detalle = new Clases.EAlojamiento_Detalle();

            for (int ii = 0; ii < dg_Alojamientos.RowCount - 1; ii++)
            {
                aa_EAlojamiento_Detalle = new Clases.EAlojamiento_Detalle();
                aa_EAlojamiento_Detalle.id_alojamiento_det = TAlojamiento.Text;
                aa_EAlojamiento_Detalle.id_hab_det = dg_Alojamientos.Rows[ii].Cells[0].Value.ToString().Trim();
                aa_EAlojamiento_Detalle.id_clie_det = dg_Alojamientos.Rows[ii].Cells[2].Value.ToString().Trim();

                aa_LEAlojamiento_Detalle.Add(aa_EAlojamiento_Detalle);

            }
                 

            // INSERTA ENCABEZADO
            if (funciones.Inserta_Alojamiento(aa_EAlojamiento, aa_modo, ref Error))
            {
                if (funciones.Inserta_Detalle_Alojamiento(aa_LEAlojamiento_Detalle, aa_EAlojamiento.id_alojamiento,"m", ref Error))
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


        void Limpia_Datos()
        {
          //  aa_THabitacion = new Clases.ETHabitacion();
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

            dg_Alojamientos.Rows.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE QUERER LIMPIAR LOS DATOS?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            dg_Alojamientos.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dg_Alojamientos.Rows.Count - 1; i++)
            {
                if (dg_Alojamientos.Rows[i].Cells[0].Selected || dg_Alojamientos.Rows[i].Cells[1].Selected)
                {
                    dg_Alojamientos.Rows.RemoveAt(i);

                }
            }
        }

        private void dg_Alojamiento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && dg_Alojamientos.Rows[e.RowIndex].Cells[0] != null && (e.RowIndex < dg_Alojamientos.Rows.Count - 1))
            {
                string SelectedText = dg_Alojamientos.Rows[e.RowIndex].Cells[0].Value.ToString();
                string descr = funciones.Lee_Descr_Tipo(SelectedText, "habitacion").ToString().Trim();
                if (descr == "")
                {
                    MessageBox.Show("No Existe Esta  Habitacion");
                    return;

                }
                dg_Alojamientos.Rows[e.RowIndex].Cells[0].Value = int.Parse(SelectedText);
                dg_Alojamientos.Rows[e.RowIndex].Cells[1].Value = descr.ToUpper();


           

            }

            if (dg_Alojamientos.Columns[e.ColumnIndex].Name == "idClie")
            {
                string SelectedText = dg_Alojamientos.Rows[e.RowIndex].Cells[2].Value.ToString();
                string descr = funciones.Lee_Descr_Tercero(SelectedText, "Cliente").ToString().Trim();
                if (descr == "")
                {
                    MessageBox.Show("No Existe Este CLiente");
                    return;

                }
                dg_Alojamientos.Rows[e.RowIndex].Cells[2].Value = int.Parse(SelectedText);
                dg_Alojamientos.Rows[e.RowIndex].Cells[3].Value = descr.ToUpper();
            }
           
           


        }

            private void BLimpiar_Click(object sender, EventArgs e)
            {
                Limpia_Datos();
            }


       
        private void BReserva_Click(object sender, EventArgs e)
        {

            C_Reserva form = new C_Reserva("e");
            form.ShowDialog();
            if (form.aa_id.ToString().Trim() != "")
            {
                TReserva.Text = form.aa_id.ToString().Trim();
                aa_EReserva = funciones.Lee_Reserva(form.aa_id.ToString().Trim());
                TFecha_ini_Reserva.Text = aa_EReserva.fecha_lleg_reservacion;
                TFecha_Fin_Reserva.Text = aa_EReserva.fecha_sal_reservacion;
                TimeSpan dias =DateTime.Parse(TFecha_Fin_Reserva.Text) - DateTime.Parse(TFecha_ini_Reserva.Text);
                LNoches.Text = dias.Days.ToString();
                LTotalN.Text= (double.Parse(aa_EReserva.Monto_apagar) /int.Parse(LNoches.Text.ToString())).ToString();
                LTotal.Text = aa_EReserva.Monto_apagar;

            }
        }

    }
    }
