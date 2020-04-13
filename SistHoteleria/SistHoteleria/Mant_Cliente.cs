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
    public partial class Mant_Cliente : Form
    {
        string sql = "";
        DataSet DS = new DataSet();
        string Error = "";
        string aa_ID = "";
        string aa_Modo = "A";


        List<Clases.ETipo_Identificacion> aa_LETipo_Identificacion = new List<Clases.ETipo_Identificacion>();
        Clases.ETipo_Identificacion aa_EETipo_Identificacion = new Clases.ETipo_Identificacion();

        List<Clases.ETercero> aa_LETercero = new List<Clases.ETercero>();
        Clases.ETercero aa_ETercero = new Clases.ETercero();

        Clases.ECliente aa_ECliente = new Clases.ECliente();

        public Mant_Cliente(string ii_modo)
        {
            InitializeComponent();
            CB_Estado.SelectedIndex = 0;
            CB_EstadoTercero.SelectedIndex = 0;
            CB_Estado.Enabled = false;
            CB_EstadoTercero.Enabled = false;
            CB_Sexo.SelectedIndex = 0;
            aa_Modo = ii_modo;
        }

        public Mant_Cliente(string ii_ID,string ii_Modo)
        {
            InitializeComponent();
            aa_ID = ii_ID;
            aa_Modo = ii_Modo;

            CB_EstadoTercero.SelectedIndex = 0;
            CB_EstadoTercero.Enabled = false;
            CB_Sexo.SelectedIndex = 0;
            
        }

        private void Mant_Cliente_Load(object sender, EventArgs e)
        {
            Lee_Tipo_Identificacion();
            if (aa_Modo.Trim().ToUpper() != "A")
            {
                //  Llena_Datos();
                Pasa_Datos();
            }
        }
        void Pasa_Datos()
        {
             Error = "";
            string sql = "select * from Cliente where id_Cliente='" + aa_ID.ToString().Trim() + "'";
            DataSet DS = Conexion.EjecutaSQL(sql, ref Error);
            int Count = DS.Tables[0].Rows.Count;
            if (Count > 0)
            {
                TCliente.Text = aa_ID.ToString().Trim();
                string estado = DS.Tables[0].Rows[0]["Estado_Cliente"].ToString().Trim();
                TTipoCliente.Text = DS.Tables[0].Rows[0]["ID_T_Cliente"].ToString().Trim();
                TLimite.Text = DS.Tables[0].Rows[0]["LIM_CRED_CLIENTE"].ToString().Trim();
                TDescr_TipoCliente.Text = funciones.Lee_Tipo(TTipoCliente.Text, "TIPO_CLIENTE").descripcion.ToString().Trim();
                if (estado.ToString().Trim().ToUpper() == "A")
                {
                    CB_Estado.SelectedIndex = 0;
                }
                else
                {
                    CB_Estado.SelectedIndex = 1;
                }
                aa_ETercero = new Clases.ETercero();
                aa_ETercero = funciones.Consulta_Tercero(DS.Tables[0].Rows[0]["ID_TERCERO_Cliente"].ToString().Trim());
                Llena_Datos_Tercero(aa_ETercero);


            }



        }

        void Llena_Datos()
        {
            Error = "";
            string sql = "select * from Cliente where id_Cliente='" + aa_ID.ToString().Trim() + "'";
            DataSet DS = Conexion.EjecutaSQL(sql, ref Error);
            int Count = DS.Tables[0].Rows.Count;
            if (Count > 0)
            {
                TCliente.Text = aa_ID.ToString().Trim();
                string estado = DS.Tables[0].Rows[0]["Estado_Cliente"].ToString().Trim();
                //string tipo = DS.Tables[0].Rows[0]["ID_T_Cliente"].ToString().Trim();
                if (estado.ToString().Trim().ToUpper() == "A")
                {
                    CB_Estado.SelectedIndex = 0;
                }
                else
                {
                    CB_Estado.SelectedIndex = 1;
                }
                aa_ETercero = new Clases.ETercero();
                aa_ETercero = funciones.Consulta_Tercero(DS.Tables[0].Rows[0]["ID_TERCERO_Cliente"].ToString().Trim());
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
                        if (Inserta_Cliente())
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
        bool Inserta_Tercero()
        {
            Error = "";
            aa_ETercero = new Clases.ETercero();
            if (aa_ECliente.ID_TERCERO_CLIENTE.ToString().Trim() != "")
                aa_ETercero.id_Tercero = aa_ECliente.ID_TERCERO_CLIENTE;
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
        bool Inserta_Cliente()
        {
            Error = "";
            aa_ECliente = new Clases.ECliente();

            aa_ECliente.ID_CLIENTE = TCliente.Text.ToString().Trim();
            aa_ECliente.ID_TERCERO_CLIENTE = aa_ETercero.id_Tercero;
            aa_ECliente.ID_T_CLIENTE = TTipoCliente.Text.ToString().Trim();
            aa_ECliente.LIM_CRED_CLIENTE = decimal.Parse(TLimite.Text.ToString().Trim());
            aa_ECliente.ESTADO_CLIENTE = CB_Estado.SelectedItem.ToString().Trim().ToUpper().Substring(0,1);

            if (funciones.Inserta_Cliente(aa_ECliente, ref Error,aa_Modo))
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
            if (string.IsNullOrWhiteSpace(TCliente.Text.Trim()))
            {
                Lanza_Error(TCliente, Msj);
                return false;
            }
            
            
            if (CB_Estado.SelectedItem.ToString().Substring(0, 1).Trim().ToUpper() != "A" && aa_Modo.ToUpper()=="A")
            {
                MessageBox.Show("No puede crear Cliente Inactivo");
                return false;
            }
            if (CB_EstadoTercero.SelectedItem.ToString().Substring(0, 1).Trim().ToUpper() != "A")
            {
                MessageBox.Show("No puede crear Cliente Con Datos Inactivos");
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
            aa_ECliente.ID_TERCERO_CLIENTE = aa_ETercero.id_Tercero;
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

        private void BTCliente_Click(object sender, EventArgs e)
        {
            tipob form = new tipob("e", "TIPO_Cliente", "Tipo Cliente");
            form.ShowDialog();
            if (form.Id.ToString().Trim() != "")
            {
                TTipoCliente.Text = form.Id.ToString().Trim();
                TDescr_TipoCliente.Text = funciones.Lee_Tipo(form.Id.ToString().Trim(), "TIPO_Cliente").descripcion;
            }
        }

        private void TEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
