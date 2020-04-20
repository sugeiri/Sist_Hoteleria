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
    public partial class C_Mantenimiento : Form
    {
        public string Id = "";
        string modo = "c";
        string sql = "";
        string Fecha_Ini_Generada = "1900-01-01";
        string Fecha_Fin_Generada = "1900-01-01";
        string Ultima_Condicion = "";
        public C_Mantenimiento()
        {
            InitializeComponent();
        }

        public C_Mantenimiento(string ii_sql, string ii_modo)
        {
            InitializeComponent();
            modo = ii_modo;
            sql = ii_sql;
        }
        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TCodigo.Text = "";
            TFecha.Text = "";
            CB_Estado.SelectedIndex = 0;
            foreach (DataGridViewRow dr in DG_Datos.Rows)
            {
                dr.Visible = true;

            }
        }

        private void DG_UnidadP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int Fila_Actual()
        {
            return DG_Datos.CurrentRow.Index;
        }
        void Lee_Datos()
        {
            DG_Datos.Rows.Clear();
            string Error = "";
            if (modo.ToString().Trim().ToLower() != "e" || sql.ToString().Trim() == "")
            {
                string aa_Condicion = "";
                funciones.Genera_Condicion_Fecha_Para_Query(TFecha.Text, ref aa_Condicion, ref Fecha_Ini_Generada, ref Fecha_Fin_Generada);

                sql = " SELECT * " +
                     " FROM Mantenimiento WHERE fecha_cre_mantenimiento " + aa_Condicion;

                sql = sql + " order by id_mantenimiento,id_hab_mantenimiento;";
            }

            DataSet DS = Conexion.EjecutaSQL(sql, ref Error);
            int Count = DS.Tables.Count;
            if (Count > 0)
            {
                Count = DS.Tables[0].Rows.Count;

                for (int i = 0; i < Count; i++)
                {
                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(DG_Datos);
                    ii_row.Cells[0].Value = DS.Tables[0].Rows[i]["id_mantenimiento"].ToString().Trim();
                    ii_row.Cells[1].Value = DS.Tables[0].Rows[i]["id_hab_mantenimiento"].ToString().PadLeft(6, '0').Trim();
                    ii_row.Cells[2].Value = DS.Tables[0].Rows[i]["estado_mantenimiento"].ToString().Trim();
                    ii_row.Cells[3].Value = DateTime.Parse(DS.Tables[0].Rows[i]["fecha_cre_mantenimiento"].ToString()).ToString("dd/MM/yyyy").Trim();
                    ii_row.Cells[4].Value = DateTime.Parse(DS.Tables[0].Rows[i]["fecha_cre_mantenimiento"].ToString()).ToString("HH:mm:ss tt").Trim();

                    DG_Datos.Rows.Add(ii_row);
                }

            }
            else
            {
                MessageBox.Show("NO ENCONTRO DATO DE LA BUSQUEDA");
            }

        }
        void Muestra_Filas(bool Viene_De_Fecha)
        {

            foreach (DataGridViewRow dr in DG_Datos.Rows)
            {
                dr.Visible = true;

            }

            EventArgs e = new EventArgs();
            Object ob = new Object();
            if (!string.IsNullOrWhiteSpace(TCodigo.Text.ToString().Trim()))
                TCodigo_TextChanged(ob, e);
            if (!string.IsNullOrWhiteSpace(TFecha.Text.ToString().Trim()) && !Viene_De_Fecha)
                TFecha_TextChanged(ob, e);
            if (!string.IsNullOrWhiteSpace(THabitacion.Text.ToString().Trim()))
                THabitacion_TextChanged(ob, e);



        }
        void Filtra(int fila, string dato, bool codigo)
        {
            bool tiene_filtro = false;
            if (DG_Datos.Rows.Count > DG_Datos.Rows.GetRowCount(DataGridViewElementStates.Visible))
            {
                tiene_filtro = true;
            }
            foreach (DataGridViewRow dr in DG_Datos.Rows)
            {
                if (tiene_filtro && dr.Visible == false)
                {
                    continue;
                }
                else
                {


                    if (dr.Cells[fila].Value != null)
                    {
                        string cod = "";
                        if (codigo)
                            cod = int.Parse(dr.Cells[fila].Value.ToString().Trim()).ToString().Trim();
                        else
                            cod = dr.Cells[fila].Value.ToString().Trim();
                        if ((cod.ToLower()).IndexOf(dato.ToLower()) == 0)
                        {
                            dr.Visible = true;
                        }
                        else
                        {
                            dr.Visible = false;
                        }
                    }

                }

            }
        }

        private void TCodigo_TextChanged(object sender, EventArgs e)
        {
            int fila = 0;

            string id = TCodigo.Text.ToString().Trim();
            if (!string.IsNullOrWhiteSpace(id))
            {
                Filtra(fila, id, true);
            }
            else
            {
                Muestra_Filas(false);
            }

            string id_T = TCodigo.Text.ToString().Trim();
            if (!string.IsNullOrWhiteSpace(id_T.Trim()))
            {
                int valor = 0;
                if (int.TryParse(TCodigo.Text.ToString(), out valor))
                {
                    if (valor > 0)
                        Filtra(fila, valor.ToString(), true);
                }
                else
                {
                    MessageBox.Show("El Codigo Solo Debe Contener Numeros");
                    return;
                }
            }
            else
            {
                Muestra_Filas(false);
            }

        }


        private void C_Mantenimiento_Load(object sender, EventArgs e)
        {
            CB_Estado.SelectedIndex = 0;
            string Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            TFecha.Text = Fecha + " 00.00.00:" + Fecha + " 23.59.59";
            Lee_Datos();
        }

        private void BConsultar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            C_Mantenimiento mc = new C_Mantenimiento();
            mc.ShowDialog();
        }

        private void BImprimir_Click(object sender, EventArgs e)
        {
            Imprime_Datos("Rp_C_Mantenimiento");
        }
        void Imprime_Datos(string reporte)
        {
            Limpia_Temporal();
            Inserta_Temporal();
            //Reporte.Imprime("SELECT * FROM RP_ListaFacturas", reporte,true);


        }

        void Limpia_Temporal()
        {
            string sql = "";
            string Error = "";
            sql = "DELETE from RP_ListaFacturas  WHERE NUMERO_FACT_CC>0;";
            //if (!Funciones.Ejecuta_Delete(sql, ref Error))
            //    MessageBox.Show(Error);

        }
        void Inserta_Temporal()
        {
            string sql = "";
            string Error = "";
            for (int ii = 0; ii < DG_Datos.RowCount - 1; ii++)
            {
                int cod = Int16.Parse(DG_Datos.Rows[ii].Cells[1].Value.ToString());
                string fecha = DateTime.Parse(DG_Datos.Rows[ii].Cells[3].Value.ToString()).ToString("yyyy-MM-dd");
                string hora = DateTime.Parse(DG_Datos.Rows[ii].Cells[4].Value.ToString()).ToString("HH:mm:ss");
                DateTime dt = DateTime.Parse(fecha + " " + hora);
                decimal monto = decimal.Parse(DG_Datos.Rows[ii].Cells[5].Value.ToString());
                //bool Respuesta = Funciones.Inserta_Lista_Detalle_Factura(cod, dt, monto,0,0);
                //if (!Respuesta)
                //{
                //    sql = "DELETE FROM RP_ListaFacturas WHERE NUMERO_FACT_CC>0;";
                //    if (!Funciones.Ejecuta_Delete(sql, ref Error))
                //    {
                //        MessageBox.Show(Error);

                //    }
                //    MessageBox.Show(Error);
                //    return;

                //}
            }

        }
        private void TFecha_TextChanged(object sender, EventArgs e)
        {
            if (TFecha.Text.ToString().Trim() != "")
            {
                string text = TFecha.Text;
                string fecha_1 = "";
                string fecha_2 = "";
                int posicion = text.IndexOf(":");
                DateTime f;
                if (posicion >= 0)
                {
                    fecha_1 = text.Substring(0, posicion).Replace(".", ":");
                    fecha_2 = text.Substring(posicion + 1, text.Length - (fecha_1.Length + 1)).Replace(".", ":");
                    if (!string.IsNullOrWhiteSpace(fecha_2) && DateTime.TryParse(fecha_2.ToString(), out f))
                    {
                        fecha_2 = f.ToString("dd/MM/yyyy HH:mm:ss");// + " " + Hora_1;
                    }
                    else
                        return;
                }
                if (DateTime.TryParse(fecha_1.ToString(), out f))
                {
                    fecha_1 = f.ToString("dd/MM/yyyy HH:mm:ss");// + " " + Hora_1;
                }
                else
                    return;




            }
        }

        private void TFecha_Leave(object sender, EventArgs e)
        {

            if (TFecha.Text.ToString() != "")
            {
                Muestra_Filas(true);

                Genera_filtro(TFecha.Text, 3);

            }
            else
            {
                Muestra_Filas(true);

            }

        }
        void Filtra_Fecha(int fila, string condicion, string fecha_1, string fecha_2)
        {
            bool tiene_filtro = false;
            if (DG_Datos.Rows.Count > DG_Datos.Rows.GetRowCount(DataGridViewElementStates.Visible))
            {
                tiene_filtro = true;
            }
            foreach (DataGridViewRow dr in DG_Datos.Rows)
            {
                //if (tiene_filtro && dr.Visible == false)
                //{
                //    continue;
                //}
                //else
                //{

                if (dr.Cells[fila].Value != null)
                {
                    bool visible = false;
                    string cod = "";
                    cod = dr.Cells[3].Value.ToString().Trim() + " " + dr.Cells[4].Value.ToString().Trim();
                    string s_fecha = DateTime.Parse(cod).ToString("dd/MM/yyyy HH:mm:ss");
                    DateTime fecha = DateTime.Parse(s_fecha);
                    DateTime f1 = DateTime.Parse(fecha_1);
                    DateTime f2;


                    switch (condicion)
                    {
                        case ">":
                            if (fecha > f1)
                                visible = true;
                            else
                                visible = false;

                            break;
                        case "<":
                            if (fecha < f1)
                                visible = true;
                            else
                                visible = false;
                            break;
                        case ">=":
                            if (fecha >= f1)
                                visible = true;
                            else
                                visible = false;
                            break;
                        case "<=":
                            if (fecha <= f1)
                                visible = true;
                            else
                                visible = false;
                            break;
                        case "r":
                            f2 = DateTime.Parse(fecha_2);

                            if (fecha >= f1 && fecha <= f2)
                                visible = true;
                            else
                                visible = false;
                            break;
                        default:
                            //if (fecha == f1)
                            string s_f2 = DateTime.Parse(fecha_1).ToString("dd/MM/yyyy") + " 23:59:59";
                            f2 = DateTime.Parse(s_f2);
                            if (fecha >= f1 && fecha <= f2)
                                visible = true;
                            else
                                visible = false;
                            break;
                            //if (fecha >= f1)
                            //    visible = true;
                            //else
                            //    visible = false;
                            break;

                    }
                    if (visible)
                    {
                        dr.Visible = true;
                    }
                    else
                    {
                        dr.Visible = false;
                    }
                    //}
                }

            }
        }
        void Genera_filtro(string dato, int fila)
        {
            string ii_Condicion = "";
            string fecha_1 = "";
            string fecha_2 = "";
            bool Respuesta = funciones.Genera_Condicion_Fecha(dato, ref ii_Condicion, ref fecha_1, ref fecha_2);
            if (Respuesta)
            {
                fecha_1 = fecha_1.Replace(".", ":");
                fecha_2 = fecha_2.Replace(".", ":");
                DateTime f;
                if (DateTime.TryParse(fecha_1.ToString(), out f))
                {
                    fecha_1 = f.ToString("dd/MM/yyyy HH:mm:ss");// + " " + Hora_1;
                }
                else
                {
                    MessageBox.Show("Formato de fecha Incorrecto");
                    TFecha.Focus();
                    return;
                }

                if (fecha_2.Trim() != "1900-01-01")
                {
                    fecha_2 = Convert.ToDateTime(fecha_2).ToString("dd/MM/yyyy HH:mm:ss");// + " " + Hora_1;
                    ii_Condicion = "r";
                }

                Lee_Datos();
            }
        }
        string Busca_Estado()
        {
            switch (CB_Estado.SelectedIndex)
            {
                case 0:
                    return "";
                case 1:
                    return "P";
                case 2:
                    return "F";
                case 3:
                    return "C";
                default:
                    return "";
            }
            return "";
        }
        private void CB_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Muestra_Filas(false);
            int fila = 2;
            string Estado = Busca_Estado();
            if (!string.IsNullOrWhiteSpace(Estado))
            {

                Filtra(fila, Estado, false);

            }
            else
            {
                Muestra_Filas(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Fila_Actual();
            string id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
            Mant_Mantenimiento form = new Mant_Mantenimiento("d", id);
            form.ShowDialog();
        }

        private void DG_Datos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                int i = Fila_Actual();
                string id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
                Mant_Mantenimiento form = new Mant_Mantenimiento("m", id);
                form.ShowDialog();

                return;

            }
        }

        private void DG_Datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = Fila_Actual();
            string id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
            Mant_Mantenimiento form = new Mant_Mantenimiento("m", id);
            form.ShowDialog();
        }

        private void DG_Datos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = Fila_Actual();
            string id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
            Mant_Mantenimiento form = new Mant_Mantenimiento("m", id);
            form.ShowDialog();

        }
        private void DG_DATOS_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            decimal Suma = 0;
            if (e.ColumnIndex == 5 && DG_Datos.Rows[e.RowIndex].Cells[5].Value != null)
            {

                for (int ii = 0; ii < DG_Datos.RowCount - 1; ii++)
                {
                    if (DG_Datos.Rows[ii].Cells[5].Selected)
                    {
                        Suma = Suma + decimal.Parse(DG_Datos.Rows[ii].Cells[5].Value.ToString());
                    }

                }
                LSuma.Text = Suma.ToString("###,###,###.##");
            }
        }

        private void THabitacion_TextChanged(object sender, EventArgs e)
        {
            int fila = 1;

            string id = THabitacion.Text.ToString().Trim();
            if (!string.IsNullOrWhiteSpace(id))
            {
                Filtra(fila, id, false);
            }
            else
            {
                Muestra_Filas(false);
            }

            string id_T = THabitacion.Text.ToString().Trim();
            if (!string.IsNullOrWhiteSpace(id_T.Trim()))
            {
                Filtra(fila, id_T.ToString(), false);
            }
            else
            {
                Muestra_Filas(false);
            }
        }
    }
}
