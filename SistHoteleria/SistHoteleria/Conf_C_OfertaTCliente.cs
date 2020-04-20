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
    public partial class Conf_C_OfertaTCliente : Form
    {
      
        public string Id = "";
        string aa_modo = "C";
        string sql = "";

        string aa_Ultima_Descr_filtro = "";
        Object fila_buscada = new object();
        public Conf_C_OfertaTCliente(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;
        }
        public Conf_C_OfertaTCliente(string ii_sql, string ii_modo)
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
            Conf_OfertaTCliente mm = new Conf_OfertaTCliente("m", Id);
            mm.ShowDialog();
            Lee_Datos();
            }
            else
            {
                MessageBox.Show("No Tiene Acceso");
            }


        }

        private void Conf_C_OfertaTCliente_Load(object sender, EventArgs e)
        {
            
            Lee_Datos();
        }
        void Lee_Datos()
        {

             DG_Datos.Rows.Clear();
            string Error = "";
            string sql = "select id_oferta_det02,descr_oferta,id_t_cliente_det02,DESCR_TC,descuento_det02 " +
                                " from oferta_det_02,Oferta,TIPO_CLIENTE  " +
                                " where id_oferta_det02=id_oferta and " +
                                "   id_t_cliente_det02=ID_T_CLIENTE_TC  ";
            DataSet DS = Conexion.EjecutaSQL(sql, ref Error);
            int Count = DS.Tables.Count;
            if (Count > 0)
            {
                Count = DS.Tables[0].Rows.Count;
                for (int i = 0; i < Count; i++)
                {
                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(DG_Datos);
                    ii_row.Cells[0].Value = DS.Tables[0].Rows[i]["id_t_cliente_det02"].ToString().Trim();
                    ii_row.Cells[1].Value = DS.Tables[0].Rows[i]["DESCR_TC"].ToString().Trim();
                    ii_row.Cells[2].Value = DS.Tables[0].Rows[i]["id_oferta_det02"].ToString().Trim();
                    ii_row.Cells[3].Value = DS.Tables[0].Rows[i]["descr_oferta"].ToString().Trim();
                    ii_row.Cells[4].Value = DS.Tables[0].Rows[i]["descuento_det02"].ToString().Trim();


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

            
            if (!string.IsNullOrWhiteSpace(TOferta.Text.ToString().Trim()) && fila_buscada != TOferta)
                TConsultorio_TextChanged(ob, e);

            if (!string.IsNullOrWhiteSpace(TDescOfert.Text.ToString().Trim()) && fila_buscada != TDescOfert)
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
                Filtra(0, id, false);

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
            TOferta.Text = "";
            TDescOfert.Text = "";
            foreach (DataGridViewRow dr in DG_Datos.Rows)
            {
                dr.Visible = true;

            }
        }
        

        private void TConsultorio_TextChanged(object sender, EventArgs e)
        {
            string nombre = TOferta.Text.ToString().Trim().ToUpper();
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
            string nombre = TDescOfert.Text.ToString().Trim().ToUpper();
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
            Conf_OfertaTCliente form = new Conf_OfertaTCliente("a", "");
            form.ShowDialog();
            Lee_Datos();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Lee_Datos();
        }

        private void BConsultorio_Click(object sender, EventArgs e)
        {
            Mant_C_Oferta form = new Mant_C_Oferta("","e");
            if(form.ShowDialog()==DialogResult.OK)
            {
                string id = form.Id;
                if(id.ToString().Trim()!=""&& id.ToString().Trim() != "0")
                {
                    TOferta.Text = id.ToString();
                    TDescOfert.Text = funciones.Lee_Descr_Tipo(id.ToString(), "oferta");
                }
            }
        }
    }
}
