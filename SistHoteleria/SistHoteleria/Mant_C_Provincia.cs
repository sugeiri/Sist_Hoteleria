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
    public partial class Mant_C_Provincia : Form
    {
        public string Id = "";
        string aa_Pais = "";
        public Mant_C_Provincia(string ii_Pais)
        {
            InitializeComponent();
            CB_Filtro.Items.Add(" ");
            CB_Filtro.Items.Add("Codigo");
            CB_Filtro.Items.Add("Descripcion");
            CB_Filtro.Items.Add("Pais");
            aa_Pais = ii_Pais;

        }

        private void TFiltro_TextChanged(object sender, EventArgs e)
        {
            int fila = 0;
            if (CB_Filtro.SelectedIndex >= 0)
            {
                if (!string.IsNullOrWhiteSpace(TFiltro.Text))
                {

                    foreach (DataGridViewRow dr in DG_Datos.Rows)
                    {
                        fila = CB_Filtro.SelectedIndex;
                        if (fila == 0)
                        {
                            MessageBox.Show("Debe Seleccionar Un Filtro");

                        }
                        else
                        {
                            if (dr.Cells[fila - 1].Value != null)
                            {
                                if ((dr.Cells[fila - 1].Value.ToString().ToUpper()).IndexOf(TFiltro.Text.ToUpper()) == 0)
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
                else
                {
                    foreach (DataGridViewRow dr in DG_Datos.Rows)
                    {
                        dr.Visible = true;

                    }
                }
            }
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

        private void Mant_C_Provincia_Load(object sender, EventArgs e)
        {
            Lee_Datos();
        }
        void Lee_Datos()
        {
            DG_Datos.Rows.Clear();
            string Error = "";
            string sql = "";
            if (aa_Pais.ToString().Trim()!="")
            {
                sql = " Select id_provincia, descr_provincia,id_pais_provincia, descr_pais from Provincia, PAIS " +
                     " where  Estado_Provincia = 'A' and id_pais_provincia ='" + aa_Pais + "'" +
                     " and id_pais =id_pais_provincia";
            }
            else
            {
                sql = " Select id_provincia, descr_provincia,id_pais_provincia, descr_pais from Provincia, PAIS " +
                     " where  Estado_Provincia = 'A' and id_pais =id_pais_provincia";

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
                    ii_row.Cells[0].Value = DS.Tables[0].Rows[i]["id_Provincia"].ToString().Trim();
                    ii_row.Cells[1].Value = DS.Tables[0].Rows[i]["descr_provincia"].ToString().Trim();
                    ii_row.Cells[2].Value = DS.Tables[0].Rows[i]["descr_pais"].ToString().Trim();
                    DG_Datos.Rows.Add(ii_row);
                }
            }
            else
            {
                MessageBox.Show("NO ENCONTRO DATO DE LA BUSQUEDA");
            }
            
        }

        private void BCrear_Click(object sender, EventArgs e)
        {
            Mant_Provincia form = new Mant_Provincia("a");
            form.ShowDialog();
            Lee_Datos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lee_Datos();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE QUERER SALIR?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;

            }
            this.Dispose();
        }
    }
}
