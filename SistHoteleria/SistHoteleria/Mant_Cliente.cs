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
        Clases.EDireccion aa_EDireccion = new Clases.EDireccion();
        List<Clases.EEmail> aa_LEEmail = new List<Clases.EEmail>();
        Clases.EEmail aa_EEmail = new Clases.EEmail();
        List<Clases.ETelefono> aa_LETelefono = new List<Clases.ETelefono>();
        Clases.ETelefono aa_ETelefono = new Clases.ETelefono();


        Clases.ECliente aa_ECliente = new Clases.ECliente();

        public Mant_Cliente(string ii_modo)
        {
            InitializeComponent();
            CB_Estado.SelectedIndex = 0;
            CB_Estado.Enabled = false;
            CB_Sexo.SelectedIndex = 0;
            aa_Modo = ii_modo;
        }

        public Mant_Cliente(string ii_ID, string ii_Modo)
        {
            InitializeComponent();
            aa_ID = ii_ID;
            aa_Modo = ii_Modo;

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
                aa_ECliente.ID_TERCERO_CLIENTE = aa_ETercero.id_Tercero;
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
            aa_EDireccion = new Clases.EDireccion();
            aa_LEEmail = new List<Clases.EEmail>();
            aa_EEmail = new Clases.EEmail();
            aa_LETelefono = new List<Clases.ETelefono>();
            aa_ETelefono = new Clases.ETelefono();

            TNombreTercero.Text = "";
            TIdentificacion.Text = "";
            DT_Fecha_NAc.Value = DateTime.Today;
            CB_Sexo.SelectedIndex = 0;
            CB_TipoIdentificacion.SelectedIndex = 0;
            DG_Email.Rows.Clear();
            DG_Telefono.Rows.Clear();
            Tpais.Text = "";
            Tprovincia.Text = "";
            Tmunicipio.Text = "";
            TDireccion.Text = "";



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
                    if(Inserta_Direccion())
                    {
                        if (Inserta_Telefono()) {

                            if (Inserta_Email())
                            {
                                if (Inserta_Cliente())
                                {
                                    Limpia_Datos();
                                    if (aa_Modo.ToUpper() != "A")
                                    {
                                        this.DialogResult = DialogResult.OK;
                                        this.Dispose();
                                    }
                                }
                            }
                        }
                    }

                    
                }

            }

        }
        void Limpia_Datos()
        {
            foreach (Control item in this.Controls)
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

            //foreach (Control item in this.groupBox2.Controls)
            //{
            //    try
            //    {
            //        if (item is TextBox)
            //        {
            //            item.Text = "";

            //        }

            //    }
            //    catch { }
            //}
            DT_Fecha_NAc.Value = DateTime.Today;
            CB_Estado.SelectedIndex = 0;
            CB_Sexo.SelectedIndex = 0;
            CB_TipoIdentificacion.SelectedIndex = 0;



        }
        string Busca_Tipo_Identificacion()
        {
            foreach (var Tipo in aa_LETipo_Identificacion)
            {
                if (Tipo.Descr_Tipo_Ident.ToString().Trim().ToLower() == CB_TipoIdentificacion.SelectedItem.ToString().Trim().ToLower())
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
            if (TLimite.Text.ToString().Trim() == "")
                TLimite.Text= "0";
            aa_ECliente.LIM_CRED_CLIENTE = decimal.Parse(TLimite.Text.ToString().Trim());
            aa_ECliente.ESTADO_CLIENTE = CB_Estado.SelectedItem.ToString().Trim().ToUpper().Substring(0, 1);

            if (funciones.Inserta_Cliente(aa_ECliente, ref Error, aa_Modo))
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
        bool Inserta_Telefono()
        {
            if (DG_Telefono.RowCount - 1 <= 0)
                return true;
            Error = "";
            List<Clases.ETelefono> aa_LETelefono = new List<Clases.ETelefono>();
            Clases.ETelefono aa_ETelefono = new Clases.ETelefono();
            string Tercero = aa_ETercero.id_Tercero;
            for (int ii = 0; ii < DG_Telefono.RowCount - 1; ii++)
            {
                aa_ETelefono = new Clases.ETelefono();
                aa_ETelefono.id_Tercero_Tel = Tercero;
                aa_ETelefono.Numero_Tel = DG_Telefono.Rows[ii].Cells[0].Value.ToString().Trim();
                aa_ETelefono.TIPO_Tel = DG_Telefono.Rows[ii].Cells[1].Value.ToString().Trim();// SelectedText.Substring(0, SelectedText.IndexOf("-") - 1);

                aa_LETelefono.Add(aa_ETelefono);
            }


            if (funciones.Inserta_Telefono_Tercero(aa_LETelefono, ref Error))
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
        bool Inserta_Direccion()
        {
            Error = "";
            Clases.EDireccion aa_EDireccion = new Clases.EDireccion();
            aa_EDireccion.id_Tercero_Direccion = aa_ETercero.id_Tercero;
            aa_EDireccion.id_mun_Direccion = Tmunicipio.Text.ToString().Trim();
            aa_EDireccion.Direccion = TDireccion.Text.ToString().Trim().ToUpper();
            aa_EDireccion.TIPO_DIRECCION = "C";
            aa_EDireccion.N_LINEA_DIRECCION = 0;


            if (funciones.Inserta_Direccion(aa_EDireccion, ref Error))
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
        bool Inserta_Email()
        {
            if (DG_Email.RowCount - 1 <= 0)
                return true;
            Error = "";
            List<Clases.EEmail> aa_LEEmail = new List<Clases.EEmail>();
            Clases.EEmail aa_EEmail = new Clases.EEmail();
            string Tercero = aa_ETercero.id_Tercero;
            for (int ii = 0; ii < DG_Email.RowCount - 1; ii++)
            {
                aa_EEmail = new Clases.EEmail();

                aa_EEmail.id_Tercero_Email = Tercero;
                aa_EEmail.Email = DG_Email.Rows[ii].Cells[0].Value.ToString().Trim();
                aa_EEmail.TIPO_Email = DG_Email.Rows[ii].Cells[1].Value.ToString().Trim();
                aa_LEEmail.Add(aa_EEmail);
            }

            if (aa_EEmail.id_Tercero_Email.ToString().Trim() == "")
                return true;

            if (funciones.Inserta_Email_Tercero(aa_LEEmail, ref Error))
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


            if (CB_Estado.SelectedItem.ToString().Substring(0, 1).Trim().ToUpper() != "A" && aa_Modo.ToUpper() == "A")
            {
                MessageBox.Show("No puede crear Cliente Inactivo");
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
            if(TTipoCliente.Text.ToString().Trim()=="")
            {
                MessageBox.Show("Debe Indicar Tipo de cliente");
                errorProvider1.SetError(TTipoCliente, "Debe Indicar Tipo de cliente");
                return false;
            }
            if (Tpais.Text.ToString().Trim() == "")
            {
                MessageBox.Show(Msj);
                errorProvider1.SetError(Tpais, Msj);
                return false;
            }
            if (Tprovincia.Text.ToString().Trim() == "")
            {
                MessageBox.Show(Msj);
                errorProvider1.SetError(Tprovincia, Msj);
                return false;
            }
            if (Tmunicipio.Text.ToString().Trim() == "")
            {
                MessageBox.Show(Msj);
                errorProvider1.SetError(Tmunicipio, Msj);
                return false;
            }
            if (TDireccion.Text.ToString().Trim() == "")
            {
                MessageBox.Show(Msj);
                errorProvider1.SetError(TDireccion, Msj);
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
            if (ii_ETercero == null)
                return;
            TNombreTercero.Text = ii_ETercero.Nombre_Tercero.Trim();
            TIdentificacion.Text = ii_ETercero.Cedula_Tercero.Trim();
            DT_Fecha_NAc.Value = DateTime.Parse(ii_ETercero.Fecha_Nac_Tercero);

            foreach (var Tipo in aa_LETipo_Identificacion)
            {
                if (Tipo.Id_Tipo_Ident.Trim() == ii_ETercero.ID_T_Identif_Tercero.Trim())
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
            if (ii_ETercero.Sexo_Tercero.ToUpper().Trim() == "F")
            {
                CB_Sexo.SelectedIndex = 0;
            }
            else
            {
                CB_Sexo.SelectedIndex = 1;
            }
            aa_EDireccion = funciones.Lee_Direccion_Tercero(ii_ETercero.id_Tercero);
            if (aa_EDireccion != null)
            {
                Tpais.Text = aa_EDireccion.id_Pais_Direccion.ToString().Trim();
                Tprovincia.Text = aa_EDireccion.id_Provincia_Direccion.ToString().Trim();
                Tmunicipio.Text = aa_EDireccion.id_mun_Direccion.ToString().Trim();
                TDireccion.Text = aa_EDireccion.Direccion.ToString().Trim();
            }

            aa_LEEmail = new List<Clases.EEmail>();
            aa_LETelefono = new List<Clases.ETelefono>();
            aa_LEEmail = funciones.Lee_Email_Tercero(int.Parse(ii_ETercero.id_Tercero));
            aa_LETelefono = funciones.Lee_Telefono_Tercero(int.Parse(ii_ETercero.id_Tercero));

            if (aa_LEEmail != null)
            {
                DG_Email.Rows.Clear();
                foreach (var Email in aa_LEEmail)
                {
                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(DG_Email);
                    ii_row.Cells[0].Value = Email.Email.ToString().Trim();
                    ii_row.Cells[1].Value = Email.TIPO_Email.ToUpper();
                    DG_Email.Rows.Add(ii_row);

                }

            }


            if (aa_LETelefono != null)
            {
                DG_Telefono.Rows.Clear();
                foreach (var Tel in aa_LETelefono)
                {
                    DataGridViewRow ii_row = new DataGridViewRow();
                    ii_row.CreateCells(DG_Email);
                    ii_row.Cells[0].Value = Tel.Numero_Tel.ToString().Trim();
                    ii_row.Cells[1].Value = Tel.TIPO_Tel.ToUpper();
                    DG_Telefono.Rows.Add(ii_row);
                }


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

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE QUERER LIMPIAR LOS DATOS DE TELEFONO?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            DG_Telefono.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DG_Telefono.Rows.Count - 1; i++)
            {
                if (DG_Telefono.Rows[i].Cells[0].Selected || DG_Telefono.Rows[i].Cells[1].Selected)
                {
                    DG_Telefono.Rows.RemoveAt(i);

                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < DG_Telefono.Rows.Count - 1; i++)
            {
                if (DG_Email.Rows[i].Cells[0].Selected || DG_Email.Rows[i].Cells[1].Selected)
                {
                    DG_Email.Rows.RemoveAt(i);

                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE QUERER LIMPIAR LOS DATOS DE EMAIL?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            DG_Email.Rows.Clear();
        }

        private void BPais_Click(object sender, EventArgs e)
        {
            tipob CP = new tipob("e", "PAIS", "PAIS");
            CP.ShowDialog();
            string id = CP.Id.ToString().Trim();
            if (id.ToString().Trim() != "0")
            {
                string descr = funciones.Lee_Descr_Pais(id);
                Tpais.Text = id;
                if (string.IsNullOrWhiteSpace(descr.Trim()))
                {
                    MessageBox.Show("No Existe este Pais en la Base de Datos");
                    return;
                }

                Tdescr_pais.Text = descr.ToString().Trim().ToUpper();
            }
        }

        private void BProvincia_Click(object sender, EventArgs e)
        {
            string Pais = Tpais.Text.ToString().Trim();
            Mant_C_Provincia CP = new Mant_C_Provincia(Pais);
            CP.ShowDialog();
            string id = CP.Id.ToString().Trim();
            if (id.Trim() != "")
            {
                string descr = funciones.Lee_Provincia(id).descr_provincia;
                Tprovincia.Text = id;
                if (descr.Trim() == "0")
                {
                    if (Pais.Trim() != "")
                        MessageBox.Show("No Existe esta Provincia para el Pais Seleccionado");
                    else
                        MessageBox.Show("No Existe esta Provincia en la Base de Datos");

                    return;
                }

                Tdescr_provincia.Text = descr.ToString().Trim().ToUpper();
            }
        }

        private void BMunicipio_Click(object sender, EventArgs e)
        {
            string Prov = Tprovincia.Text.ToString().Trim();
            Mant_C_Municipio CP = new Mant_C_Municipio(Prov);
            CP.ShowDialog();
            string id = CP.Id.ToString().Trim();
            if (id.Trim() != "")
            {
                string descr = funciones.Lee_Descr_Municipio(id);
                Tmunicipio.Text = id;
                if (descr.Trim() == "0")
                {
                    if (Prov.Trim() != "")
                        MessageBox.Show("No Existe esta Municipio para la Provincia Seleccionada");
                    else
                        MessageBox.Show("No Existe este Municipio en la Base de Datos");

                    return;
                }
                Tdescr_municipio.Text = descr.ToString().Trim().ToUpper();
            }
        }

        private void Tpais_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Tpais.Text.ToString().Trim()))
            {
                string id = Tpais.Text.ToString().Trim();

                string descr = funciones.Lee_Descr_Pais(id);

                if (string.IsNullOrWhiteSpace(descr.Trim()))
                {
                    MessageBox.Show("No Existe este Pais en la Base de Datos");
                    return;
                }
                Tdescr_pais.Text = descr.ToString().Trim().ToUpper();

            }
        }

        private void Tprovincia_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Tprovincia.Text.ToString().Trim()))
            {
                string id = Tprovincia.Text.ToString().Trim();


                string descr = funciones.Lee_Descr_Provincia(id);
                if (string.IsNullOrWhiteSpace(descr.Trim()))
                {
                    MessageBox.Show("No Existe esta Provincia en la Base de Datos");
                    return;
                }
                Tdescr_provincia.Text = descr.ToString().Trim().ToUpper();

            }
        }

        private void Tmunicipio_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Tmunicipio.Text.ToString().Trim()))
            {
                string id = Tmunicipio.Text.ToString().Trim();
                if (id.Trim() != "0")
                {
                    string descr = funciones.Lee_Descr_Municipio(id);
                    if (string.IsNullOrWhiteSpace(descr.Trim()))
                    {
                        MessageBox.Show("No Existe este Municipio en la Base de Datos");
                        return;
                    }
                    Tdescr_municipio.Text = descr.ToString().Trim().ToUpper();
                }
            }
        }

        private void DG_Email_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && DG_Email.Rows[e.RowIndex].Cells[0] != null && (e.RowIndex < DG_Email.Rows.Count - 1))
            {
                if (DG_Email.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    try
                    {
                        string email = DG_Email.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                        var addr = new System.Net.Mail.MailAddress(email);
                        if (addr.Address == email)
                            return;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    DG_Email.Rows.RemoveAt(e.RowIndex);
                }

            }
        }

        private void DG_Telefono_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && DG_Telefono.Rows[e.RowIndex].Cells[0] != null && (e.RowIndex < DG_Telefono.Rows.Count - 1))
            {
                if (DG_Telefono.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string numero = "";
                    long n = 0;
                    Regex regex = new Regex(@"[^0-9]");
                    numero = regex.Replace(DG_Telefono.Rows[e.RowIndex].Cells[0].Value.ToString(), "");
                    if (Int64.TryParse(numero, out n))
                    {
                        numero = String.Format("{0:(###) ###-####}", n);
                        DG_Telefono.Rows[e.RowIndex].Cells[0].Value = numero;
                    }
                }
                else
                {
                    DG_Telefono.Rows.RemoveAt(e.RowIndex);
                }

            }
        }

        private void DG_Telefono_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DG_Telefono_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void DG_Email_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void DG_Email_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DG_Telefono_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DG_Email_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BTCliente_Click_1(object sender, EventArgs e)
        {
            tipob form = new tipob("e", "TIPO_CLIENTE", "Tipo Cliente");
            form.ShowDialog();
            if (form.Id.ToString().Trim() != "")
            {
                TTipoCliente.Text = form.Id.ToString().Trim();
                TDescr_TipoCliente.Text = funciones.Lee_Tipo(form.Id.ToString().Trim(), "TIPO_CLIENTE").descripcion;
            }
        }
    }
}
