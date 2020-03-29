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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Clases.Nivel_Acceso.ToUpper() == "O")
            //{
            //    MessageBox.Show("No Tiene Acceso");
            //    return;
            //}
            tipo form = new tipo("a", "Tipo_Identificacion", "Tipo Identificacion");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipob form = new tipob("C", "Tipo_Identificacion", "Tipo Identificacion");
            form.ShowDialog();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if (Clases.Nivel_Acceso.ToUpper() == "O")
            //{
            //    MessageBox.Show("No Tiene Acceso");
            //    return;
            //}
            tipo form = new tipo("a", "PAIS", "Pais");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tipob form = new tipob("C", "PAIS", "Pais");
            form.ShowDialog();
        }

        private void crearToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //if (Clases.Nivel_Acceso.ToUpper() == "O")
            //{
            //    MessageBox.Show("No Tiene Acceso");
            //    return;
            //}
            tipo form = new tipo("a", "Permisos_Adi", "Permisos Adicionales");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            tipob form = new tipob("C", "Permisos_Adi", "Permisos Adicionales");
            form.ShowDialog();
        }

        private void crearToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //if (Clases.Nivel_Acceso.ToUpper() == "O")
            //{
            //    MessageBox.Show("No Tiene Acceso");
            //    return;
            //}
            tipo form = new tipo("a", "TIPO_CLIENTE", "Tipo Cliente");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            tipob form = new tipob("C", "TIPO_CLIENTE", "Tipo Cliente");
            form.ShowDialog();
        }

        private void crearToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //if (Clases.Nivel_Acceso.ToUpper() == "O")
            //{
            //    MessageBox.Show("No Tiene Acceso");
            //    return;
            //}
            tipo form = new tipo("a", "TIPO_EMPLEADO", "Tipo Empleado");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            tipob form = new tipob("C", "TIPO_EMPLEADO", "Tipo Empleado");
            form.ShowDialog();
        }

        private void crearToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //if (Clases.Nivel_Acceso.ToUpper() == "O")
            //{
            //    MessageBox.Show("No Tiene Acceso");
            //    return;
            //}
            tipo form = new tipo("a", "tipo_archivo", "Tipo Archivo");
            form.ShowDialog();

        }

        private void consultarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            tipob form = new tipob("C", "tipo_archivo", "Tipo Archivo");
            form.ShowDialog();
        }
    }
}
