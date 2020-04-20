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
    public partial class Reserva : Form
    {
        string aa_modo = "a";
        string aa_id = "";
        string Error = "";
        Clases.EReserva aa_EReserva = new Clases.EReserva();
        List<Clases.EReserva_Detalle> aa_LEReserva_Detalle = new List<Clases.EReserva_Detalle>();
        public Reserva(string ii_modo, string ii_id)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_id = ii_id;
        }
        public Reserva(string ii_modo)
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
        void Agrega_Fila(string id)
        {

            for (int i = 0; i < dg_Reservas.Rows.Count - 1; i++)
            {
                if (dg_Reservas.Rows[i].Cells[0].Value.ToString().Trim() == id.ToString().Trim())
                {
                    MessageBox.Show("Ya Existe el Tipo de Habitacion");
                    return;
                }
            }

            DataGridViewRow ii_row = new DataGridViewRow();
            ii_row.CreateCells(dg_Reservas);
            ii_row.Cells[0].Value = id;
            ii_row.Cells[1].Value = funciones.Lee_Descr_Tipo(id, "tipo_habitacion");
            ii_row.Cells[2].Value = funciones.Lee_Costo_TipoHabitacion(id);
            dg_Reservas.Rows.Add(ii_row);
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

        private void Reserva_Load(object sender, EventArgs e)
        {


            if (aa_modo.ToUpper() == "A")
            {
                CB_Estado.SelectedIndex = 0;
                TReserva.Text = funciones.Prox_Codigo("Reservacion").ToString();
                DateTime fecha = DateTime.Today;
                DT_Fecha_Ini.Value = fecha;

                DT_Fecha_Fin.Value = fecha.AddDays(1);
                TimeSpan dias = DT_Fecha_Fin.Value - DT_Fecha_Ini.Value;
                LNoches.Text = dias.Days.ToString();
                TTAlojamiento.Enabled = true;

            }
            
            else
            {

                aa_EReserva = funciones.Lee_Reserva(aa_id.ToString());
                Pasa_Datos();


            }


        }

        bool Inserta_Datos()
        {
            Error = "";
            aa_EReserva = new Clases.EReserva();
            aa_EReserva.id_reservacion = TReserva.Text.ToString();
            aa_EReserva.id_cliente = TCliente.Text.ToString();
            aa_EReserva.id_t_aloj_reservacion = TTAlojamiento.Text.ToString();
            aa_EReserva.fecha_lleg_reservacion = DT_Fecha_Ini.Value.ToString("yyyy-MM-dd").Trim();

            aa_EReserva.fecha_sal_reservacion = DT_Fecha_Fin.Value.ToString("yyyy-MM-dd").Trim();
            aa_EReserva.Monto_apagar = LTotalN.Text.ToString();
            aa_EReserva.estado_reservacion = CB_Estado.SelectedItem.ToString().Trim().ToUpper().Substring(0, 1);

            List<Clases.EReserva_Detalle> aa_LEReserva_Detalle = new List<Clases.EReserva_Detalle>();
            Clases.EReserva_Detalle aa_EReserva_Detalle = new Clases.EReserva_Detalle();

            for (int ii = 0; ii < dg_Reservas.RowCount - 1; ii++)
            {
                aa_EReserva_Detalle = new Clases.EReserva_Detalle();

                aa_EReserva_Detalle.id_reservacion_det = TReserva.Text;
                aa_EReserva_Detalle.id_thab_reserv_det = dg_Reservas.Rows[ii].Cells[0].Value.ToString().Trim();
                aa_EReserva_Detalle.cant_reserv_det = int.Parse(dg_Reservas.Rows[ii].Cells[3].Value.ToString().Trim());
                aa_LEReserva_Detalle.Add(aa_EReserva_Detalle);
            }


            // INSERTA ENCABEZADO
            if (funciones.Inserta_Reserva(aa_EReserva, ref Error))
            {
                if (funciones.Inserta_Detalle_Reserva(aa_LEReserva_Detalle, ref Error))
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

        bool Valida_Datos()
        {
            errorProvider1.Clear();
            string Msj = "Este Campo No Puede Estar en Blanco";
            if (aa_modo.ToUpper() == "A")
            {

                if (TCliente.Text.ToString().Trim() == "")
                {
                    MessageBox.Show(Msj);
                    errorProvider1.SetError(TTAlojamiento, Msj);
                    return false;
                }
                if (TTAlojamiento.Text.ToString().Trim() == "")
                {
                    MessageBox.Show(Msj);
                    errorProvider1.SetError(TTAlojamiento, Msj);
                    return false;
                }


                if (dg_Reservas.RowCount <= 1)
                {
                    MessageBox.Show("Debe Reservar al menos 1 habitacion");
                    return false;
                }



            }
            return true;
        }
        void Pasa_Datos()
        {
            TReserva.Text = aa_EReserva.id_reservacion;
            TCliente.Text = aa_EReserva.id_cliente;
            TdescCliente.Text = funciones.Lee_Descr_Tercero(aa_EReserva.id_cliente,"CLIENTE");
            TTAlojamiento.Text = aa_EReserva.id_t_aloj_reservacion.ToString();
            TdescTAlojamiento.Text = funciones.Lee_Descr_Tipo(aa_EReserva.id_t_aloj_reservacion,"TIPO_alojamiento");
            DateTime fecha = DateTime.Parse(aa_EReserva.fecha_lleg_reservacion);
            DT_Fecha_Ini.Value = DateTime.Parse(fecha.ToString("dd/MM/yyyy"));
            fecha = DateTime.Parse(aa_EReserva.fecha_sal_reservacion);
            DT_Fecha_Fin.Value = DateTime.Parse(fecha.ToString("dd/MM/yyyy"));
            if (aa_EReserva.estado_reservacion.ToString().Trim().ToUpper() == "A")
            {
                CB_Estado.SelectedIndex = 0;
            }
            else
            {
                CB_Estado.SelectedIndex = 1;
            }
            foreach (var Det in aa_EReserva.LEDetalle)
            {

                DataGridViewRow ii_row = new DataGridViewRow();
                ii_row.CreateCells(dg_Reservas);
                ii_row.Cells[0].Value = Det.id_thab_reserv_det.ToString().Trim();
                ii_row.Cells[1].Value = funciones.Lee_Descr_Tipo(Det.id_thab_reserv_det.ToString(), "tipo_habitacion");
                ii_row.Cells[2].Value = funciones.Lee_Costo_TipoHabitacion(Det.id_thab_reserv_det.ToString());
                ii_row.Cells[3].Value = Det.cant_reserv_det.ToString().Trim();
                ii_row.Cells[4].Value = double.Parse(ii_row.Cells[2].Value.ToString()) * int.Parse(ii_row.Cells[3].Value.ToString());
                ii_row.Cells[5].Value = double.Parse(ii_row.Cells[4].Value.ToString()) * int.Parse(LNoches.Text.ToString());

                dg_Reservas.Rows.Add(ii_row);



             
            }
            double sumNo = 0;
            double sumT = 0;
            for (int i = 0; i < dg_Reservas.Rows.Count; ++i)
            {
                if (dg_Reservas.Rows[i].Cells[1].Value == null)
                { break; }
                double di = double.Parse(dg_Reservas.Rows[i].Cells[4].Value.ToString());
                double total = double.Parse(dg_Reservas.Rows[i].Cells[5].Value.ToString());
                sumNo += di;
                sumT += total;
            }
            LTotalN.Text = sumNo.ToString();
            LTotal.Text = sumT.ToString();


        }


        private void BSeguir_Click(object sender, EventArgs e)
        {
            if (Valida_Datos())
            {
                if (Inserta_Datos())
                {
                    MessageBox.Show("DATOS GUARDADOS, Reserva -->" + TReserva.Text.ToString());
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
                MessageBox.Show("No Pudo Grabar reserva-->" + Error);
            }




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

            dg_Reservas.Rows.Clear();
            TTAlojamiento.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE QUERER LIMPIAR LOS DATOS?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            dg_Reservas.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dg_Reservas.Rows.Count - 1; i++)
            {
                if (dg_Reservas.Rows[i].Cells[0].Selected || dg_Reservas.Rows[i].Cells[1].Selected)
                {
                    dg_Reservas.Rows.RemoveAt(i);

                }
            }
        }

        private void dg_Reserva_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && dg_Reservas.Rows[e.RowIndex].Cells[0] != null && (e.RowIndex < dg_Reservas.Rows.Count - 1))
            {
                if (dg_Reservas.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    for (int i = 0; i < dg_Reservas.Rows.Count - 1; i++)
                    {
                        if (i != e.RowIndex)
                        {
                            string n = dg_Reservas.Rows[e.RowIndex].Cells[0].Value.ToString();
                            if (dg_Reservas.Rows[i].Cells[0].Value.ToString().Trim() == n)
                            {
                                MessageBox.Show("Ya Existe Esta Caracteristicas para el THabitacion");
                                dg_Reservas.Rows.RemoveAt(e.RowIndex);
                                return;


                            }
                        }

                        string SelectedText = dg_Reservas.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string descr = funciones.Lee_Descr_Tipo(SelectedText, "tipo_habitacion").ToString().Trim();
                        string cost = funciones.Lee_Costo_TipoHabitacion(SelectedText);
                        if (descr == "")
                        {
                            MessageBox.Show("No Existe Esta Tipo Habitacion");
                            return;

                        }
                        dg_Reservas.Rows[e.RowIndex].Cells[0].Value = int.Parse(SelectedText);
                        dg_Reservas.Rows[e.RowIndex].Cells[1].Value = descr.ToUpper();
                        dg_Reservas.Rows[e.RowIndex].Cells[2].Value = double.Parse(cost);
                        dg_Reservas.Rows[e.RowIndex].Cells[3].Value = 1;
                        dg_Reservas.Rows[e.RowIndex].Cells[4].Value = double.Parse(cost)*1;
                        dg_Reservas.Rows[e.RowIndex].Cells[5].Value = double.Parse(dg_Reservas.Rows[e.RowIndex].Cells[4].Value.ToString()) * int.Parse(LNoches.Text.ToString()); ;
                    }

                }
                else
                {
                    dg_Reservas.Rows.RemoveAt(e.RowIndex);
                }

                double sumNo = 0;
                double sumT = 0;
                for (int i = 0; i < dg_Reservas.Rows.Count; ++i)
                {
                    if (dg_Reservas.Rows[i].Cells[1].Value == null)
                    { break; }
                    double di = double.Parse(dg_Reservas.Rows[i].Cells[4].Value.ToString());
                    double total = double.Parse(dg_Reservas.Rows[i].Cells[5].Value.ToString());
                    sumNo += di;
                    sumT += total;
                }
                LTotalN.Text = sumNo.ToString();
                LTotal.Text = sumT.ToString();

            }

            if (dg_Reservas.Columns[e.ColumnIndex].Name == "Cant")
            {
                dg_Reservas.Rows[e.RowIndex].Cells[4].Value = double.Parse(dg_Reservas.Rows[e.RowIndex].Cells[2].Value.ToString()) * double.Parse(dg_Reservas.Rows[e.RowIndex].Cells[3].Value.ToString());
                dg_Reservas.Rows[e.RowIndex].Cells[5].Value = double.Parse(dg_Reservas.Rows[e.RowIndex].Cells[4].Value.ToString()) * int.Parse(LNoches.Text.ToString());

                double sumNo = 0;
                double sumT= 0;
                for (int i = 0; i < dg_Reservas.Rows.Count; ++i)
                { if (dg_Reservas.Rows[i].Cells[1].Value==null)
                    { break; }
                    double di = double.Parse(dg_Reservas.Rows[i].Cells[4].Value.ToString());
                    double total = double.Parse(dg_Reservas.Rows[i].Cells[5].Value.ToString());
                    sumNo += di;
                    sumT += total;
                }
                LTotalN.Text = sumNo.ToString();
                LTotal.Text = sumT.ToString();
            }
           
           


        }

            private void BTAlojamiento_Click(object sender, EventArgs e)
            {
            Mant_C_TipoAlojamiento CP = new Mant_C_TipoAlojamiento("e");
            CP.ShowDialog();
            string id = CP.Id.ToString().Trim();
            if (id.Trim() != "0")
            {
                TTAlojamiento.Text = id;
                TdescTAlojamiento.Text = funciones.Lee_Descr_TipoAlojamiento(id);


            }
           
        }

            private void TTAlojamiento_Leave(object sender, EventArgs e)
            {
                if (TTAlojamiento.Text.ToString().Trim() != "")
                {
                    string descr = funciones.Lee_Descr_Tipo(TTAlojamiento.Text, "Tipo_alojamiento");
                TTAlojamiento.Text = descr;
                }

            }

            private void BLimpiar_Click(object sender, EventArgs e)
            {
                Limpia_Datos();
            }

        private void BCliente_Click(object sender, EventArgs e)
        {

            Mant_C_Cliente CP = new Mant_C_Cliente("e");
            CP.ShowDialog();
            string id = CP.Id.ToString().Trim();
            if (id.Trim() != "0")
            {
                TCliente.Text = id;
                TdescCliente.Text = funciones.Lee_Descr_Tercero(id, "cliente");
               

            }
        }

        private void DT_Fecha_Ini_ValueChanged(object sender, EventArgs e)
        {
            if (aa_modo == "A") {
                if (DateTime.Today > DT_Fecha_Ini.Value)
                {
                    MessageBox.Show("La fecha salida no puede ser menor a la de hoy");
                    return;
                }
            }
             
            TimeSpan dias = DT_Fecha_Fin.Value - DT_Fecha_Ini.Value;
            if(dias.Days<0)
            {
                MessageBox.Show("La fecha salida no puede ser menor a la fecha Entrada");
                return;
            }
            LNoches.Text = dias.Days.ToString();
            
            if (dg_Reservas.Rows[0].Cells[0].Value != null) { 
                double sumT = 0;
                for (int i = 0; i < dg_Reservas.Rows.Count-1; ++i)
                {
                    dg_Reservas.Rows[i].Cells[5].Value = double.Parse(dg_Reservas.Rows[i].Cells[4].Value.ToString()) * dias.Days;

                    if (dg_Reservas.Rows[i].Cells[1].Value == null)
                    { break; }
                    double total = double.Parse(dg_Reservas.Rows[i].Cells[5].Value.ToString());
                    sumT += total;
                }
                LTotal.Text = sumT.ToString();
            }
           
        }

        private void DT_Fecha_Fin_ValueChanged(object sender, EventArgs e)
        {
            if (aa_modo == "A")
            {

                if (DateTime.Today > DT_Fecha_Fin.Value)
                {
                    MessageBox.Show("La fecha salida no puede ser menor a la de hoy");
                    return;
                }
            }
            
            TimeSpan dias = DT_Fecha_Fin.Value - DT_Fecha_Ini.Value;
            if (dias.Days < 0)
            {
                MessageBox.Show("La fecha salida no puede ser menor a la fecha Entrada");
                return;
            }
            LNoches.Text = dias.Days.ToString();
            if (dg_Reservas.Rows[0].Cells[0].Value != null)
            {
                double sumT = 0;
                for (int i = 0; i < dg_Reservas.Rows.Count-1; ++i)
                {
                    int noches = dias.Days;
                    string celdas = (dg_Reservas.Rows[i].Cells[4].Value.ToString());

                    dg_Reservas.Rows[i].Cells[5].Value = double.Parse(celdas) * noches;

                    if (dg_Reservas.Rows[i].Cells[1].Value == null)
                    { break; }
                    double total = double.Parse(dg_Reservas.Rows[i].Cells[5].Value.ToString());
                    sumT += total;
                }
                LTotal.Text = sumT.ToString();
            }
        }
    }
    }
