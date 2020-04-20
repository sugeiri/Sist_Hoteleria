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
    public partial class Mant_Mantenimiento : Form
    {
        string aa_modo = "a";
        string aa_id = "";
        string Error = "";
        Clases.EHabitacion aa_Habitacion = new Clases.EHabitacion();
        Clases.EMantenimiento aa_EMantenimiento = new Clases.EMantenimiento();
        public Mant_Mantenimiento(string ii_modo, string ii_id)
        {
            InitializeComponent();
            aa_modo = ii_modo;
            aa_id = ii_id;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                //LEE Caracteristicas PARA ENCADENAR
                tipob form = new tipob("e", "tipo_mantenimiento", "Tipo Mantenimiento");
                form.ShowDialog();
                string id_T = form.Id.Trim();
                if (!string.IsNullOrWhiteSpace(id_T.Trim()))
                {
                    Agrega_Fila(id_T);
                }
            }
            else
            {
                if (e.ColumnIndex == 2)
                {
                    //LEE Caracteristicas PARA ENCADENAR
                    Mant_C_Empleado form = new Mant_C_Empleado("", "e");
                    form.ShowDialog();
                    string id_T = form.Id.Trim();
                    if (!string.IsNullOrWhiteSpace(id_T.Trim()))
                    {
                        Agrega_Empleado(id_T, e.RowIndex);
                    }
                }
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
            ii_row.Cells[1].Value = funciones.Lee_Descr_Tipo(id, "tipo_mantenimiento");
            if (aa_modo.Trim() == "a" && TEmpleado.Text.ToString().Trim() != "")
            {
                ii_row.Cells[2].Value = TEmpleado.Text;
                ii_row.Cells[3].Value = Tnombre.Text.ToString();
            }
            ii_row.Cells[4].Value = "";
            dg_Caracteristicas.Rows.Add(ii_row);
        }
        void Agrega_Empleado(string id, int index)
        {
            dg_Caracteristicas.Rows[index].Cells[2].Value = id;
            dg_Caracteristicas.Rows[index].Cells[3].Value = funciones.Lee_Descr_Tercero(funciones.Lee_Empleado(id).id_tercero_empleado, "tercero");
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                //LEE Caracteristicas PARA ENCADENAR
                tipob form = new tipob("e", "tipo_mantenimiento", "Tipo Mantenimiento");
                form.ShowDialog();
                string id_T = form.Id.Trim();
                if (!string.IsNullOrWhiteSpace(id_T.Trim()))
                {
                    Agrega_Fila(id_T);
                }
            }
            else
            {
                if (e.ColumnIndex == 2)
                {
                    //LEE Caracteristicas PARA ENCADENAR
                    Mant_C_Empleado form = new Mant_C_Empleado("", "e");
                    form.ShowDialog();
                    string id_T = form.Id.Trim();
                    if (!string.IsNullOrWhiteSpace(id_T.Trim()))
                    {
                        Agrega_Empleado(id_T, e.RowIndex);
                    }
                }
            }


        }

        private void Mant_Mantenimiento_Load(object sender, EventArgs e)
        {
            CB_Estado.Items.Add("Pendiente");
            CB_Estado.Items.Add("Finalizado");
            CB_Estado.Items.Add("Cancelado");
            CB_Estado.SelectedIndex = 0;

            if (aa_modo.ToUpper() == "A")
            {
                THabitacion.Enabled = true;
                TFechaC.Visible = false;
                label2.Visible = false;
            }
            else
            {

                TFechaC.Visible = true;
                label2.Visible = true;
                Pasa_Datos_XCodigo(int.Parse(aa_id));

                if (aa_modo.ToUpper() == "D")
                {
                    Inactiva_Pantalla();
                }

            }


        }
        void Inactiva_Pantalla()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        item.Enabled = false;

                    }
                    if (item is Button)
                    {
                        item.Enabled = false;

                    }

                }
                catch { }
            }
            dg_Caracteristicas.ReadOnly = true;
            CB_Estado.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

        }

        bool Inserta_Datos()
        {
            Error = "";
            aa_EMantenimiento.id_hab_mantenimiento = THabitacion.Text.ToString();
            aa_EMantenimiento.estado_mantenimiento = CB_Estado.SelectedItem.ToString().Substring(0, 1);
            Clases.EDetMantenimiento LEDetalle = new Clases.EDetMantenimiento();

            Clases.EDetMantenimiento EDet = new Clases.EDetMantenimiento();
            aa_EMantenimiento.LEDetalle = new List<Clases.EDetMantenimiento>();
            for (int ii = 0; ii < dg_Caracteristicas.RowCount - 1; ii++)
            {
                LEDetalle = new Clases.EDetMantenimiento();
                LEDetalle.id_t_mant_det = dg_Caracteristicas.Rows[ii].Cells[0].Value.ToString().Trim();
                LEDetalle.id_empleado_det = dg_Caracteristicas.Rows[ii].Cells[2].Value.ToString().Trim();
                if (dg_Caracteristicas.Rows[ii].Cells[4].Value.ToString().Trim().ToUpper() == "X")
                    LEDetalle.estado_mantenimiento = "F";
                else
                    LEDetalle.estado_mantenimiento = "P";

                if (aa_EMantenimiento.estado_mantenimiento.Trim().ToLower() == "c")
                    LEDetalle.estado_mantenimiento = "C";
                if (aa_EMantenimiento.estado_mantenimiento.Trim().ToLower() == "f")
                    LEDetalle.estado_mantenimiento = "F";

                aa_EMantenimiento.LEDetalle.Add(LEDetalle);
            }

            if (funciones.Inserta_Mantenimiento(aa_EMantenimiento, ref Error, aa_modo))
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

                if (THabitacion.Text.ToString().Trim() == "")
                {
                    MessageBox.Show(Msj);
                    errorProvider1.SetError(THabitacion, Msj);
                    return false;
                }


                if (dg_Caracteristicas.RowCount <= 1)
                {
                    MessageBox.Show("Debe Indicar Al Menos 1 Mantenimiento a realizar");
                    return false;
                }



            }
            if (TEmpleado.Text == "")
            {
                for (int i = 0; i < dg_Caracteristicas.RowCount - 1; i++)
                {
                    if (dg_Caracteristicas.Rows[i].Cells[2].Value == null)
                    {

                        MessageBox.Show("Debe Indicar Empleado que realizara la accion, Linea-->" + i);
                        return false;
                    }
                    else
                    {
                        if (dg_Caracteristicas.Rows[i].Cells[2].Value.ToString().Trim() == "")
                        {
                            MessageBox.Show("Debe Indicar Empleado que realizara la accion, Linea-->" + i);
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        void Pasa_Datos()
        {
            THabitacion.Text = aa_Habitacion.id_habitacion.ToString();
            TdescHabitacion.Text = aa_Habitacion.descr_habitacion.ToString().ToUpper();
            aa_EMantenimiento = new Clases.EMantenimiento();
            aa_EMantenimiento = funciones.Lee_Mantenimiento(aa_Habitacion.id_habitacion);

            if (aa_EMantenimiento != null)
            {
                TFechaC.Text = DateTime.Parse(aa_EMantenimiento.fecha_cre_mantenimiento).ToString("dd/MM/yyyy");
                TEmpleado.ReadOnly = true;
                dg_Caracteristicas.Rows.Clear();
                label2.Visible = true;
                TFechaC.Visible = true;
                foreach (var Mant in aa_EMantenimiento.LEDetalle)
                {

                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(dg_Caracteristicas);
                    ii_row.Cells[0].Value = Mant.id_t_mant_det.ToString().Trim();
                    ii_row.Cells[1].Value = funciones.Lee_Descr_Tipo(Mant.id_t_mant_det.ToString(), "tipo_mantenimiento");
                    ii_row.Cells[2].Value = Mant.id_empleado_det.ToString().Trim();

                    ii_row.Cells[3].Value = funciones.Lee_Descr_Tercero(funciones.Lee_Empleado(Mant.id_empleado_det.ToString()).id_tercero_empleado, "tercero");
                    ii_row.Cells[4].Value = Mant.estado_mantenimiento;
                    dg_Caracteristicas.Rows.Add(ii_row);
                }
            }

        }
        void Pasa_Datos_XCodigo(int id)
        {
            aa_EMantenimiento = new Clases.EMantenimiento();
            aa_EMantenimiento = funciones.Lee_Mantenimiento_XCod(id);

            if (aa_EMantenimiento != null)
            {
                THabitacion.Text = aa_EMantenimiento.id_hab_mantenimiento;
                TdescHabitacion.Text = funciones.Lee_Descr_Tipo(aa_EMantenimiento.id_hab_mantenimiento, "habitacion").ToString().ToUpper();

                TFechaC.Text = DateTime.Parse(aa_EMantenimiento.fecha_cre_mantenimiento).ToString("dd/MM/yyyy");
                TEmpleado.ReadOnly = true;
                dg_Caracteristicas.Rows.Clear();
                label2.Visible = true;
                TFechaC.Visible = true;
                switch(aa_EMantenimiento.estado_mantenimiento.ToUpper().Trim())
                {
                    case "P":
                        CB_Estado.SelectedIndex = 0;
                        break;
                    case "F":
                        CB_Estado.SelectedIndex = 1;
                        break;
                    case "C":
                        CB_Estado.SelectedIndex = 2;
                        break;
                }
                foreach (var Mant in aa_EMantenimiento.LEDetalle)
                {

                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(dg_Caracteristicas);
                    ii_row.Cells[0].Value = Mant.id_t_mant_det.ToString().Trim();
                    ii_row.Cells[1].Value = funciones.Lee_Descr_Tipo(Mant.id_t_mant_det.ToString(), "tipo_mantenimiento");
                    ii_row.Cells[2].Value = Mant.id_empleado_det.ToString().Trim();

                    ii_row.Cells[3].Value = funciones.Lee_Descr_Tercero(funciones.Lee_Empleado(Mant.id_empleado_det.ToString()).id_tercero_empleado, "tercero");
                    ii_row.Cells[4].Value = Mant.estado_mantenimiento;
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
                    MessageBox.Show("DATOS GUARDADOS");
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
                MessageBox.Show("No Pudo Grabar Datos-->" + Error);
            }




        }

        void Limpia_Datos()
        {
            aa_Habitacion = new Clases.EHabitacion();
            aa_EMantenimiento = new Clases.EMantenimiento();
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
            TFechaC.Text = "";
            CB_Estado.SelectedIndex = 0;
            dg_Caracteristicas.Rows.Clear();
            THabitacion.Enabled = true;
            TEmpleado.ReadOnly = false;
            TFechaC.Visible = false;
            label2.Visible = false;
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
                                MessageBox.Show("Ya Existe Este Mantenimiento para la Habitacion");
                                dg_Caracteristicas.Rows.RemoveAt(e.RowIndex);
                                return;


                            }
                        }

                        string SelectedText = dg_Caracteristicas.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string descr = funciones.Lee_Descr_Tipo(SelectedText, "tipo_mantenimiento").ToString().Trim();
                        if (descr == "")
                        {
                            MessageBox.Show("No Existe Este Mantenimiento");
                            return;

                        }
                        dg_Caracteristicas.Rows[e.RowIndex].Cells[0].Value = int.Parse(SelectedText);
                        dg_Caracteristicas.Rows[e.RowIndex].Cells[1].Value = descr.ToUpper();
                        if (TEmpleado.Text.Trim() != "" && dg_Caracteristicas.Rows[e.RowIndex].Cells[2].Value.ToString().Trim() == "")
                        {
                            dg_Caracteristicas.Rows[e.RowIndex].Cells[2].Value = TEmpleado.Text.Trim();
                            dg_Caracteristicas.Rows[e.RowIndex].Cells[3].Value = Tnombre.Text.Trim();

                        }
                    }
                }
                else
                {
                    dg_Caracteristicas.Rows.RemoveAt(e.RowIndex);
                }

            }
            else
            {
                if (e.ColumnIndex == 2 && dg_Caracteristicas.Rows[e.RowIndex].Cells[2] != null && (e.RowIndex < dg_Caracteristicas.Rows.Count - 1))
                {
                    if (dg_Caracteristicas.Rows[e.RowIndex].Cells[2].Value != null)
                    {
                        for (int i = 0; i < dg_Caracteristicas.Rows.Count - 1; i++)
                        {
                            string SelectedText = dg_Caracteristicas.Rows[e.RowIndex].Cells[2].Value.ToString();
                            if (funciones.Lee_Empleado(SelectedText) == null)
                            {
                                MessageBox.Show("No Existe Este Empleado");
                                return;

                            }
                            string descr = funciones.Lee_Descr_Tercero(funciones.Lee_Empleado(SelectedText).id_tercero_empleado, "tercero");
                            if (descr == "")
                            {
                                MessageBox.Show("No Existe Este Empleado");
                                return;

                            }

                            dg_Caracteristicas.Rows[e.RowIndex].Cells[3].Value = descr;



                        }
                    }
                    else
                    {
                        dg_Caracteristicas.Rows.RemoveAt(e.RowIndex);
                    }

                }

            }

        }

        private void BHabitacion_Click(object sender, EventArgs e)
        {
            Mant_C_Habitacion CP = new Mant_C_Habitacion("e");
            CP.ShowDialog();
            string id = CP.Id.ToString().Trim();
            if (id.Trim() != "0")
            {
                string descr = funciones.Lee_Descr_Tipo(id, "habitacion");
                if (descr.Trim() != "")
                {
                    THabitacion.Text = id;
                    TdescHabitacion.Text = descr;
                    Clases.EMantenimiento int_med_Esp = funciones.Lee_Mantenimiento(id);
                    if (int_med_Esp != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Esta Habitacion Tiene Mantenimientos en Proceso, Desea Modificar?", "Alerta", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            THabitacion.Text = "";
                            return;

                        }
                        aa_modo = "m";
                        THabitacion.Enabled = true;
                        aa_Habitacion.id_habitacion = int_med_Esp.id_hab_mantenimiento;
                        Pasa_Datos();
                    }
                }
                else
                {
                    MessageBox.Show("No Existe esta Habitacion en la Base de Datos");
                    return;
                }

            }
        }

        private void THabitacion_Leave(object sender, EventArgs e)
        {
            if (THabitacion.Text.ToString().Trim() != "")
            {
                string descr = funciones.Lee_Descr_Tipo(THabitacion.Text, "habitacion");
                if (descr.Trim() != "")
                {
                    TdescHabitacion.Text = descr;
                    Clases.EMantenimiento int_med_Esp = funciones.Lee_Mantenimiento(THabitacion.Text);
                    if (int_med_Esp != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Esta Habitacion Tiene Mantenimientos en Proceso, Desea Modificar?", "Alerta", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            THabitacion.Text = "";
                            return;

                        }
                        aa_modo = "m";
                        THabitacion.Enabled = true;
                        aa_Habitacion.id_habitacion = int_med_Esp.id_hab_mantenimiento;
                        Pasa_Datos();
                    }
                }
                else
                {
                    MessageBox.Show("No Existe esta Habitacion en la Base de Datos");
                    return;
                }
            }

        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            Limpia_Datos();
        }

        private void BEmpleado_Click(object sender, EventArgs e)
        {
            Mant_C_Empleado CP = new Mant_C_Empleado("", "e");
            CP.ShowDialog();
            string id = CP.Id.ToString().Trim();
            if (id.Trim() != "")
            {
                string descr = funciones.Lee_Descr_Tipo(id, "empleado");
                if (descr.Trim() != "")
                {
                    TEmpleado.Text = id;
                    Tnombre.Text = descr;

                }
                else
                {
                    MessageBox.Show("No Existe este Empleado en la Base de Datos");
                    return;
                }

            }
        }

        private void TEmpleado_Leave(object sender, EventArgs e)
        {
            if (TEmpleado.Text.ToString().Trim() != "")
            {
                string descr = funciones.Lee_Descr_Tipo(TEmpleado.Text.ToString().Trim(), "empleado");
                if (descr.Trim() != "")
                {
                    Tnombre.Text = descr;

                }
                else
                {
                    MessageBox.Show("No Existe este Empleado en la Base de Datos");
                    return;
                }


            }
        }
    }
}
