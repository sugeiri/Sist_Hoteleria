using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistHoteleria
{
    public partial class Conf_CaractTHabitacion : Form
    {
        string aa_modo = "a";
        string aa_id = "";
        string Error = "";
        Clases.ETHabitacion aa_THabitacion = new Clases.ETHabitacion();
        List<Clases.Ethab_caracteristica> aa_LECaracteristicas = new List<Clases.Ethab_caracteristica>();
        public Conf_CaractTHabitacion(string ii_modo, string ii_id)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_id = ii_id;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //LEE Caracteristicas PARA ENCADENAR
            tipob form = new tipob("e", "caracteristica", "Caracteristicas");
            form.ShowDialog();
            string id_T = form.Id.Trim();
            if (!string.IsNullOrWhiteSpace(id_T.Trim()))
            {
                Agrega_Fila(id_T);
            }

        }
        void Agrega_Fila(string id)
        {

            for (int i = 0; i < dg_Caracteristicas.Rows.Count - 1; i++)
            {
                if (dg_Caracteristicas.Rows[i].Cells[0].Value.ToString().Trim() == id.ToString().Trim())
                {
                    MessageBox.Show("Ya Existe Esta Caracteristicas para el Tipo de Habitacion");
                    return;
                }
            }

            DataGridViewRow ii_row = new DataGridViewRow();
            ii_row.CreateCells(dg_Caracteristicas);
            ii_row.Cells[0].Value = id;
            ii_row.Cells[1].Value = funciones.Lee_Descr_Tipo(id, "caracteristica");
            dg_Caracteristicas.Rows.Add(ii_row);
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //LEE Caracteristicas PARA ENCADENAR
            tipob form = new tipob("e", "caracteristica", "Caracteristicas");
            form.ShowDialog();
            string id_T = form.Id.Trim();
            if (!string.IsNullOrWhiteSpace(id_T.Trim()))
            {
                Agrega_Fila(id_T);
            }


        }

        private void Conf_CaractTHabitacion_Load(object sender, EventArgs e)
        {


            if (aa_modo.ToUpper() == "A")
            {
                TTHabitacion.Enabled = true;

            }
            else
            {
                aa_THabitacion = funciones.Lee_TipoHabitacion(aa_id.ToString());
                Pasa_Datos();


            }


        }

        bool Inserta_Datos()
        {
            Error = "";
            List<Clases.Ethab_caracteristica> aa_LECaracteristicasTHab = new List<Clases.Ethab_caracteristica>();
            Clases.Ethab_caracteristica aa_ECaracteristicasTHab = new Clases.Ethab_caracteristica();
            for (int ii = 0; ii < dg_Caracteristicas.RowCount - 1; ii++)
            {
                aa_ECaracteristicasTHab = new Clases.Ethab_caracteristica();

                aa_ECaracteristicasTHab.id_t_hab_thcar = TTHabitacion.Text;
                aa_ECaracteristicasTHab.id_caracteristica_thcar = dg_Caracteristicas.Rows[ii].Cells[0].Value.ToString().Trim();

                aa_LECaracteristicasTHab.Add(aa_ECaracteristicasTHab);
            }

            if (funciones.Inserta_Caracteristicas_THabitacion(aa_LECaracteristicasTHab, ref Error))
            {
                return true;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(Error.Trim()))
                {
                    MessageBox.Show(Error.ToString().Trim());
                }
            }
            return false;
        }

        bool Valida_Datos()
        {
            errorProvider1.Clear();
            string Msj = "Este Campo No Puede Estar en Blanco";
            if (aa_modo.ToUpper() == "A")
            {

                if (TTHabitacion.Text.ToString().Trim() == "")
                {
                    MessageBox.Show(Msj);
                    errorProvider1.SetError(TTHabitacion, Msj);
                    return false;
                }


                if (dg_Caracteristicas.RowCount <= 1)
                {
                    MessageBox.Show("Debe Indicar Al menos Una Caracteristicas");
                    return false;
                }



            }
            return true;
        }
        void Pasa_Datos()
        {
            TTHabitacion.Text = aa_THabitacion.id_t_hab.ToString();
            TdescTHabitacion.Text = aa_THabitacion.descr_t_hab.ToString().ToUpper();
            aa_LECaracteristicas = new List<Clases.Ethab_caracteristica>();
            aa_LECaracteristicas = funciones.Lee_Caracteristicas_THabitacion(aa_THabitacion.id_t_hab);

            if (aa_LECaracteristicas != null)
            {

                dg_Caracteristicas.Rows.Clear();
                foreach (var Caracteristicas in aa_LECaracteristicas)
                {

                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(dg_Caracteristicas);
                    ii_row.Cells[0].Value = Caracteristicas.id_caracteristica_thcar.ToString().Trim();
                    ii_row.Cells[1].Value = funciones.Lee_Descr_Tipo(Caracteristicas.id_caracteristica_thcar.ToString(), "caracteristica");
                    dg_Caracteristicas.Rows.Add(ii_row);
                }
            }

        }


        private void BSeguir_Click(object sender, EventArgs e)
        {
            if (Valida_Datos())
            {
                if (Inserta_Datos())
                {
                    MessageBox.Show("DATOS GUARDADOS, THabitacion -->" + aa_THabitacion.id_t_hab);
                    if (aa_modo.ToUpper() != "A")
                    {
                        this.DialogResult = DialogResult.OK;
                        return;

                    }
                    Limpia_Datos();

                }

            }
            else
            {
                MessageBox.Show("No Pudo Grabar THabitacion-->" + Error);
            }




        }

        void Limpia_Datos()
        {
            aa_THabitacion = new Clases.ETHabitacion();
            aa_id = "";
            aa_modo = "a";
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }

                }
                catch { }
            }

            dg_Caracteristicas.Rows.Clear();
            TTHabitacion.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE QUERER LIMPIAR LOS DATOS?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            dg_Caracteristicas.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dg_Caracteristicas.Rows.Count - 1; i++)
            {
                if (dg_Caracteristicas.Rows[i].Cells[0].Selected || dg_Caracteristicas.Rows[i].Cells[1].Selected)
                {
                    dg_Caracteristicas.Rows.RemoveAt(i);

                }
            }
        }

        private void dg_Caracteristicas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && dg_Caracteristicas.Rows[e.RowIndex].Cells[0] != null && (e.RowIndex < dg_Caracteristicas.Rows.Count - 1))
            {
                if (dg_Caracteristicas.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    for (int i = 0; i < dg_Caracteristicas.Rows.Count - 1; i++)
                    {
                        if (i != e.RowIndex)
                        {
                            string n = dg_Caracteristicas.Rows[e.RowIndex].Cells[0].Value.ToString();
                            if (dg_Caracteristicas.Rows[i].Cells[0].Value.ToString().Trim() == n)
                            {
                                MessageBox.Show("Ya Existe Esta Caracteristicas para el THabitacion");
                                dg_Caracteristicas.Rows.RemoveAt(e.RowIndex);
                                return;


                            }
                        }

                        string SelectedText = dg_Caracteristicas.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string descr = funciones.Lee_Descr_Tipo(SelectedText, "caracteristica").ToString().Trim();
                        if (descr == "")
                        {
                            MessageBox.Show("No Existe Esta Caracteristica");
                            return;

                        }
                        dg_Caracteristicas.Rows[e.RowIndex].Cells[0].Value = int.Parse(SelectedText);
                        dg_Caracteristicas.Rows[e.RowIndex].Cells[1].Value = descr.ToUpper();
                    }
                }
                else
                {
                    dg_Caracteristicas.Rows.RemoveAt(e.RowIndex);
                }

                }

            }

            private void BTHabitacion_Click(object sender, EventArgs e)
            {
                Mant_C_TipoHabitacion CP = new Mant_C_TipoHabitacion("e");
                CP.ShowDialog();
                string id = CP.Id.ToString().Trim();
                if (id.Trim() != "0")
                {
                    string descr = funciones.Lee_Descr_Tipo(id, "tipo_habitacion");
                    if (descr.Trim() != "")
                    {
                        TTHabitacion.Text = id;
                    TdescTHabitacion.Text = descr;
                    List<Clases.Ethab_caracteristica> int_med_Esp = funciones.Lee_Caracteristicas_THabitacion(id);
                        if (int_med_Esp != null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Ya Existe Asignacion de Caracteristicas para este Tipo de Habitacion , Desea Modificar?", "Alerta", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.No)
                            {
                                TTHabitacion.Text = "";
                                return;

                            }
                            aa_modo = "m";
                            TTHabitacion.Enabled = true;
                            aa_THabitacion.id_t_hab = int_med_Esp[0].id_t_hab_thcar;
                            Pasa_Datos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Existe este Tipo de Habitacion en la Base de Datos");
                        return;
                    }

                }
            }

            private void TTHabitacion_Leave(object sender, EventArgs e)
            {
                if (TTHabitacion.Text.ToString().Trim() != "")
                {
                    string descr = funciones.Lee_Descr_Tipo(TTHabitacion.Text, "tipo_habitacion");
                    if (descr.Trim() != "")
                    {
                    TdescTHabitacion.Text = descr;
                    List<Clases.Ethab_caracteristica> int_med_Esp = funciones.Lee_Caracteristicas_THabitacion(TTHabitacion.Text);
                        if (int_med_Esp != null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Ya Existe Asignacion de Caracteristicas para este Tipo de Habitacion , Desea Modificar?", "Alerta", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.No)
                            {
                                TTHabitacion.Text = "";
                                return;

                            }
                            aa_modo = "m";
                            TTHabitacion.Enabled = true;
                            aa_THabitacion.id_t_hab = int_med_Esp[0].id_t_hab_thcar;
                            Pasa_Datos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Existe este Tipo de Habitacion en la Base de Datos");
                        return;
                    }
                }

            }

            private void BLimpiar_Click(object sender, EventArgs e)
            {
                Limpia_Datos();
            }
        }
    }
