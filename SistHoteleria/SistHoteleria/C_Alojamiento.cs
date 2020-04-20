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
    public partial class C_Alojamiento : Form
    {

        public string Id = "";
        string modo = "c";
        string sql = "";
        string where = "";
       
        public C_Alojamiento()
        {
            InitializeComponent();

        }
        public C_Alojamiento(string ii_sql,string ii_modo)
        {
            InitializeComponent();
            modo = ii_modo;
            where = ii_sql;
        }
        public C_Alojamiento( string ii_modo)
        {
            InitializeComponent();
            modo = ii_modo;
        }
        int Fila_Actual()
        {
            return DG_Datos.CurrentRow.Index;
        }
        private void DG_Datos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (modo.ToString().Trim().ToLower() == "e")
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
            if (modo.ToString().Trim().ToLower() == "e")
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
            if (modo.ToString().Trim().ToLower() == "e")
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
            if (Clases.Nivel_Acceso.ToUpper() != "A" && Clases.Nivel_Acceso.ToUpper() != "E")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
            int i = Fila_Actual();
            Id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
            Alojamiento form = new Alojamiento("m", Id);
            if (form.ShowDialog() == DialogResult.OK)
                Lee_Datos();


        }

        private void C_Alojamiento_Load(object sender, EventArgs e)
        {

            Lee_Datos();
        }
        void Lee_Datos()
        {
          
            DG_Datos.Rows.Clear();
            string Error = "";
             if (modo.ToString().Trim().ToLower() != "e" || sql.ToString().Trim()=="")
            {
                sql = "SELECT * FROM alojamiento " + where ;
                
           
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
                    ii_row.Cells[0].Value = DS.Tables[0].Rows[i]["id_alojamiento"].ToString().Trim();
                    ii_row.Cells[1].Value = DS.Tables[0].Rows[i]["id_reserv_alojamiento"].ToString().Trim();
                    ii_row.Cells[2].Value = DS.Tables[0].Rows[i]["fecha_i_alojamiento"].ToString().Trim();
                    ii_row.Cells[3].Value = DS.Tables[0].Rows[i]["fecha_s_alojamiento"].ToString().Trim();
                    ii_row.Cells[4].Value = DS.Tables[0].Rows[i]["estado_alojamiento"].ToString().Trim();
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
            if(!string.IsNullOrWhiteSpace(TAlojamiento.Text.ToString().Trim()))
                TCodigo_TextChanged(ob, e);
            if (CB_Estado.SelectedIndex>0)
                CB_Estado_Servicio_SelectedIndexChanged(ob, e);
            if (!string.IsNullOrWhiteSpace(TReserva.Text.ToString().Trim()))
                TTipo_TextChanged(ob, e);
                


        }
        void Filtra(int fila,string dato,bool codigo)
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
                        if(codigo)
                            cod=int.Parse(dr.Cells[fila].Value.ToString().Trim()).ToString().Trim();
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

            string id = TAlojamiento.Text.ToString().Trim();
            if (!string.IsNullOrWhiteSpace(id))
            {
                Filtra(0, id,false);
            }
            else
            {
                Muestra_Filas();
            }
        }

        private void CB_Estado_Servicio_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(CB_Estado.SelectedItem.ToString().Trim()))
            {
                string estado = CB_Estado.SelectedItem.ToString().Trim().Substring(0, 1).Trim();
                Filtra(2, estado,false);

            }
            else
            {
                Muestra_Filas();
            }
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TAlojamiento.Text = "";
            TReserva.Text = "";
            CB_Estado.SelectedIndex = 0;
            foreach (DataGridViewRow dr in DG_Datos.Rows)
            {
                dr.Visible = true;

            }
        }



        private void TTipo_TextChanged(object sender, EventArgs e)
        {
            string nombre = TReserva.Text.ToString().Trim().ToUpper();
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                Filtra(3, nombre, false);

            }
            else
            {
                Muestra_Filas();
            }
        }

       

        private void BImprimir_Click(object sender, EventArgs e)
        {
            Form1.Imprime(sql, "RP_LCliente", false);
        }

        private void BReserva_Click(object sender, EventArgs e)
        {

        }
    }
}
