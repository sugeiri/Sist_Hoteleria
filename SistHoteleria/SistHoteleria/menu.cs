﻿using System;
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
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
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
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
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
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
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
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
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
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
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
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
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
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
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
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
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
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
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
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
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
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
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

        private void cREARToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
            Mant_Cama form = new Mant_Cama("a");
            form.ShowDialog();
        }

        private void cONSULTARToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Mant_C_Cama form = new Mant_C_Cama();
            form.ShowDialog();
        }

        private void crearToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
            Mant_Habitacion form = new Mant_Habitacion("a");
            form.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_C_Habitacion form = new Mant_C_Habitacion();
            form.ShowDialog();

        }

        private void asignarCamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
            Mant_TipoHabitacion form = new Mant_TipoHabitacion("a");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Mant_C_TipoHabitacion form = new Mant_C_TipoHabitacion();
            form.ShowDialog();
        }

        private void crearToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
            Mant_Edificio form = new Mant_Edificio("a");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Mant_C_Edificio form = new Mant_C_Edificio();
            form.ShowDialog();
        }

        private void crearToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
            Mant_Empleado form = new Mant_Empleado("a");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Mant_C_Empleado form = new Mant_C_Empleado();
            form.ShowDialog();
        }

        private void crearToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
            Mant_Cliente form = new Mant_Cliente("a");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Mant_C_Cliente form = new Mant_C_Cliente();
            form.ShowDialog();
        }

        private void crearToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
            Mant_Servicio form = new Mant_Servicio("a");
            form.ShowDialog();

        }

        private void consultarToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Mant_C_Servicio form = new Mant_C_Servicio();
            form.ShowDialog();
        }

        private void crearToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
            Mant_Temporada form = new Mant_Temporada("a");
            form.ShowDialog();
        }

        private void asignarAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
            Conf_CaractTHabitacion form = new Conf_CaractTHabitacion("a","");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Conf_C_CaractTHabitacion form = new Conf_C_CaractTHabitacion("c");
            form.ShowDialog();
        }

        private void crearToolStripMenuItem20_Click(object sender, EventArgs e)
        {
            if (Clases.Nivel_Acceso.ToUpper() == "O")
            {
                MessageBox.Show("No Tiene Acceso");
                return;
            }
            Mant_TipoAlojamiento form = new Mant_TipoAlojamiento("a");
            form.ShowDialog();
        }

        private void consultarToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            Mant_C_TipoAlojamiento form = new Mant_C_TipoAlojamiento();
            form.ShowDialog();
        }
    }
}
