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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReservacionesxMes rs = new ReservacionesxMes();
            rs.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TipoHabMasReservadas rs = new TipoHabMasReservadas();
            rs.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ReservacionesxTemporada rs = new ReservacionesxTemporada();
            rs.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReservasVsCancelaciones rs = new ReservasVsCancelaciones();
            rs.ShowDialog();
        }
    }
}
