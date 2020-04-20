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
    public partial class Consul_Alojamiento : Form
    {
        string aa_modo = "a";
        public string aa_id = "";
        string Error = "";
        Clases.EReserva aa_EReserva = new Clases.EReserva();
        List<Clases.EReserva_Detalle> aa_LEReserva_Detalle = new List<Clases.EReserva_Detalle>();
        public Consul_Alojamiento(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;
        }


       
       
        private void Reserva_Load(object sender, EventArgs e)
        {
           

                DateTime fecha = DateTime.Today;
                
        }

        string Valida_Datos()
        {
            String where = "";
            if (TAlojamiento.Text.ToString().Trim() != "")
            {
                where += " id_alojamiento='" + TAlojamiento.Text.ToString().Trim() + "'";
            }
            if (TReserva.Text.ToString().Trim() != "")
            {
                where += " and id_reserv_alojamiento='" + TReserva.Text.ToString().Trim() + "'";
            }

            if (TIng_por.Text.ToString().Trim() != "")
            {
                where += " and ing_por_alojamiento='" + TIng_por.Text.ToString().Trim() + "'";
            }
            if (TSal_por.Text.ToString().Trim() != "")
            {
                where += " and sal_por_alojamiento='" + TSal_por.Text.ToString().Trim() + "'";
            }

            if (TFecha_Ini.Text.ToString().Trim() != "")
            {
                where += " and fecha_i_alojamiento='" + TFecha_Ini.Text.ToString().Trim() + "'";
            }

            if (TFecha_Fin.Text.ToString().Trim() != "" )
            {
                where += " and fecha_s_alojamiento='" + TFecha_Fin.Text.ToString().Trim() + "'";
            }
            if (TStatus.Text.ToString().Trim() != "")
            {
                where += " and estado_alojamiento='" + TStatus.Text.ToString().Trim() + "'";
            }
            return where;
        }
      


        private void BSeguir_Click(object sender, EventArgs e)
        {

            string where = Valida_Datos();
            if (where != "")
            {
                where = "where" + where;
            }
            where = where.Replace("where and", "where ");
            string sql = "select * from alojamiento ";
            sql += where;
            
            C_Alojamiento CP = new C_Alojamiento(where,aa_modo.ToUpper());
            CP.ShowDialog();
            if (aa_modo.ToUpper() == "E")
            {
                aa_id = CP.Id;
                this.Close();
            }



        }

        void Limpia_Datos()
        {
          //  aa_THabitacion = new Clases.ETHabitacion();
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

           
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE QUERER LIMPIAR LOS DATOS?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
           
        }

     


            private void BLimpiar_Click(object sender, EventArgs e)
            {
                Limpia_Datos();
            }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TFecha_Ini_TextChanged(object sender, EventArgs e)
        {

        }

        private void BReserva_Click(object sender, EventArgs e)
        {

            C_Reserva form = new C_Reserva("e");
            form.ShowDialog();
            if (form.aa_id.ToString().Trim() != "")
            {
                TAlojamiento.Text = form.aa_id.ToString().Trim();

            }
        }
    }
    }
