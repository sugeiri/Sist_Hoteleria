﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistHoteleria
{
    public partial class Mant_C_Cama : Form
    {
        public string Id = "";
        public string aa_Prov = "";
        string aa_Modo = "";
        string sql = "";
        public Mant_C_Cama(string ii_modo)
        {
            InitializeComponent();
            CB_Filtro.Items.Add(" ");
            CB_Filtro.Items.Add("Codigo");
            CB_Filtro.Items.Add("Descripcion");
            CB_Filtro.Items.Add("Capacidad");
            aa_Modo = ii_modo;
        }

        private void TFiltro_TextChanged(object sender, EventArgs e)
        {
            int fila = 0;
            if (!string.IsNullOrWhiteSpace(TFiltro.Text))
            {

                foreach (DataGridViewRow dr in DG_Datos.Rows)
                {
                    fila = CB_Filtro.SelectedIndex;
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
            else
            {
                foreach (DataGridViewRow dr in DG_Datos.Rows)
                {
                    dr.Visible = true;

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

            if (aa_Modo.ToUpper() == "E")
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

            if (aa_Modo.ToUpper() == "E")
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
            Clases.ECama ii_Cama = funciones.Lee_Cama(Id);
            Mant_Cama form = new Mant_Cama("m", ii_Cama);
            if (form.ShowDialog() == DialogResult.OK)
                Lee_Datos();

        }
        private void Mant_C_Cama_Load(object sender, EventArgs e)
        {
            Lee_Datos();
        }
        void Lee_Datos()
        {
            DG_Datos.Rows.Clear();
            string Error = "";
            
            sql = " Select * from cama " +
                 " where  Estado_cama = 'A' ";

            DataSet DS = Conexion.EjecutaSQL(sql, ref Error);
            int Count = DS.Tables[0].Rows.Count;
            if (Count > 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(DG_Datos);
                    ii_row.Cells[0].Value = DS.Tables[0].Rows[i]["id_Cama"].ToString().Trim();
                    ii_row.Cells[1].Value = DS.Tables[0].Rows[i]["descr_Cama"].ToString().Trim();
                    ii_row.Cells[2].Value = DS.Tables[0].Rows[i]["Capacidad_cama"].ToString().Trim();
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
            Mant_Cama form = new Mant_Cama("a");
            form.ShowDialog();
            Lee_Datos();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lee_Datos();
        }

        private void BImprimir_Click(object sender, EventArgs e)
        {
            Imprime_Datos();
        }
        void Imprime_Datos()
        {
            Form1.Imprime(sql, "RP_LCama", false);
        }

    }
}
