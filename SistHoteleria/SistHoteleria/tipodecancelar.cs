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
    public partial class tipodecancelar : Form
    {
        string aa_tabla = "";
        string aa_titulo = "";
        string aa_modo = "c";
        public string Id = "";
        string aa_query = "";
        string aa_Campo_id = "";
        bool codigo_numerico = true;
        public tipodecancelar(string ii_modo, string ii_tabla, string ii_titulo)
        {
            InitializeComponent();

            aa_tabla = ii_tabla;
            aa_titulo = ii_titulo;
            aa_modo = ii_modo;
            LTitulo.Text = "CONSULTA DE " + aa_titulo.ToUpper();
        }
        private void tipodecancelar_Load(object sender, EventArgs e)
        {
            Lee_Datos();
        }
        void Lee_Datos()
        {
            CB_ESTADO.Items.Clear();
            DG_DATOS.Rows.Clear();
            string Error = "";
            string sql = "";
            if (aa_query != "")
            {
                sql = aa_query;
            }
            else
            {
                sql = "SELECT * FROM " + aa_tabla;
            }
            DataSet DS = new DataSet();
            DS = Conexion.EjecutaSQL(sql, ref Error);
            //int Count = DS.Tables.Count;
            int Count = DS.Tables[0].Rows.Count;
            if (Count > 0)
            {
                aa_Campo_id = DS.Tables[0].Columns[0].ColumnName.ToString();
                Count = DS.Tables[0].Rows.Count;
                for (int i = 0; i < Count; i++)
                {
                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(DG_DATOS);
                    ii_row.Cells[0].Value = DS.Tables[0].Rows[i][0].ToString().Trim();
                    ii_row.Cells[1].Value = DS.Tables[0].Rows[i][1].ToString().Trim();
                    ii_row.Cells[2].Value = DS.Tables[0].Rows[i][2].ToString().Trim();
                    DG_DATOS.Rows.Add(ii_row);
                }
                CB_ESTADO.Items.Add("TODO");
                foreach (var i in funciones.Lista_Estados(aa_tabla, DS.Tables[0].Columns[2].ColumnName.ToString()))
                {
                    CB_ESTADO.Items.Add(i.ToString());
                }

                CB_ESTADO.SelectedIndex = 0;
                codigo_numerico = funciones.TipoPK(aa_tabla);


            }
            else
            {
                MessageBox.Show("NO ENCONTRO DATO DE LA BUSQUEDA");
            }
        }
        int Fila_Actual()
        {
            return DG_DATOS.CurrentRow.Index;
        }
        private void DG_DATOS_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (aa_modo.ToUpper() == "E")
                {
                    int i = Fila_Actual();
                    Id = DG_DATOS.Rows[i].Cells[0].Value.ToString().Trim();
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
        void Modificar()
        {
            int i = Fila_Actual();
            Id = DG_DATOS.Rows[i].Cells[0].Value.ToString().Trim();
            Clases.ETipo ii_Tipo = funciones.Lee_Tipo(Id, aa_tabla);
            tipo form = new tipo("m", aa_tabla, "MODIFICA " + aa_titulo, ii_Tipo);
            if (form.ShowDialog() == DialogResult.OK)
                Lee_Datos();

        }
        private void DG_DATOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (aa_modo.ToUpper() == "E")
            {
                int i = Fila_Actual();
                Id = DG_DATOS.Rows[i].Cells[0].Value.ToString().Trim();
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                Modificar();
            }
            return;


        }

        private void DG_DATOS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (aa_modo.ToUpper() == "E")
            {
                int i = Fila_Actual();
                Id = DG_DATOS.Rows[i].Cells[0].Value.ToString().Trim();
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                Modificar();
            }
            return;



        }

        private void CB_ESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CB_ESTADO.SelectedItem.ToString().Trim()) && CB_ESTADO.SelectedIndex != 0)
            {
                string estado = CB_ESTADO.SelectedItem.ToString().Trim().Substring(0, 1).Trim();
                Muestra_Filas_SoloEstado();
                Filtra(2, estado, false);

            }
            else
            {
                Muestra_Filas();
            }
        }

        private void tid_TextChanged(object sender, EventArgs e)
        {
            string id = tid.Text.ToString().Trim();
            if (!string.IsNullOrWhiteSpace(id))
            {
                Filtra(0, id, codigo_numerico);
            }
            else
            {
                Muestra_Filas();
            }
        }

        
        void Muestra_Filas()
        {

            foreach (DataGridViewRow dr in DG_DATOS.Rows)
            {
                dr.Visible = true;

            }

            EventArgs e = new EventArgs();
            Object ob = new Object();
            if (!string.IsNullOrWhiteSpace(tid.Text.ToString().Trim()))
                tid_TextChanged(ob, e);
            if (CB_ESTADO.SelectedIndex > 0)
                CB_ESTADO_SelectedIndexChanged(ob, e);
            


        }

        void Muestra_Filas_SoloEstado()
        {

            foreach (DataGridViewRow dr in DG_DATOS.Rows)
            {
                dr.Visible = true;

            }

            EventArgs e = new EventArgs();
            Object ob = new Object();
            if (!string.IsNullOrWhiteSpace(tid.Text.ToString().Trim()))
                tid_TextChanged(ob, e);
            


        }
        void Filtra(int fila, string dato, bool codigo)
        {
            bool tiene_filtro = false;
            if (DG_DATOS.Rows.Count > DG_DATOS.Rows.GetRowCount(DataGridViewElementStates.Visible))
            {
                tiene_filtro = true;
            }

            foreach (DataGridViewRow dr in DG_DATOS.Rows)
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

        private void button2_Click(object sender, EventArgs e)
        {
            tid.Text = "";
            
            CB_ESTADO.SelectedIndex = 0;
        }

        private void BCrear_Click(object sender, EventArgs e)
        {
            tipo form = new tipo("a", aa_tabla, "CREA " + aa_titulo);
            if (form.ShowDialog() == DialogResult.OK)
                Lee_Datos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lee_Datos();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
