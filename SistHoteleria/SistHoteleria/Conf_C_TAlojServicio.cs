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
    public partial class Conf_C_TAlojServicio : Form
    {
      
        public string Id = "";
        string aa_modo = "C";
        string sql = "";

        string aa_Ultima_Descr_filtro = "";
        Object fila_buscada = new object();
        public Conf_C_TAlojServicio(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;
        }
        public Conf_C_TAlojServicio(string ii_sql, string ii_modo)
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
            Id = DG_Datos.Rows[i].Cells[2].Value.ToString().Trim();
            Conf_TAlojServicio mm = new Conf_TAlojServicio("m", Id);
            mm.ShowDialog();
            Lee_Datos();
            }
            else
            {
                MessageBox.Show("No Tiene Acceso");
            }


        }

        private void Conf_C_TAlojServicio_Load(object sender, EventArgs e)
        {
            
            Lee_Datos();
        }
        void Lee_Datos()
        {

             DG_Datos.Rows.Clear();
            string Error = "";
            string sql = "select id_servicio_tas,descr_servicio,id_t_alojamiento_tas,descr_t_alojamiento " +
                                " from talojamiento_servicio,tipo_alojamiento,servicio  " +
                                " where id_t_alojamiento_tas=id_t_alojamiento and " +
                                "   id_servicio_tas=id_servicio  ";
            DataSet DS = Conexion.EjecutaSQL(sql, ref Error);
            int Count = DS.Tables.Count;
            if (Count > 0)
            {
                Count = DS.Tables[0].Rows.Count;
                for (int i = 0; i < Count; i++)
                {
                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(DG_Datos);
                    ii_row.Cells[0].Value = DS.Tables[0].Rows[i]["id_servicio_tas"].ToString().Trim();
                    ii_row.Cells[1].Value = DS.Tables[0].Rows[i]["descr_servicio"].ToString().Trim();
                    ii_row.Cells[2].Value = DS.Tables[0].Rows[i]["id_t_alojamiento_tas"].ToString().Trim();
                    ii_row.Cells[3].Value = DS.Tables[0].Rows[i]["descr_t_alojamiento"].ToString().Trim();
                   
                    
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
            if (!string.IsNullOrWhiteSpace(TCodigo.Text.ToString().Trim()) && fila_buscada != TCodigo)
                TCodigo_TextChanged(ob, e);

            if (!string.IsNullOrWhiteSpace(TDescr.Text.ToString().Trim()) && fila_buscada != TDescr)
                TNombreTercero_TextChanged(ob, e);

            
            if (!string.IsNullOrWhiteSpace(TAseg.Text.ToString().Trim()) && fila_buscada != TAseg)
                TConsultorio_TextChanged(ob, e);

            if (!string.IsNullOrWhiteSpace(TDescAseg.Text.ToString().Trim()) && fila_buscada != TDescAseg)
                TDescConsultorio_TextChanged(ob, e);


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

        private void TCodigo_TextChanged(object sender, EventArgs e)
        {

            string id = TCodigo.Text.ToString().Trim();
            if (!string.IsNullOrWhiteSpace(id))
            {
                fila_buscada = sender;
                Filtra(0, id, true);

            }
            else
            {
                Muestra_Filas();
            }
        }

        private void TNombreTercero_TextChanged(object sender, EventArgs e)
        {
            bool muestra = false;
            string nombre = TDescr.Text.ToString().Trim().ToUpper();
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                fila_buscada = sender;
                if (nombre.Length < aa_Ultima_Descr_filtro.Length)
                {
                    muestra = true;
                }
                aa_Ultima_Descr_filtro = nombre;
                if (muestra)
                    Muestra_Filas();

                Filtra(1, nombre, false);

            }
            else
            {
                Muestra_Filas();
            }
        }
        
        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TCodigo.Text = "";
            TDescr.Text = "";
            TAseg.Text = "";
            TDescAseg.Text = "";
            foreach (DataGridViewRow dr in DG_Datos.Rows)
            {
                dr.Visible = true;

            }
        }
        

        private void TConsultorio_TextChanged(object sender, EventArgs e)
        {
            string nombre = TAseg.Text.ToString().Trim().ToUpper();
            bool muestra = false;
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                fila_buscada = sender;
                if (nombre.Length < aa_Ultima_Descr_filtro.Length)
                {
                    muestra = true;
                }
                aa_Ultima_Descr_filtro = nombre;
                if (muestra)
                    Muestra_Filas();

                Filtra(2, nombre, false);

            }
            else
            {
                Muestra_Filas();
            }
        }

        private void TDescConsultorio_TextChanged(object sender, EventArgs e)
        {
            string nombre = TDescAseg.Text.ToString().Trim().ToUpper();
            bool muestra = false;
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                fila_buscada = sender;
                if (nombre.Length < aa_Ultima_Descr_filtro.Length)
                {
                    muestra = true;
                }
                aa_Ultima_Descr_filtro = nombre;
                if (muestra)
                    Muestra_Filas();

                Filtra(3, nombre, false);

            }
            else
            {
                Muestra_Filas();
            }
        }

        private void BCrear_Click(object sender, EventArgs e)
        {
            Conf_TAlojServicio form = new Conf_TAlojServicio("a", "");
            form.ShowDialog();
            Lee_Datos();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Lee_Datos();
        }

        private void BConsultorio_Click(object sender, EventArgs e)
        {
            Mant_C_TipoAlojamiento form = new Mant_C_TipoAlojamiento("e");
            if(form.ShowDialog()==DialogResult.OK)
            {
                string id = form.Id;
                if(id.ToString().Trim()!=""&& id.ToString().Trim() != "0")
                {
                    TAseg.Text = id.ToString();
                    TDescAseg.Text = funciones.Lee_Descr_Tipo(id.ToString(), "tipo_alojamiento");
                }
            }
        }
    }
}
