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
    public partial class Mant_Usuario : Form
    {
        string sql = "";
        DataSet DS = new DataSet();
        string Error = "";
        string aa_ID = "";
        string aa_Modo = "A";

        List<Clases.ETipo_Usuario> aa_LETipo_Usuario = new List<Clases.ETipo_Usuario>();
        Clases.ETipo_Usuario aa_ETipo_Usuario = new Clases.ETipo_Usuario();

        List<Clases.ETipo_Identificacion> aa_LETipo_Identificacion = new List<Clases.ETipo_Identificacion>();
        Clases.ETipo_Identificacion aa_EETipo_Identificacion = new Clases.ETipo_Identificacion();

        List<Clases.ETercero> aa_LETercero = new List<Clases.ETercero>();
        Clases.ETercero aa_ETercero = new Clases.ETercero();

        Clases.EUsuario aa_EUsuario = new Clases.EUsuario();

        public Mant_Usuario()
        {
            InitializeComponent();
            CB_Estado.SelectedIndex = 0;
            CB_EstadoTercero.SelectedIndex = 0;
            CB_Estado.Enabled = false;
            CB_EstadoTercero.Enabled = false;
            CB_Sexo.SelectedIndex = 0;
        }

        public Mant_Usuario(string ii_ID,string ii_Modo)
        {
            InitializeComponent();
            aa_ID = ii_ID;
            aa_Modo = ii_Modo;

            CB_EstadoTercero.SelectedIndex = 0;
            CB_EstadoTercero.Enabled = false;
            CB_Sexo.SelectedIndex = 0;
        }

        private void Mant_Usuario_Load(object sender, EventArgs e)
        {
            Lee_Tipo_Usuario();
            Lee_Tipo_Identificacion();
            if(aa_Modo.Trim().ToUpper()=="B")
            {
                Llena_Datos();
            }
        }
        void Llena_Datos()
        {
            Error = "";
            string sql = "select * from USUARIO where id_USUARIO='" + aa_ID.ToString().Trim() + "'";
            DataSet DS = Conexion.EjecutaSQL(sql, ref Error);
            int Count = DS.Tables[0].Rows.Count;
            if (Count > 0)
            {
                TUsuario.Text = aa_ID.ToString().Trim();
                TPassw.Text = Conexion.DesEncriptar(DS.Tables[0].Rows[0]["Password_Usuario"].ToString().Trim());
                TConfirmacion.Text = TPassw.Text;
                string estado = DS.Tables[0].Rows[0]["Estado_Usuario"].ToString().Trim();
                string tipo = DS.Tables[0].Rows[0]["Tipo_Usuario"].ToString().Trim();
                if (estado.ToString().Trim().ToUpper() == "A")
                {
                    CB_Estado.SelectedIndex = 0;
                }
                else
                {
                    CB_Estado.SelectedIndex = 1;
                }
                foreach (var Tipo in aa_LETipo_Usuario)
                {
                    if (Tipo.id_T_Usuario.Trim().ToUpper() ==tipo.ToUpper())
                    {
                        for (int ii = 0; ii < CB_TipoUsuario.Items.Count; ii++)
                        {
                            if ((Tipo.Descripcion_T_Usuario.ToString().Trim() == CB_TipoUsuario.Items[ii].ToString().Trim()))
                            {
                                CB_TipoUsuario.SelectedIndex = ii;
                                break;
                            }
                        }
                    }

                }
                aa_ETercero = new Clases.ETercero();
                aa_ETercero = funciones.Consulta_Tercero(DS.Tables[0].Rows[0]["id_Tercero_Usuario"].ToString().Trim());
                Limpia_Datos_Tercero();
                Llena_Datos_Tercero(aa_ETercero);
                 

            }
        }
        void Limpia_Datos_Tercero()
        {


            TNombreTercero.Text = "";
            TIdentificacion.Text = "";


            DT_Fecha_NAc.Value = DateTime.Today;
            CB_Sexo.SelectedIndex = 0;
            CB_TipoIdentificacion.SelectedIndex = 0;
         

        }
        public void Lee_Tipo_Usuario()
        {
            CB_TipoUsuario.Items.Add("");
            aa_LETipo_Usuario = new List<Clases.ETipo_Usuario>();
            aa_ETipo_Usuario = new Clases.ETipo_Usuario();
            sql = "SELECT * FROM Tipo_Usuario where Estado_T_Usuario='A'";

            try
            {
                DS = Conexion.EjecutaSQL(sql, ref Error);
                int Count = DS.Tables.Count;
                if (Count > 0)
                {
                    Count = DS.Tables[0].Rows.Count;
                    for (int i = 0; i < Count; i++)
                    {
                        aa_ETipo_Usuario = new Clases.ETipo_Usuario();
                        aa_ETipo_Usuario.id_T_Usuario = DS.Tables[0].Rows[i]["id_T_Usuario"].ToString();
                        aa_ETipo_Usuario.Descripcion_T_Usuario = DS.Tables[0].Rows[i]["Descripcion_T_Usuario"].ToString();
                        aa_ETipo_Usuario.Estado_T_Usuario = DS.Tables[0].Rows[i]["Estado_T_Usuario"].ToString();
                        aa_ETipo_Usuario.Nivel_Acceso_T_Usuario = DS.Tables[0].Rows[i]["Nivel_Acceso_T_Usuario"].ToString();
                        aa_LETipo_Usuario.Add(aa_ETipo_Usuario);
                        CB_TipoUsuario.Items.Add(aa_ETipo_Usuario.Descripcion_T_Usuario);
                    }
                    CB_TipoUsuario.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("NO ENCONTRO DATO DE LA CLINICA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Lee_Tipo_Identificacion()
        {
            CB_TipoIdentificacion.Items.Add("");
            aa_LETipo_Identificacion = new List<Clases.ETipo_Identificacion>();
            aa_EETipo_Identificacion = new Clases.ETipo_Identificacion();
            sql = "SELECT * FROM Tipo_Identificacion where Estado_Tipo_Ident='A'";

            try
            {
                DS = Conexion.EjecutaSQL(sql, ref Error);
                int Count = DS.Tables.Count;
                if (Count > 0)
                {
                    Count = DS.Tables[0].Rows.Count;
                    for (int i = 0; i < Count; i++)
                    {
                        aa_EETipo_Identificacion = new Clases.ETipo_Identificacion();
                        aa_EETipo_Identificacion.Id_Tipo_Ident = DS.Tables[0].Rows[i]["Id_Tipo_Ident"].ToString();
                        aa_EETipo_Identificacion.Descr_Tipo_Ident = DS.Tables[0].Rows[i]["Descr_Tipo_Ident"].ToString();
                        aa_LETipo_Identificacion.Add(aa_EETipo_Identificacion);
                        CB_TipoIdentificacion.Items.Add(aa_EETipo_Identificacion.Descr_Tipo_Ident);
                    }
                    CB_TipoIdentificacion.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("NO ENCONTRO DATOS EN LA BUSQUEDA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TConfirmacion_Leave(object sender, EventArgs e)
        {
            BCheck_M.Visible = false;
            Bcheck_B.Visible = false;
            if (TPassw.Text.Trim() != TConfirmacion.Text.Trim())
            {
                BCheck_M.Visible = true;
            }
            else
            {
                Bcheck_B.Visible = true;
            }
        }

        private void DT_Fecha_NAc_ValueChanged(object sender, EventArgs e)
        {

            string nacimiento = DT_Fecha_NAc.Value.ToString("dd/MM/yyyy"); //Fecha de nacimiento
            if (DateTime.Today < Convert.ToDateTime(nacimiento))
            {
                MessageBox.Show("La fecha de Nacimiento no puede ser mayor que la fecha actual");
                return;
            }
            TEdad.Text = DateTime.Today.AddTicks(-Convert.ToDateTime(nacimiento).Ticks).Year - 1 + " Años";
        }

        private void BSeguir_Click(object sender, EventArgs e)
        {
            if (Valida_Datos())
            {
                
                   if (Inserta_Tercero())
                    {
                        if (Inserta_Usuario())
                        {
                            Limpia_Datos();
                            if(aa_Modo.ToUpper()!="A")
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Dispose();
                            }
                        }
                    }
               
            }

        }
        void Limpia_Datos()
        {
            foreach (Control item in this.groupBox1.Controls)
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
            foreach (Control item in this.groupBox2.Controls)
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
            DT_Fecha_NAc.Value = DateTime.Today;
            CB_Estado.SelectedIndex = 0;
            CB_EstadoTercero.SelectedIndex = 0;
            CB_Sexo.SelectedIndex = 0;
            CB_TipoIdentificacion.SelectedIndex = 0;
            CB_TipoUsuario.SelectedIndex = 0;


        }
        string Busca_Tipo_Identificacion()
        {
            foreach (var Tipo in aa_LETipo_Identificacion)
            {
                if(Tipo.Descr_Tipo_Ident.ToString().Trim().ToLower()==CB_TipoIdentificacion.SelectedItem.ToString().Trim().ToLower())
                {
                    return Tipo.Id_Tipo_Ident;
                }
            }
            return "";
        }
        string Busca_Tipo_Usuario()
        {
            foreach (var Tipo in aa_LETipo_Usuario)
            {
                if (Tipo.Descripcion_T_Usuario.ToString().Trim() == CB_TipoUsuario.SelectedItem.ToString().Trim())
                {
                    return Tipo.id_T_Usuario;
                }
            }
            return "";
        }
        bool Inserta_Tercero()
        {
            Error = "";
          //  aa_ETercero = new Clases.ETercero();
            if (aa_EUsuario.id_Tercero_Usuario.ToString().Trim() != "")
                aa_ETercero.id_Tercero = aa_EUsuario.id_Tercero_Usuario;
            aa_ETercero.Nombre_Tercero = TNombreTercero.Text.ToString().Trim();
            aa_ETercero.ID_T_Identif_Tercero = Busca_Tipo_Identificacion().Trim();

            Regex regex = new Regex(@"[^0-9]");
            string cedula = regex.Replace(TIdentificacion.Text.ToString().Trim(), "");

            aa_ETercero.Cedula_Tercero = cedula;
            aa_ETercero.Fecha_Nac_Tercero = DT_Fecha_NAc.Value.ToString("yyyy-MM-dd").Trim();
            aa_ETercero.Sexo_Tercero = CB_Sexo.SelectedItem.ToString().Trim().Substring(0, 1).Trim();
            aa_ETercero.Estado_Tercero = "A";

            if (funciones.Inserta_Tercero(aa_ETercero, ref Error))
            {
                aa_ETercero.id_Tercero = Error;
                return true;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(Error.Trim()))
                {
                    MessageBox.Show(Error.ToString().Trim());
                }
            }
            return false;
        }
        bool Inserta_Usuario()
        {
            Error = "";
            aa_EUsuario = new Clases.EUsuario();

            aa_EUsuario.id_Usuario = TUsuario.Text.ToString().Trim();
            aa_EUsuario.id_Tercero_Usuario = aa_ETercero.id_Tercero;
            aa_EUsuario.id_Tipo_Usuario = Busca_Tipo_Usuario().ToString().Trim();
            aa_EUsuario.Password_Usuario = Conexion.Encriptar(TPassw.Text.ToString().Trim());
            aa_EUsuario.Estado_Usuario = CB_Estado.SelectedItem.ToString().Trim().ToUpper().Substring(0,1);

            if (funciones.Inserta_Usuario(aa_EUsuario, ref Error,aa_Modo))
            {
                return true;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(Error.Trim()))
                {
                    MessageBox.Show(Error.ToString().Trim());
                }
            }
            return false;
        }

        bool Valida_Datos()
        {
            errorProvider1.Clear();
            string Msj = "Este Campo No Puede Estar en Blanco";
            if (string.IsNullOrWhiteSpace(TUsuario.Text.Trim()))
            {
                Lanza_Error(TUsuario, Msj);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TPassw.Text.Trim()))
            {
                Lanza_Error(TPassw, Msj);
                return false;
            }
            if (TPassw.Text.Trim() != TConfirmacion.Text.Trim())
            {
                Lanza_Error(TConfirmacion, "Las Contraseñas no Coinciden");
                return false;
            }
            if (string.IsNullOrWhiteSpace(CB_TipoUsuario.SelectedItem.ToString().Trim()))
            {
                MessageBox.Show("Debe Especificar Tipo de Usuario");
                return false;
            }
            
            if (CB_Estado.SelectedItem.ToString().Substring(0, 1).Trim().ToUpper() != "A" && aa_Modo.ToUpper()=="A")
            {
                MessageBox.Show("No puede crear Usuario Inactivo");
                return false;
            }
            if (CB_EstadoTercero.SelectedItem.ToString().Substring(0, 1).Trim().ToUpper() != "A")
            {
                MessageBox.Show("No puede crear Usuario Con Datos Inactivos");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TNombreTercero.Text.Trim()))
            {
                Lanza_Error(TNombreTercero, Msj);
                return false;
            }
            if (CB_TipoIdentificacion.SelectedItem.ToString().Trim() != "Menor de Edad" && string.IsNullOrWhiteSpace(TIdentificacion.Text.ToString().Trim()))
            {
                Lanza_Error(TIdentificacion, Msj);
                return false;
            }
            if (string.IsNullOrWhiteSpace(CB_Sexo.SelectedItem.ToString().Trim()))
            {
                Lanza_Error(TIdentificacion, Msj);
                return false;
            }
            if (DateTime.Today.ToString("dd/MM/yyyy") == DT_Fecha_NAc.Value.ToString("dd/MM/yyyy"))
            {
                MessageBox.Show("La fecha de Nacimiento no Puede ser la fecha actual");
                errorProvider1.SetError(DT_Fecha_NAc, "La fecha de Nacimiento no Puede ser la fecha actual");
                return false;
            }


            return true;
        }
        void Lanza_Error(TextBox Campo, string Msj)
        {
            MessageBox.Show(Msj);
            errorProvider1.SetError(Campo, Msj);
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            Limpia_Datos();
        }

        private void BBuscar_P_Click(object sender, EventArgs e)
        {
            Mant_C_Persona CP = new Mant_C_Persona();
            CP.ShowDialog();
            //aqui recibir id del tercero
            string id_T = CP.Id.ToString().Trim();
            aa_ETercero = new Clases.ETercero();
            aa_ETercero = funciones.Consulta_Tercero(id_T);
            Llena_Datos_Tercero(aa_ETercero);
            aa_EUsuario.id_Tercero_Usuario = aa_ETercero.id_Tercero;
        }
        void Llena_Datos_Tercero(Clases.ETercero ii_ETercero)
        {
            TNombreTercero.Text = ii_ETercero.Nombre_Tercero.Trim();
            TIdentificacion.Text=ii_ETercero.Cedula_Tercero.Trim();
            DT_Fecha_NAc.Value=DateTime.Parse(ii_ETercero.Fecha_Nac_Tercero);
          
            foreach (var Tipo in aa_LETipo_Identificacion)
            {
                if(Tipo.Id_Tipo_Ident.Trim()== ii_ETercero.ID_T_Identif_Tercero.Trim())
                {
                    for (int ii = 0; ii < CB_TipoIdentificacion.Items.Count; ii++)
                    {
                        if ((Tipo.Descr_Tipo_Ident.ToString().Trim() == CB_TipoIdentificacion.Items[ii].ToString().Trim()))
                        {
                            CB_TipoIdentificacion.SelectedIndex = ii;
                            break;
                        }
                    }
                }
                
            }
            if(ii_ETercero.Sexo_Tercero.ToUpper().Trim()=="F")
            {
                CB_Sexo.SelectedIndex = 0;
            }
            else
            {
                CB_Sexo.SelectedIndex = 1;
            }
            if (ii_ETercero.Estado_Tercero.ToUpper().Trim() == "A")
            {
                CB_EstadoTercero.SelectedIndex = 0;
            }
            else
            {
                CB_EstadoTercero.SelectedIndex = 1;
            }

        }
    }
}
