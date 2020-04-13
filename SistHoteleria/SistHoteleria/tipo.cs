
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
    public partial class tipo : Form
    {
        string aa_modo = "";
        string aa_tabla = "";
        string aa_titulo = "";
        string aa_id = "";
        Clases.ETipo aa_ETipo = new Clases.ETipo();
        bool aa_Codigo_numerico = true;
        public tipo(string ii_modo, string ii_tabla, string ii_titulo)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_tabla = ii_tabla;
            aa_titulo = ii_titulo;
            LTitulo.Text = aa_titulo.ToUpper();
            
        }
        public tipo(string ii_modo, string ii_tabla, string ii_titulo,Clases.ETipo ii_Etipo)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_tabla = ii_tabla;
            aa_titulo = ii_titulo;
            LTitulo.Text = aa_titulo.ToUpper();
            aa_ETipo = ii_Etipo;
        }
        private void tipo_Load(object sender, EventArgs e)
        {
            CB_ESTADO.Items.Add("A");
            CB_ESTADO.Items.Add("I");
            CB_ESTADO.SelectedIndex = 0;
            if (aa_modo.ToString().Trim().ToLower() != "a")
            {
                
                Pasa_Datos();

            }else
            {
                aa_Codigo_numerico = funciones.TipoPK(aa_tabla);
            }
        }
        void Pasa_Datos()
        {
            aa_Codigo_numerico = aa_ETipo.Tipo_PK_int;
            tid.Text = aa_ETipo.id;
            tDESCR.Text = aa_ETipo.descripcion.ToString().Trim().ToUpper();
            if (aa_ETipo.estado.ToUpper() != "A")
            {
                CB_ESTADO.SelectedIndex = 1;
            }
        }
        private void BLimpiar_Click(object sender, EventArgs e)
        {
            string sql = "";
            string Error = "";
            errorProvider1.Clear();
            string mensaje = "ESTE CAMPO NO PUEDE ESTAR EN BLANCO";
            if (string.IsNullOrWhiteSpace(tid.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(tid, mensaje);
                tid.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tDESCR.Text.ToString().Trim()))
            {
                MessageBox.Show(mensaje);
                errorProvider1.SetError(tDESCR, mensaje);
                tDESCR.Focus();
            }
            if (aa_modo.ToUpper().Trim() == "A")
            {
                if (CB_ESTADO.SelectedIndex != 0)
                {
                    MessageBox.Show("NO PUEDE REGISTRAR CON ESTADO DIFERENTE DE ACTIVO");
                    return;

                } 
            }
                sql = "EXEC ACT" + aa_tabla + " '" + tid.Text.ToString() 
                                                   + "','" + tDESCR.Text.ToString().Trim() 
                                                   + "','" + CB_ESTADO.SelectedItem.ToString().Trim() +"',"
                                                   + "'"+ aa_modo.ToUpper()+"'";

            //}
            //else
            //{
            //    DataSet ds = Conexion.EjecutaSQL("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + aa_tabla + "' ORDER BY ORDINAL_POSITION", ref Error);
            //    int Count = ds.Tables.Count;
            //    if (Count > 0)
            //    {
            //        string campo_01 = ds.Tables[0].Rows[0]["COLUMN_NAME"].ToString();
            //        string campo_02 = ds.Tables[0].Rows[1]["COLUMN_NAME"].ToString();
            //        string campo_03 = ds.Tables[0].Rows[2]["COLUMN_NAME"].ToString();
            //        sql = "UPDATE " + aa_tabla + " SET " +
            //                campo_02 + "='" + tDESCR.Text.ToUpper() + "'," +
            //                campo_03 + "='" + CB_ESTADO.SelectedItem.ToString().ToUpper() + "'" +
            //                " WHERE " + campo_01 + "='" + tid.Text.ToString().Trim() + "'";

            //    }
            //}
            if (!Conexion.Inserta_Datos(sql, ref Error))
            {
                MessageBox.Show(Error);
                return;
            }
            if(aa_modo.Trim().ToLower()=="a")
            {
                Limpia();

            }
            else
            {
                this.DialogResult = DialogResult.OK;

            }
            
        }
        void Limpia()
        {
            tid.Text = "";
            tDESCR.Text = "";
            CB_ESTADO.SelectedIndex = 0;
        }

        private void tid_Leave(object sender, EventArgs e)
        {
            if (tid.Text.ToString().Trim() != "")
            {
                if (tid.Text.ToString().Trim() == "*")
                {

                    tid.Text = funciones.Prox_Codigo(aa_tabla).ToString("######");
                }
                else {
                    aa_ETipo = funciones.Lee_Tipo(tid.Text.ToString().Trim(), aa_tabla);
                    if (aa_ETipo != null)
                    {
                        aa_modo = "m";
                        tDESCR.Text = aa_ETipo.descripcion;
                        if (aa_ETipo.estado.ToUpper() == "A")
                            CB_ESTADO.SelectedIndex = 0;
                        else
                            CB_ESTADO.SelectedIndex = 1;
                    }
                    else
                    {
                        Valida_codigo();
                    }
                }
            }
        }
        bool Valida_codigo()
        {
                if (aa_Codigo_numerico)
                {
                int id = 0;
                if (!int.TryParse(tid.Text.ToString(),out id))
                {
                    MessageBox.Show("SOLO VALORES NUMERICOS");
                    return false;
                }
               
                
            }
            return true;

        }
        private void tid_TextChanged(object sender, EventArgs e)
        {
            if (tid.Text.ToString().IndexOf("*")<0 && tid.Text.ToString().Trim()!="")
                        Valida_codigo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpia();
            aa_modo = "a";
        }

        private void button1_Click(object sender, EventArgs e)
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
