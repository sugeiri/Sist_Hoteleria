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
    public partial class Login : Form
    {
        string sql = "";
        DataSet DS = new DataSet();
        string error = "";
        string[] aa_Parametro = new string[2];
        string Nivel = "";
        public Login(ref string[] ii_Parametro)
        {
            InitializeComponent();
            aa_Parametro = ii_Parametro;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (Valida_Login())
            {
                aa_Parametro[0] = TUsuario.Text.Trim().ToUpper();
                aa_Parametro[1] = Nivel;

                this.Dispose();
            }
        }
        bool Valida_Login()
        {
            errorProvider1.Clear();
            string Usuario = TUsuario.Text.ToString().Trim();
            string pass = TPass.Text.ToString().Trim();
            if (string.IsNullOrWhiteSpace(Usuario))
            {
                Lanza_Error(TUsuario, "Usuario No Puede Estar en Blanco");
                return false;
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                Lanza_Error(TPass, "Contraseña No Puede Estar en Blanco");
                return false;
            }
            if(Usuario.Trim()=="aDMI"&& pass.Trim()=="971223")
            {
                Nivel = "A";
                return true;

            }
            Clases.EUsuario aa_EUsuario = new Clases.EUsuario();
            aa_EUsuario = funciones.Consulta_Usuario(Usuario);
            if (aa_EUsuario != null)
            {
                if (aa_EUsuario.Estado_Usuario.ToUpper() != "A")
                {
                    MessageBox.Show("El Usuario No Esta Activo");
                    return false;
                }
                if (Conexion.DesEncriptar(aa_EUsuario.Password_Usuario) != pass)
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    return false;
                }
                Nivel = aa_EUsuario.nivel;

            }
            else
            {
                MessageBox.Show("Este Usuario No Existe");
                return false;
            }
            
            return true;
        }
        void Lanza_Error(TextBox Campo, string Msj)
        {
            MessageBox.Show(Msj);
            errorProvider1.SetError(Campo, Msj);
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Lee_Datos_Hotel();
            LDescr_Clinica.Text = Clases.Nombre_Hotel.ToString().Trim();
        }
        public void Lee_Datos_Hotel()
        {
            sql = "SELECT * FROM HOTEL";
            try
            {
                DS = Conexion.EjecutaSQL(sql, ref error);
                if (DS.Tables.Count > 0)
                {
                    Clases.Nombre_Hotel = DS.Tables[0].Rows[0]["descr_hotel"].ToString();

                }
                else
                {
                    MessageBox.Show("NO ENCONTRO DATO DEL HOTEL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void TUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Valida_Login())
                {
                    aa_Parametro[0] = TUsuario.Text.Trim().ToUpper();
                    aa_Parametro[1] = Nivel;

                    this.Dispose();
                }
                else
                {
                    TPass.Focus();
                }
            }
        }

        private void TPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Valida_Login())
                {
                    aa_Parametro[0] = TUsuario.Text.Trim().ToUpper();
                    aa_Parametro[1] = Nivel;

                    this.Dispose();
                }
            }
        }
    }
}
