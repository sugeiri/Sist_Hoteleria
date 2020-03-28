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
            EjemploConsulta();
        }
        void EjemploConsulta()
        {

            string sql = "SELECT * FROM hotel";
            try
            {
                DS = Conexion.EjecutaSQL(sql, ref Error);
                if (DS.Tables.Count > 0)
                {
                    
                    MessageBox.Show(DS.Tables[0].Rows[0]["descr_hotel"].ToString());
                }
                else
                {
                    MessageBox.Show("NO ENCONTRO DATOS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
