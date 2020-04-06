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
            string sql = "  SELECT * from  PAIS WHERE  id_pais = " + id + " and " +
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

            sql = "  SELECT * from  PROVINCIA  WHERE id_provincia = " + id;
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

            sql = "  SELECT * from  PROVINCIA  WHERE id_provincia = " + id;
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

            sql = "  SELECT * from  Municipio  WHERE id_Municipio = " + id;
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

            sql = "  SELECT * from  Municipio  WHERE id_Municipio = " + id;
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
                string consulta = "select * from Tercero where id_Tercero='" + id_tercero.Trim() +"'";
                ds =Conexion.EjecutaSQL(consulta, ref Error);
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
            if (modo.Trim().ToUpper() == "A")
            {
                sql = "INSERT INTO USUARIO VALUES('" + 
                                    ii_EUsuario.id_Usuario + "','" +
                                    ii_EUsuario.id_Tercero_Usuario + "','" +
                                    ii_EUsuario.id_Tipo_Usuario + "','" +
                                    ii_EUsuario.Password_Usuario + "','" +
                                    ii_EUsuario.Estado_Usuario + "')";
            }
            else
            {
                sql = " UPDATE Usuario SET Estado_Usuario='" + ii_EUsuario.Estado_Usuario + "'," +
                                        "Tipo_Usuario='" + ii_EUsuario.id_Tipo_Usuario + "'," +
                                        "Password_Usuario='" + ii_EUsuario.Password_Usuario + "'" +
                    " WHERE id_Usuario='" + ii_EUsuario.id_Usuario + "'";
            }

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
                ds =Conexion.EjecutaSQL(consulta, ref Error);
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
            if (ii_ETercero.id_Tercero.Trim() != "")
            {
                ID = int.Parse(ii_ETercero.id_Tercero);
                sql = " UPDATE Tercero SET Nombre_Tercero='" + ii_ETercero.Nombre_Tercero.ToUpper() + "'," +
                    "                    ID_T_Identif_Tercero='" + ii_ETercero.ID_T_Identif_Tercero + "'," +
                    "                    Cedula_Tercero='" + ii_ETercero.Cedula_Tercero + "'," +
                    "                    Fecha_Nac_Tercero='" + ii_ETercero.Fecha_Nac_Tercero + "'," +
                    "                    Estado_Tercero='" + ii_ETercero.Estado_Tercero + "'," +
                    "                    Sexo_Tercero='" + ii_ETercero.Sexo_Tercero + "'" +
                    " WHERE id_Tercero='" + ii_ETercero.id_Tercero + "'";
            }
            else
            {
                ID = funciones.Genera_Codigo_Numerico("Tercero", "id_Tercero");

                sql = "INSERT INTO  Tercero VALUES(" + ID + ",'" +
                                        ii_ETercero.Nombre_Tercero + "','" +
                                        ii_ETercero.ID_T_Identif_Tercero + "','" +
                                        ii_ETercero.Cedula_Tercero + "','" +
                                        ii_ETercero.Fecha_Nac_Tercero + "','" +
                                        ii_ETercero.Sexo_Tercero + "'," +
                                        "'A')";
            }
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
                sql = "INSERT INTO TELEFONO VALUES('" + Tel.id_Tercero_Tel + "','" +
                                    Tel.Numero_Tel + "','" +
                                    Tel.TIPO_Tel + "'," +
                                    ii +","+
                                    "'A')";
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
                sql = "INSERT INTO EMAIL VALUES('" + Email.id_Tercero_Email + "','" +
                                    Email.Email + "','" +
                                    Email.TIPO_Email + "'," +
                                    ii+","+
                                    "'A')";
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
            sql = "INSERT INTO DIRECCION VALUES('" + ii_EDireccion.id_Tercero_Direccion + "','" +
                                                    ii_EDireccion.id_mun_Direccion + "','" +
                                                    ii_EDireccion.Direccion + "','" +
                                                    ii_EDireccion.TIPO_DIRECCION + "'," +
                                                    ii_EDireccion.N_LINEA_DIRECCION + ",'A')";
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
                ds =Conexion.EjecutaSQL(consulta, ref Error);
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
                ds =Conexion.EjecutaSQL(consulta, ref Error);
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

            sql = "  SELECT * from  Cama  WHERE id_Cama = '" + id +"'";
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
      
        public static Clases.EHabitacion Lee_Habitacion (string id)
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
            if (modo.Trim().ToUpper() == "A")
            {
                sql = "INSERT INTO empleado VALUES('" +
                                    ii_EEmpleado.id_empleado + "','" +
                                    ii_EEmpleado.id_tercero_empleado + "','" +
                                    ii_EEmpleado.id_t_empleado + "','" +
                                    ii_EEmpleado.fecha_i_empleado + "','" +
                                    ii_EEmpleado.estado_empleado + "')";
            }
            else
            {
                sql = " UPDATE empleado SET id_tercero_empleado='" + ii_EEmpleado.id_tercero_empleado + "'," +
                                        "id_t_empleado='" + ii_EEmpleado.id_t_empleado + "'," +
                                        "fecha_i_empleado='" + ii_EEmpleado.fecha_i_empleado + "'," +
                                        "estado_empleado='" + ii_EEmpleado.estado_empleado + "'" +
                    " WHERE id_empleado='" + ii_EEmpleado.id_empleado + "'";
            }

            if (Conexion.Inserta_Datos(sql, ref Error))
            {
                return true;
            }

            return false;
        }
    }
}
