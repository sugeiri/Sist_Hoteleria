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

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //if (Clases.Nivel_Acceso.ToUpper() == "O")
            //{
            //    MessageBox.Show("No Tiene Acceso");
            //    return;
            //}
            Mant_Provincia form = new Mant_Provincia("a");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Mant_C_Provincia form = new Mant_C_Provincia("");
            form.ShowDialog();
        }

        private void crearToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //if (Clases.Nivel_Acceso.ToUpper() == "O")
            //{
            //    MessageBox.Show("No Tiene Acceso");
            //    return;
            //}
            Mant_Municipio form = new Mant_Municipio("a");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Mant_C_Municipio form = new Mant_C_Municipio("");
            form.ShowDialog();
        }

        private void crearToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //if (Clases.Nivel_Acceso.ToUpper() == "O")
            //{
            //    MessageBox.Show("No Tiene Acceso");
            //    return;
            //}
            tipo form = new tipo("a", "caracteristica", "Caracteristicas");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            tipob form = new tipob("C", "caracteristica", "Caracteristicas");
            form.ShowDialog();
        }

        private void crearToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            //if (Clases.Nivel_Acceso.ToUpper() == "O")
            //{
            //    MessageBox.Show("No Tiene Acceso");
            //    return;
            //}
            tipo form = new tipo("a", "tipo_mantenimiento", "Tipo Mantenimiento");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            tipob form = new tipob("C", "tipo_mantenimiento", "Tipo Mantenimiento");
            form.ShowDialog();
        }

        private void crearToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            //if (Clases.Nivel_Acceso.ToUpper() == "O")
            //{
            //    MessageBox.Show("No Tiene Acceso");
            //    return;
            //}
            Mant_Usuario form = new Mant_Usuario();
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Mant_C_Usuario form = new Mant_C_Usuario();
            form.ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            LHotel.Text = Clases.Nombre_Hotel;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE QUERER CERRAR SESION?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;

            }
            string[] aa_Parametro = new string[2];
            aa_Parametro[0] = "";
            aa_Parametro[1] = "";

            this.Dispose();

        }
    }
}
