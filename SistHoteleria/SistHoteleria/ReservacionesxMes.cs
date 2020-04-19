using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistHoteleria
{
    public partial class ReservacionesxMes : Form
    {
        
        public ReservacionesxMes()
        {
            InitializeComponent();
        }

        private void ReservacionesxMes_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        void Genera_Grafico(DataSet ds)
        {
            chart1.Titles.Add("ESTADISTICA DE RESERVACIONES POR MES");
            chart1.Titles.Add("RANGO DE FECHA");
            chart1.Titles.Add("INICIO: " + DT_FechaIni.Value.ToString("yyyy-MM-dd") + " FIN " + DT_FechaFin.Value.ToString("yyyy-MM-dd"));
            ArrayList Mes = new ArrayList();
            ArrayList Cant = new ArrayList();
            for (int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                string mes = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(int.Parse(ds.Tables[0].Rows[i][0].ToString().Trim()));
                Mes.Add(mes);
                Cant.Add(decimal.Parse(ds.Tables[0].Rows[i][1].ToString().Trim()));
            }
            chart1.Series[0].Points.DataBindXY(Cant, Mes);


        }
        void Genera_Busqueda()
        {
            string Error = "";
            DataSet DS = new DataSet();
            string Fecha_ini = DT_FechaIni.Value.ToString("yyyy-MM-dd");
            string Fecha_fin = DT_FechaFin.Value.ToString("yyyy-MM-dd");
            string sql = "select MONTH(fecha_lleg_reservacion) As MES,count(*) as Cant " +
                            " from reservacion " +
                                " where not exists(select * from cancelacion where id_reserv_cancelacion = id_reservacion) " +
                                      " and fecha_lleg_reservacion between '"+ Fecha_ini + "' "+
                                      " and '"+ Fecha_fin + "' " +
                            " group by MONTH(fecha_lleg_reservacion)";
            DS=Conexion.EjecutaSQL(sql,ref Error);
            if (DS == null && Error.Trim() != "")
            {
                MessageBox.Show("Error al Generar Consulta-->" + Error);
                return;
            }
            else
            {
                MessageBox.Show("No Encontro datos en este rango de fecha");
                return;
            }
            Genera_Grafico(DS);
        }

        private void DT_FechaFin_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DT_FechaFin.Value.Year != DT_FechaIni.Value.Year)
            {
                MessageBox.Show("La Consulta se debe realizar con un solo Ano");
                return;
            }
            Genera_Busqueda();
        }
    }
}
