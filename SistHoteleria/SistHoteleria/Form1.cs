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
    public partial class Form1 : Form
    {
        public static DataSet DS = new DataSet();
        public static string Error = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public static void Imprime(string sql, string reporte, bool Directa)
        {
            string Error = "";
            DataSet DS = new DataSet();
            DS = Conexion.EjecutaSQL(sql, ref Error);

            if (DS.Tables.Count <= 0)
            {
                MessageBox.Show("No Encontro Datos En La Busqueda");
                return;
            }
            if (DS.Tables[0].Rows.Count > 0)
            {
                try
                {
                    string rep_nom = reporte;
                    string titulo = Clases.Nombre_Hotel.ToString().ToUpper();
                    funciones.Reporte_PorPantalla(rep_nom, titulo, DS);

                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("No Encontro Datos En La Busqueda");
                return;
            }

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

    }
}
