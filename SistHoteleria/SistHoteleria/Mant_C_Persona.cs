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
    public partial class Mant_C_Persona : Form
    {
        public string Id = "";

        string aa_Ultima_Descr_filtro = "";
        public Mant_C_Persona()
        {
            InitializeComponent();
        }
        
        int Fila_Actual()
        {
            return DG_Datos.CurrentRow.Index;
        }
        private void DG_Datos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                int i = Fila_Actual();
                Id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                return;

            }
        }

        private void DG_Datos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = Fila_Actual();
            Id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            return;
        }

        private void DG_Datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = Fila_Actual();
            Id = DG_Datos.Rows[i].Cells[0].Value.ToString().Trim();
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            return;
        }

        private void Mant_C_Persona_Load(object sender, EventArgs e)
        {
            Lee_Datos();
        }
        void Lee_Datos()
        {
            DG_Datos.Rows.Clear();
            string Error = "";
            string sql = "Select * from Tercero";
            DataSet DS = Conexion.EjecutaSQL(sql, ref Error);
            int Count = DS.Tables.Count;
            if (Count > 0)
            {
                Count = DS.Tables[0].Rows.Count;
                for (int i = 0; i < Count; i++)
                {
                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(DG_Datos);
                    ii_row.Cells[0].Value = DS.Tables[0].Rows[i]["id_Tercero"].ToString().Trim();
                    ii_row.Cells[1].Value = DS.Tables[0].Rows[i]["Nombre_Tercero"].ToString().Trim();
                    ii_row.Cells[2].Value = DS.Tables[0].Rows[i]["Cedula_Tercero"].ToString().Trim();
                    ii_row.Cells[3].Value = DS.Tables[0].Rows[i]["Estado_Tercero"].ToString().Trim();
                    DG_Datos.Rows.Add(ii_row);
                }
                CB_ESTADO.Items.Clear();
                CB_ESTADO.Items.Add("TODO");
                foreach (var i in funciones.Lista_Estados("TERCERO", "Estado_Tercero"))
                {
                    CB_ESTADO.Items.Add(i.ToString());
                }

                CB_ESTADO.SelectedIndex = 0;
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
            if (CB_ESTADO.SelectedIndex > 0)
                CB_ESTADO_SelectedIndexChanged(ob, e);
           

        }

        void Muestra_Filas_SoloEstado()
        {

            foreach (DataGridViewRow dr in DG_Datos.Rows)
            {
                dr.Visible = true;

            }

            EventArgs e = new EventArgs();
            Object ob = new Object();
            //if (!string.IsNullOrWhiteSpace(tid.Text.ToString().Trim()))
            //    tid_TextChanged(ob, e);
            //if (!string.IsNullOrWhiteSpace(tDESCR.Text.ToString().Trim()))
            //    tDESCR_TextChanged(ob, e);


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
        private void CB_ESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CB_ESTADO.SelectedItem.ToString().Trim()) && CB_ESTADO.SelectedIndex != 0)
            {
                string estado = CB_ESTADO.SelectedItem.ToString().Trim().Substring(0, 1).Trim();
                Muestra_Filas_SoloEstado();
                Filtra(3, estado, false);

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
                Filtra(0, id, true);
            }
            else
            {
                Muestra_Filas();
            }
        }

        private void tDESCR_TextChanged(object sender, EventArgs e)
        {
            bool muestra = false;
            string nombre = tDESCR.Text.ToString().Trim().ToUpper();
            if (!string.IsNullOrWhiteSpace(nombre))
            {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool muestra = false;
            string nombre = textBox1.Text.ToString().Trim().ToUpper();
            if (!string.IsNullOrWhiteSpace(nombre))
            {
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

        private void button2_Click(object sender, EventArgs e)
        {
            tid.Text = "";
            tDESCR.Text = "";
            CB_ESTADO.SelectedIndex = 0;
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lee_Datos();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
