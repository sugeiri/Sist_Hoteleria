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
    public partial class C_Reserva : Form
    {
        string aa_modo = "a";
        string aa_id = "";
        string Error = "";
        Clases.EReserva aa_EReserva = new Clases.EReserva();
        List<Clases.EReserva_Detalle> aa_LEReserva_Detalle = new List<Clases.EReserva_Detalle>();
        public C_Reserva(string ii_modo)
        {
            InitializeComponent();
            aa_modo = ii_modo;
        }


       
       
        private void Reserva_Load(object sender, EventArgs e)
        {
           

                CB_Estado.SelectedIndex = 0;
                DateTime fecha = DateTime.Today;
                
        }

        string Valida_Datos()
        {
            String where = "where";
            if (TReserva.Text.ToString().Trim() != "")
            {
                where += " id_reservacion='" + TReserva.Text.ToString().Trim() + "'";
            }
            if (TCliente.Text.ToString().Trim() != "")
            {
                where += " and id_cliente='" + TCliente.Text.ToString().Trim() + "'";
            }

            if (TTAlojamiento.Text.ToString().Trim() != "")
            {
                where += " and id_t_aloj_reservacion='" + TTAlojamiento.Text.ToString().Trim() + "'";
            }

            if (TFecha_Ini.Text.ToString().Trim() != "" )
            {
                where += " and fecha_lleg_reservacion='" + TFecha_Ini.Text.ToString().Trim() + "'";
            }
            if (TFecha_Fin.Text.ToString().Trim() != "")
            {
                where += " and fecha_sal_reservacion='" + TFecha_Fin.Text.ToString().Trim() + "'";
            }
            if (TTotal.Text.ToString().Trim() != "")
            {
                where += " and Monto_apagar='" + TTotal.Text.ToString().Trim() + "'";
            }

            return where;
        }
      


        private void BSeguir_Click(object sender, EventArgs e)
        {

            string where = Valida_Datos();
            where = where.Replace("where and", "where ");
            string sql = "select * from reservacion ";
            sql += where;
            
            R_Reserva CP = new R_Reserva(sql,"C");
            CP.ShowDialog();
           

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

      private void BTAlojamiento_Click(object sender, EventArgs e)
            {
            Mant_C_TipoAlojamiento CP = new Mant_C_TipoAlojamiento("e");
            CP.ShowDialog();
            string id = CP.Id.ToString().Trim();
            if (id.Trim() != "0")
            {
                TTAlojamiento.Text = id;
                TdescTAlojamiento.Text = funciones.Lee_Descr_TipoAlojamiento(id);


            }
           
        }

            private void TTAlojamiento_Leave(object sender, EventArgs e)
            {
                if (TTAlojamiento.Text.ToString().Trim() != "")
                {
                    string descr = funciones.Lee_Descr_Tipo(TTAlojamiento.Text, "Tipo_alojamiento");
                    if (descr.Trim() != "")
                    {
                     TTAlojamiento.Text = descr;
                    }
                }

            }

            private void BLimpiar_Click(object sender, EventArgs e)
            {
                Limpia_Datos();
            }

        private void BCliente_Click(object sender, EventArgs e)
        {

            Mant_C_Cliente CP = new Mant_C_Cliente("e");
            CP.ShowDialog();
            string id = CP.Id.ToString().Trim();
            if (id.Trim() != "0")
            {
                TCliente.Text = id;
                TdescCliente.Text = funciones.Lee_Descr_Tercero(id, "cliente");
               

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TFecha_Ini_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
