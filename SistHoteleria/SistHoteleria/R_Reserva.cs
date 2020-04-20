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
    public partial class R_Reserva : Form
    {
      
        public string Id = "";
        string aa_modo = "C";
        string sql = "";

        string aa_Ultima_Descr_filtro = "";
        Object fila_buscada = new object();
        public R_Reserva(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;
        }
        public R_Reserva(string ii_sql, string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            sql = ii_sql;

        }

        int Fila_Actual()
        {
            return DG_Datos.CurrentRow.Index;
        }
       
        private void DG_Datos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (aa_modo.ToUpper() == "E")
                {
                    int i = Fila_Actual();
                    Id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                else
                {
                    Modificar();
                }
                return;

            }
        }

        private void DG_Datos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (aa_modo.ToUpper() == "E")
            {
                int i = Fila_Actual();
                Id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                Modificar();
            }
            return;
        }

        private void DG_Datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (aa_modo.ToUpper() == "E")
            {
                int i = Fila_Actual();
                Id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                Modificar();
            }
            return;
        }
        void Modificar()
        {
            if (Clases.Nivel_Acceso.ToUpper() == "A" || Clases.Nivel_Acceso.ToUpper() == "E")
            {
                int i = Fila_Actual();
            Id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
            Reserva mm = new Reserva("m", Id);
            mm.ShowDialog();
            Lee_Datos();
            }
            else
            {
                MessageBox.Show("No Tiene Acceso");
            }


        }

        private void C_Reserva_Load(object sender, EventArgs e)
        {
            //TCodigo.Text = funciones.Prox_Codigo("reservacion").ToString();
            Lee_Datos();
        }
        void Lee_Datos()
        {

             DG_Datos.Rows.Clear();
            string Error = "";
           
            DataSet DS = Conexion.EjecutaSQL(sql, ref Error);
            int Count = DS.Tables.Count;
            if (Count > 0)
            {
                DateTime fecha;
                Count = DS.Tables[0].Rows.Count;
                for (int i = 0; i < Count; i++)
                {
                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(DG_Datos);
                    ii_row.Cells[0].Value = DS.Tables[0].Rows[i]["id_reservacion"].ToString().Trim();
                    ii_row.Cells[2].Value = funciones.Lee_Descr_Tercero( DS.Tables[0].Rows[i]["id_cliente"].ToString().Trim(),"Cliente");
                    ii_row.Cells[4].Value = funciones.Lee_Descr_Tipo(DS.Tables[0].Rows[i]["id_t_aloj_reservacion"].ToString().Trim(), "TIPO_ALOJAMIENTO");
                   fecha = DateTime.Parse(DS.Tables[0].Rows[i]["fecha_lleg_reservacion"].ToString().Trim());
                    ii_row.Cells[5].Value = fecha.ToString("dd/MM/yyyy");
                    fecha = DateTime.Parse(DS.Tables[0].Rows[i]["fecha_sal_reservacion"].ToString().Trim());
                    ii_row.Cells[6].Value = fecha.ToString("dd/MM/yyyy");
                    ii_row.Cells[7].Value = DS.Tables[0].Rows[i]["Monto_apagar"].ToString().Trim();
                    ii_row.Cells[8].Value = DS.Tables[0].Rows[i]["estado_reservacion"].ToString().Trim();

                    DG_Datos.Rows.Add(ii_row);
                }
            }
            else
            {
                MessageBox.Show("NO ENCONTRO DATO DE LA BUSQUEDA");
            }

        }

       
      
        void Muestra_Filas()
        {

            foreach (DataGridViewRow dr in DG_Datos.Rows)
            {
                dr.Visible = true;

            }

            EventArgs e = new EventArgs();
            Object ob = new Object();
           
          
           

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
                        if ((cod.ToLower()).IndexOf(dato.ToLower()) >= 0)
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

      

    
        
        private void BLimpiar_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow dr in DG_Datos.Rows)
            {
                dr.Visible = true;

            }
        }
        


        private void BCrear_Click(object sender, EventArgs e)
        {
            Reserva form = new Reserva("a", "");
            form.ShowDialog();
            Lee_Datos();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            C_Reserva form = new C_Reserva("C");
            form.ShowDialog();
            Lee_Datos();
        }

    

      
    }
}
