using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistHoteleria
{
    public class funciones
    {
        public static Clases.ETipo Lee_Tipo(string id, string tabla)
        {
            string sql = "";
            Clases.ETipo ii_Tipo = new Clases.ETipo();
            DataSet DS = new DataSet();
            string Error = "";
            string campo = "";
            string tipo = "";
            sql = "select COLUMN_NAME,DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '" + tabla + "' and ORDINAL_POSITION = 1";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                campo = DS.Tables[0].Rows[0]["COLUMN_NAME"].ToString();
                tipo = DS.Tables[0].Rows[0]["DATA_TYPE"].ToString();
            }

            sql = "  SELECT * from  " + tabla + " WHERE  " + campo + " = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ii_Tipo.id = id;
                ii_Tipo.descripcion = DS.Tables[0].Rows[0][1].ToString();
                ii_Tipo.estado = DS.Tables[0].Rows[0][2].ToString();
                if (tipo.ToString().Trim().ToLower() == "int")
                    ii_Tipo.Tipo_PK_int = true;
                else
                    ii_Tipo.Tipo_PK_int = false;
                return ii_Tipo;

            }
            return null;

        }
        public static string Lee_Descr_Tipo(string id, string tabla)
        {
            string sql = "";
            Clases.ETipo ii_Tipo = new Clases.ETipo();
            DataSet DS = new DataSet();
            string Error = "";
            string campo = "";
            string tipo = "";
            sql = "select COLUMN_NAME,DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '" + tabla + "' and ORDINAL_POSITION = 1";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                campo = DS.Tables[0].Rows[0]["COLUMN_NAME"].ToString();
                tipo = DS.Tables[0].Rows[0]["DATA_TYPE"].ToString();
            }

            sql = "  SELECT * from  " + tabla + " WHERE  " + campo + " = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                return DS.Tables[0].Rows[0][1].ToString();


            }
            return "";

        }
        public static bool TipoPK(string tabla)
        {
            string sql = "";
            DataSet DS = new DataSet();
            string Error = "";
            sql = "select COLUMN_NAME,DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '" + tabla + "' and ORDINAL_POSITION = 1";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                if (DS.Tables[0].Rows[0]["DATA_TYPE"].ToString().Trim().ToLower() == "int")
                    return true;

            }

            return false;

        }
        public static int Prox_Codigo(string tabla)
        {
            string sql = "";
            Clases.ETipo ii_Tipo = new Clases.ETipo();
            DataSet DS = new DataSet();
            string Error = "";
            string campo = "";
            string tipo = "";
            sql = "select COLUMN_NAME,DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '" + tabla + "' and ORDINAL_POSITION = 1";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                campo = DS.Tables[0].Rows[0]["COLUMN_NAME"].ToString();
            }

            sql = "  SELECT isnull(MAX(" + campo + "),0) from  " + tabla;
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                return int.Parse(DS.Tables[0].Rows[0][0].ToString()) + 1;

            }
            return 0;

        }

        public static List<string> Lista_Estados(string ii_Tabla, string Campo)
        {
            DataSet DS = new DataSet();
            string Error = "";
            string sql = "select distinct " + Campo + " from " + ii_Tabla;
            List<string> int_Lista = new List<string>();
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                int Count = DS.Tables[0].Rows.Count;
                for (int i = 0; i < Count; i++)
                {
                    int_Lista.Add(DS.Tables[0].Rows[i][0].ToString());

                }

                return int_Lista;

            }
            return null;
        }
        public static string Lee_Descr_Pais(string id)
        {
            DataSet DS = new DataSet();
            string Error = "";
            string sql = "  SELECT * from  PAIS WHERE  id_pais = '" + id + "' and " +
                    "               estado_pais='A'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                return DS.Tables[0].Rows[0]["descr_pais"].ToString();

            }
            return "";

        }
        public static Clases.EProvincia Lee_Provincia(string id)
        {
            string sql = "";
            Clases.EProvincia ii_Provincia = new Clases.EProvincia();
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  PROVINCIA  WHERE id_provincia = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ii_Provincia.id_provincia = id;
                ii_Provincia.descr_provincia = DS.Tables[0].Rows[0]["descr_provincia"].ToString();
                ii_Provincia.estado_provincia = DS.Tables[0].Rows[0]["estado_provincia"].ToString();
                ii_Provincia.id_pais_provincia = DS.Tables[0].Rows[0]["id_pais_provincia"].ToString();

                return ii_Provincia;

            }
            return null;

        }
        public static string Lee_Descr_Provincia(string id)
        {
            string sql = "";
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  PROVINCIA  WHERE id_provincia = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                return DS.Tables[0].Rows[0]["descr_provincia"].ToString();

            }
            return "";

        }
        public static Clases.EMunicipio Lee_Municipio(string id)
        {
            string sql = "";
            Clases.EMunicipio ii_Municipio = new Clases.EMunicipio();
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  Municipio  WHERE id_Municipio = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ii_Municipio.id_municipio = id;
                ii_Municipio.descr_municipio = DS.Tables[0].Rows[0]["descr_municipio"].ToString();
                ii_Municipio.estado_municipio = DS.Tables[0].Rows[0]["estado_municipio"].ToString();
                ii_Municipio.id_prov_municipio = DS.Tables[0].Rows[0]["id_prov_municipio"].ToString();

                return ii_Municipio;

            }
            return null;

        }
        public static string Lee_Descr_Municipio(string id)
        {
            string sql = "";
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  Municipio  WHERE id_Municipio = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                return DS.Tables[0].Rows[0]["descr_municipio"].ToString();


            }
            return "";

        }
        public static Clases.ETercero Consulta_Tercero(string id_tercero)
        {
            Clases.ETercero ii_ETercero = new Clases.ETercero();
            string Error = "";
            DataSet ds = new DataSet();
            try
            {
                string consulta = "select * from Tercero where id_Tercero='" + id_tercero.Trim() + "'";
                ds = Conexion.EjecutaSQL(consulta, ref Error);
                if (ds.Tables.Count > 0)
                {
                    ii_ETercero.id_Tercero = ds.Tables[0].Rows[0]["id_Tercero"].ToString().Trim();
                    ii_ETercero.Nombre_Tercero = ds.Tables[0].Rows[0]["Nombre_Tercero"].ToString().Trim();
                    ii_ETercero.ID_T_Identif_Tercero = ds.Tables[0].Rows[0]["ID_T_Identif_Tercero"].ToString().Trim();
                    ii_ETercero.Cedula_Tercero = ds.Tables[0].Rows[0]["Cedula_Tercero"].ToString().Trim();
                    ii_ETercero.Fecha_Nac_Tercero = ds.Tables[0].Rows[0]["Fecha_Nac_Tercero"].ToString().Trim();
                    ii_ETercero.Estado_Tercero = ds.Tables[0].Rows[0]["Estado_Tercero"].ToString().Trim();
                    ii_ETercero.Sexo_Tercero = ds.Tables[0].Rows[0]["Sexo_Tercero"].ToString().Trim();
                    return ii_ETercero;
                }

            }
            catch (Exception e)
            {
                Error = e.Message.ToString();
            }
            return null;
        }
        public static bool Inserta_Usuario(Clases.EUsuario ii_EUsuario, ref string Error, string modo)
        {
            string sql = "";

            sql = "EXEC ACTUSUARIO '" +
                                ii_EUsuario.id_Usuario + "','" +
                                ii_EUsuario.id_Tercero_Usuario + "','" +
                                ii_EUsuario.id_Tipo_Usuario + "','" +
                                ii_EUsuario.Password_Usuario + "','" +
                                ii_EUsuario.Estado_Usuario + "','" +
                                modo.Trim().ToUpper() + "'";


            if (Conexion.Inserta_Datos(sql, ref Error))
            {
                return true;
            }

            return false;
        }
        public static int Genera_Codigo_Numerico(string tabla, string campo)
        {
            string Error = "";
            DataSet ds = new DataSet();
            try
            {
                string consulta = "select isnull(max(" + campo + "),0) as Id from " + tabla;
                ds = Conexion.EjecutaSQL(consulta, ref Error);
                if (ds.Tables.Count > 0)
                {
                    return (Convert.ToInt16(ds.Tables[0].Rows[0]["Id"]) + 1);

                }
            }
            catch (Exception e)
            {
                Error = e.Message.ToString();
            }
            return 0;
        }
        public static bool Inserta_Tercero(Clases.ETercero ii_ETercero, ref string Error)
        {
            int ID = 0;
            string sql = "";
            string modo = "A";
            if (ii_ETercero.id_Tercero.Trim() != "")
            {
                ID = int.Parse(ii_ETercero.id_Tercero);
                modo = "M";
            }
            else
            {
                ID = funciones.Genera_Codigo_Numerico("Tercero", "id_Tercero");
            }

            sql = "EXEC ACTTercero " + ID + ",'" +
                                    ii_ETercero.Nombre_Tercero + "','" +
                                    ii_ETercero.ID_T_Identif_Tercero + "','" +
                                    ii_ETercero.Cedula_Tercero + "','" +
                                    ii_ETercero.Fecha_Nac_Tercero + "','" +
                                    ii_ETercero.Sexo_Tercero + "'," +
                                    "'A','" + modo + "'";

            if (Conexion.Inserta_Datos(sql, ref Error))
            {
                Error = ID.ToString();
                return true;
            }

            return false;
        }
        public static bool Inserta_Telefono_Tercero(List<Clases.ETelefono> ii_LETelefono, ref string Error)
        {
            string sql = "";
            sql = "DELETE TELEFONO WHERE id_Tercero_Tel='" + ii_LETelefono[0].id_Tercero_Tel + "'";
            if (!Conexion.Inserta_Datos(sql, ref Error))
            {
                return false;
            }
            int ii = 0;
            foreach (var Tel in ii_LETelefono)
            {
                sql = "EXEC ACTTELEFONO '" + Tel.id_Tercero_Tel + "','" +
                                    Tel.Numero_Tel + "','" +
                                    Tel.TIPO_Tel + "'," +
                                    ii + "," +
                                    "'A'";
                if (!Conexion.Inserta_Datos(sql, ref Error))
                {
                    return false;
                }
                ii++;
            }
            return true;
        }
        public static bool Inserta_Email_Tercero(List<Clases.EEmail> ii_LEmail, ref string Error)
        {
            string sql = "";
            sql = "DELETE EMAIL WHERE id_Tercero_Email='" + ii_LEmail[0].id_Tercero_Email + "'";
            if (!Conexion.Inserta_Datos(sql, ref Error))
            {
                return false;
            }
            int ii = 0;
            foreach (var Email in ii_LEmail)
            {
                sql = "EXEC ACTEMAIL '" + Email.id_Tercero_Email + "','" +
                                    Email.Email + "','" +
                                    Email.TIPO_Email + "'," +
                                    ii + "," +
                                    "'A'";
                if (!Conexion.Inserta_Datos(sql, ref Error))
                {
                    return false;
                }
                ii++;
            }
            return true;
        }
        public static bool Inserta_Direccion(Clases.EDireccion ii_EDireccion, ref string Error)
        {
            string sql = "";
            sql = "DELETE DIRECCION WHERE id_Tercero_Direccion='" + ii_EDireccion.id_Tercero_Direccion + "'";
            if (!Conexion.Inserta_Datos(sql, ref Error))
            {
                return false;
            }
            sql = "EXEC ACTDIRECCION '" + ii_EDireccion.id_Tercero_Direccion + "','" +
                                                    ii_EDireccion.id_mun_Direccion + "','" +
                                                    ii_EDireccion.Direccion + "','" +
                                                    ii_EDireccion.TIPO_DIRECCION + "'," +
                                                    ii_EDireccion.N_LINEA_DIRECCION + ",'A'";
            if (!Conexion.Inserta_Datos(sql, ref Error))
            {
                return false;
            }

            return true;
        }
        public static Clases.EUsuario Consulta_Usuario(string Usuario)
        {
            Clases.EUsuario ii_EUsuario = new Clases.EUsuario();
            string Error = "";
            DataSet ds = new DataSet();
            try
            {
                string consulta = "select * from Usuario where id_Usuario='" + Usuario.Trim() + "'";
                ds = Conexion.EjecutaSQL(consulta, ref Error);
                if (ds.Tables.Count > 0)
                {
                    ii_EUsuario.id_Usuario = ds.Tables[0].Rows[0]["id_Usuario"].ToString().Trim();
                    ii_EUsuario.Password_Usuario = ds.Tables[0].Rows[0]["Password_Usuario"].ToString().Trim();
                    ii_EUsuario.Estado_Usuario = ds.Tables[0].Rows[0]["Estado_Usuario"].ToString().Trim();
                    ii_EUsuario.id_Tipo_Usuario = ds.Tables[0].Rows[0]["Tipo_Usuario"].ToString().Trim();
                    ii_EUsuario.nivel = Busca_Nivel(ii_EUsuario.id_Tipo_Usuario);
                    return ii_EUsuario;
                }

            }
            catch (Exception e)
            {
                Error = e.Message.ToString();
            }
            return null;
        }
        public static string Busca_Nivel(string Tipo_Usuario)
        {
            string Error = "";
            DataSet ds = new DataSet();
            try
            {
                string consulta = "select * from Tipo_Usuario where id_T_Usuario='" + Tipo_Usuario.Trim() + "'";
                ds = Conexion.EjecutaSQL(consulta, ref Error);
                if (ds.Tables.Count > 0)
                {
                    return ds.Tables[0].Rows[0]["Nivel_Acceso_T_Usuario"].ToString().Trim();
                }

            }
            catch (Exception e)
            {
                Error = e.Message.ToString();
            }
            return "";
        }
        //DA
        public static Clases.ECama Lee_Cama(string id)
        {
            string sql = "";
            Clases.ECama ii_Cama = new Clases.ECama();
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  Cama  WHERE id_Cama = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ii_Cama.id_cama = id;
                ii_Cama.descr_cama = DS.Tables[0].Rows[0]["descr_cama"].ToString();
                ii_Cama.capacidad_cama = int.Parse(DS.Tables[0].Rows[0]["capacidad_cama"].ToString());
                ii_Cama.estado_cama = DS.Tables[0].Rows[0]["estado_cama"].ToString();

                return ii_Cama;

            }
            return null;

        }

        public static Clases.EHabitacion Lee_Habitacion(string id)
        {
            string sql = "";
            Clases.EHabitacion ii_habitacion = new Clases.EHabitacion();
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  habitacion  WHERE id_habitacion = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ii_habitacion.id_habitacion = id;
                ii_habitacion.descr_habitacion = DS.Tables[0].Rows[0]["descr_habitacion"].ToString();
                ii_habitacion.t_habitacion = DS.Tables[0].Rows[0]["t_habitacion"].ToString();
                ii_habitacion.edificio_habitacion = DS.Tables[0].Rows[0]["edificio_habitacion"].ToString();
                ii_habitacion.piso_habitacion = int.Parse(DS.Tables[0].Rows[0]["piso_habitacion"].ToString());
                ii_habitacion.estado_habitacion = DS.Tables[0].Rows[0]["estado_habitacion"].ToString();

                return ii_habitacion;
            }
            return null;

        }

        public static Clases.ETHabitacion Lee_TipoHabitacion(string id)
        {
            string sql = "";
            Clases.ETHabitacion ii_THabitacion = new Clases.ETHabitacion();
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  tipo_habitacion  WHERE id_t_hab = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ii_THabitacion.id_t_hab = id;
                ii_THabitacion.descr_t_hab = DS.Tables[0].Rows[0]["descr_t_hab"].ToString();
                ii_THabitacion.capacidad_hab = DS.Tables[0].Rows[0]["capacidad_hab"].ToString();
                ii_THabitacion.costo_hab = DS.Tables[0].Rows[0]["costo_hab"].ToString();
                ii_THabitacion.estado_t_hab = DS.Tables[0].Rows[0]["estado_t_hab"].ToString();

                return ii_THabitacion;
            }
            return null;

        }

        public static Clases.EEdificio Lee_Edificio(string id)
        {
            string sql = "";
            Clases.EEdificio ii_Edificio = new Clases.EEdificio();
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  edificio  WHERE id_edificio = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ii_Edificio.id_edificio = id;
                ii_Edificio.descr_edificio = DS.Tables[0].Rows[0]["descr_edificio"].ToString();
                ii_Edificio.cant_nivel_edificio = int.Parse(DS.Tables[0].Rows[0]["cant_nivel_edificio"].ToString());
                ii_Edificio.estado_edificio = DS.Tables[0].Rows[0]["estado_edificio"].ToString();

                return ii_Edificio;
            }
            return null;

        }
        public static Clases.EEmpleado Lee_Empleado(string id)
        {
            string sql = "";
            Clases.EEmpleado ii_Empleado = new Clases.EEmpleado();
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  empleado  WHERE id_empleado = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ii_Empleado.id_empleado = id;
                ii_Empleado.id_tercero_empleado = DS.Tables[0].Rows[0]["id_tercero_empleado"].ToString();
                ii_Empleado.id_t_empleado = DS.Tables[0].Rows[0]["id_t_empleado"].ToString();
                ii_Empleado.fecha_i_empleado = DS.Tables[0].Rows[0]["fecha_i_empleado"].ToString();
                ii_Empleado.estado_empleado = DS.Tables[0].Rows[0]["estado_empleado"].ToString();

                return ii_Empleado;
            }
            return null;

        }
        public static bool Inserta_Empleado(Clases.EEmpleado ii_EEmpleado, ref string Error, string modo)
        {
            string sql = "";

            sql = "EXEC ACTempleado '" +
                                   ii_EEmpleado.id_empleado + "','" +
                                   ii_EEmpleado.id_tercero_empleado + "','" +
                                   ii_EEmpleado.id_t_empleado + "','" +
                                   ii_EEmpleado.fecha_i_empleado + "','" +
                                   ii_EEmpleado.estado_empleado + "','" +
                                   modo.Trim().ToUpper() + "'";


            if (Conexion.Inserta_Datos(sql, ref Error))
            {
                return true;
            }

            return false;
        }

        public static bool Inserta_Cliente(Clases.ECliente ii_ECliente, ref string Error, string modo)
        {
            string sql = "";
            sql = "EXEC ACTCliente '" +
                                   ii_ECliente.ID_CLIENTE + "','" +
                                   ii_ECliente.ID_TERCERO_CLIENTE + "','" +
                                   ii_ECliente.ID_T_CLIENTE + "','" +
                                   ii_ECliente.LIM_CRED_CLIENTE + "','" +
                                   ii_ECliente.ESTADO_CLIENTE + "','" +
                                   modo.Trim().ToUpper() + "'";

            if (Conexion.Inserta_Datos(sql, ref Error))
            {
                return true;
            }

            return false;
        }
        public static Clases.EServicio Lee_Servicio(string id)
        {
            string sql = "";
            Clases.EServicio ii_EServicio = new Clases.EServicio();
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  Cama  WHERE id_Cama = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ii_EServicio.id_servicio = id;
                ii_EServicio.descr_servicio = DS.Tables[0].Rows[0]["descr_servicio"].ToString();
                ii_EServicio.costo_servicio = decimal.Parse(DS.Tables[0].Rows[0]["costo_servicio"].ToString());
                ii_EServicio.estado_servicio = DS.Tables[0].Rows[0]["estado_servicio"].ToString();

                return ii_EServicio;

            }
            return null;

        }
        public static Clases.ETemporada Lee_Temporada(string id)
        {
            string sql = "";
            Clases.ETemporada ii_ETemporada = new Clases.ETemporada();
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  Temporada  WHERE id_temporada = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ii_ETemporada.id_temporada = id;
                ii_ETemporada.descr_temporada = DS.Tables[0].Rows[0]["descr_temporada"].ToString();
                ii_ETemporada.fecha_i_temporada = DS.Tables[0].Rows[0]["fecha_i_temporada"].ToString();
                ii_ETemporada.fecha_f_temporada = DS.Tables[0].Rows[0]["fecha_f_temporada"].ToString();
                ii_ETemporada.estado_temporada = DS.Tables[0].Rows[0]["estado_temporada"].ToString();

                return ii_ETemporada;

            }
            return null;

        }
        public static string Lee_Descr_Tipo_Telefono(string id)
        {
            string sql = "";
            DataSet DS = new DataSet();
            string Error = "";


            sql = "  SELECT DESCR_TIPO_T from  TIPO_TELEFONO WHERE  ID_TIPO_T = '" + id + "' AND ESTADO_TIPO_T='A'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {

                return DS.Tables[0].Rows[0]["DESCR_TIPO_T"].ToString().ToUpper();

            }
            return "";

        }
        public static string Lee_Descr_Tipo_Email(string id)
        {
            string sql = "";
            DataSet DS = new DataSet();
            string Error = "";


            sql = "  SELECT DESCR_TIPO_E from  TIPO_EMAIL WHERE  ID_TIPO_E = '" + id + "' AND ESTADO_TIPO_E='A'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {

                return DS.Tables[0].Rows[0]["DESCR_TIPO_E"].ToString().ToUpper();

            }
            return "";

        }
        public static Clases.EDireccion Lee_Direccion_Tercero(string id_tercero)
        {
            Clases.EDireccion ii_EDireccion = new Clases.EDireccion();
            string Error = "";
            DataSet ds = new DataSet();
            try
            {
                string consulta = " select id_Tercero_Direccion,id_mun_Direccion,Direccion,ESTADO_DIRECCION,TIPO_DIRECCION, " +
                                  "        N_LINEA_DIRECCION,id_provincia,id_pais from DIRECCION,MUNICIPIO,PROVINCIA,PAIS   " +
                                  " where id_mun_Direccion=id_municipio and " +
                                  "       id_prov_municipio=id_provincia and " +
                                  "       id_pais_provincia=id_pais and " +
                                  "       id_Tercero_Direccion='" + id_tercero.Trim() + "'";
                ds = Conexion.EjecutaSQL(consulta, ref Error);
                if (ds.Tables.Count > 0)
                {
                    ii_EDireccion.id_Tercero_Direccion = ds.Tables[0].Rows[0]["id_Tercero_Direccion"].ToString().Trim();
                    ii_EDireccion.id_mun_Direccion = ds.Tables[0].Rows[0]["id_mun_Direccion"].ToString().Trim();
                    ii_EDireccion.Direccion = ds.Tables[0].Rows[0]["Direccion"].ToString().Trim();
                    ii_EDireccion.ESTADO_DIRECCION = ds.Tables[0].Rows[0]["ESTADO_DIRECCION"].ToString().Trim();
                    ii_EDireccion.TIPO_DIRECCION = ds.Tables[0].Rows[0]["TIPO_DIRECCION"].ToString().Trim();
                    ii_EDireccion.N_LINEA_DIRECCION = Int16.Parse(ds.Tables[0].Rows[0]["N_LINEA_DIRECCION"].ToString().Trim());
                    ii_EDireccion.id_Pais_Direccion = ds.Tables[0].Rows[0]["id_pais"].ToString().Trim();
                    ii_EDireccion.id_Provincia_Direccion = ds.Tables[0].Rows[0]["id_provincia"].ToString().Trim();

                    return ii_EDireccion;
                }

            }
            catch (Exception e)
            {
                Error = e.Message.ToString();
            }
            return null;
        }
        public static List<Clases.EEmail> Lee_Email_Tercero(int Tercero)
        {
            List<Clases.EEmail> ii_LETercero = new List<Clases.EEmail>();
            Clases.EEmail ii_ETercero = new Clases.EEmail();
            DataSet DS = new DataSet();
            string Error = "";
            string sql = "  SELECT id_Tercero_Email,Email,TIPO_Email from EMAIL " +
                         "     WHERE id_Tercero_Email = " + Tercero;

            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    ii_ETercero = new Clases.EEmail();
                    ii_ETercero.id_Tercero_Email = DS.Tables[0].Rows[i]["id_Tercero_Email"].ToString();
                    ii_ETercero.Email = DS.Tables[0].Rows[i]["Email"].ToString();
                    ii_ETercero.TIPO_Email = DS.Tables[0].Rows[i]["Tipo_Email"].ToString().ToUpper();
                    ii_LETercero.Add(ii_ETercero);
                }
                return ii_LETercero;
            }
            return null;

        }
        public static List<Clases.ETelefono> Lee_Telefono_Tercero(int Tercero)
        {
            List<Clases.ETelefono> ii_LETelefono = new List<Clases.ETelefono>();
            Clases.ETelefono ii_ETelefono = new Clases.ETelefono();
            DataSet DS = new DataSet();
            string Error = "";

            string sql = "  SELECT id_Tercero_Tel,Numero_Tel,TIPO_Tel from TELEFONO " +
                        "     WHERE id_Tercero_Tel = " + Tercero;

            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    ii_ETelefono = new Clases.ETelefono();
                    ii_ETelefono.id_Tercero_Tel = DS.Tables[0].Rows[i]["id_Tercero_Tel"].ToString();
                    ii_ETelefono.Numero_Tel = DS.Tables[0].Rows[i]["Numero_Tel"].ToString();
                    ii_ETelefono.TIPO_Tel = DS.Tables[0].Rows[i]["TIPO_Tel"].ToString().ToUpper();
                    ii_LETelefono.Add(ii_ETelefono);
                }
                return ii_LETelefono;
            }
            return null;

        }
        public static List<Clases.Ethab_caracteristica> Lee_Caracteristicas_THabitacion(string id)
        {
            List<Clases.Ethab_caracteristica> ii_LECarTH = new List<Clases.Ethab_caracteristica>();
            Clases.Ethab_caracteristica ii_ECarTH = new Clases.Ethab_caracteristica();
            DataSet DS = new DataSet();
            string Error = "";
            string sql = "  SELECT * from thab_caracteristica WHERE id_t_hab_thcar = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    ii_ECarTH = new Clases.Ethab_caracteristica();
                    ii_ECarTH.id_t_hab_thcar = DS.Tables[0].Rows[i]["id_t_hab_thcar"].ToString();
                    ii_ECarTH.id_caracteristica_thcar = DS.Tables[0].Rows[i]["id_caracteristica_thcar"].ToString();

                    ii_LECarTH.Add(ii_ECarTH);
                }
                return ii_LECarTH;
            }
            return null;

        }
        public static bool Inserta_Caracteristicas_THabitacion(List<Clases.Ethab_caracteristica> ii_LEthab_caracteristica, ref string Error)
        {
            string sql = "";
            sql = "DELETE thab_caracteristica WHERE id_t_hab_thcar='" + ii_LEthab_caracteristica[0].id_t_hab_thcar + "'";
            if (!Conexion.Inserta_Datos(sql, ref Error))
            {
                return false;
            }
            int ii = 0;
            foreach (var dato in ii_LEthab_caracteristica)
            {
                sql = "EXEC ACTthab_caracteristica '" + dato.id_t_hab_thcar + "','" +
                                    dato.id_caracteristica_thcar + "'";
                if (!Conexion.Inserta_Datos(sql, ref Error))
                {
                    return false;
                }
                ii++;
            }
            return true;
        }
        public static Clases.ETipoAlojamiento Lee_TipoAlojamiento(string id)
        {
            string sql = "";
            Clases.ETipoAlojamiento ii_ETipoAlojamiento = new Clases.ETipoAlojamiento();
            DataSet DS = new DataSet();
            string Error = "";

            sql = "  SELECT * from  tipo_alojamiento  WHERE id_t_alojamiento = '" + id + "'";
            DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
                ii_ETipoAlojamiento.id_t_alojamiento = id;
                ii_ETipoAlojamiento.descr_t_alojamiento = DS.Tables[0].Rows[0]["descr_t_alojamiento"].ToString();
                ii_ETipoAlojamiento.costo_t_alojamiento = decimal.Parse(DS.Tables[0].Rows[0]["costo_t_alojamiento"].ToString());
                ii_ETipoAlojamiento.estado_t_alojamiento = DS.Tables[0].Rows[0]["estado_t_alojamiento"].ToString();

                return ii_ETipoAlojamiento;

            }
            return null;

        }
        public static Clases.ETipoUsuario Lee_TipoUsuario(string id)
        {
            Clases.ETipoUsuario aa_ETipo_Usuario = new Clases.ETipoUsuario();
            string sql = "SELECT * FROM Tipo_Usuario where id_T_Usuario='" + id + "'";

            string Error = "";
            DataSet DS = Conexion.EjecutaSQL(sql, ref Error);
            if (DS.Tables[0].Rows.Count > 0)
            {
               int i = 0;
                aa_ETipo_Usuario = new Clases.ETipoUsuario();
                aa_ETipo_Usuario.id_T_Usuario = DS.Tables[0].Rows[i]["id_T_Usuario"].ToString();
                aa_ETipo_Usuario.Descripcion_T_Usuario = DS.Tables[0].Rows[i]["Descripcion_T_Usuario"].ToString();
                aa_ETipo_Usuario.Estado_T_Usuario = DS.Tables[0].Rows[i]["Estado_T_Usuario"].ToString();
                aa_ETipo_Usuario.Nivel_Acceso_T_Usuario = DS.Tables[0].Rows[i]["Nivel_Acceso_T_Usuario"].ToString();


                return aa_ETipo_Usuario;


            }

            return null;

        }

    }
}
