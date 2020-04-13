using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistHoteleria
{
    public class Clases
    {
        //NOTA PARA MODOS--->
        //A=CREAR
        //M=MODIFICAR
        //C=CONSULTAR
        //D=DETALLE
        //E=ENCADENAR
        //PARA NIVELES -->
        //A=ADMI
        //E=ENCARGADO
        //U=USUARIO NORMAL
        //O=OBSERVADOR
        public static string Usuario = "";
        public static string Nivel_Acceso = "";
        public static string Nombre_Hotel = "";
        public class ETipo
        {
            public string id = "";
            public string descripcion = "";
            public string estado = "";
            public bool Tipo_PK_int = true;
        }
        public class EProvincia
        {
            public string id_provincia = "";
            public string descr_provincia = "";
            public string estado_provincia = "";
            public string id_pais_provincia = "";

        }
        public class EMunicipio
        {
            public string id_municipio = "";
            public string descr_municipio = "";
            public string estado_municipio = "";
            public string id_prov_municipio = "";

        }
        public class ETipo_Usuario
        {
            public string id_T_Usuario = "";
            public string Descripcion_T_Usuario = "";
            public string Estado_T_Usuario = "";
            public string Nivel_Acceso_T_Usuario = "";

        }
        public class ETipo_Identificacion
        {
            public string Id_Tipo_Ident = "";
            public string Descr_Tipo_Ident = "";
            public string Estado_Tipo_Ident = "";

        }

        public class EUsuario
        {
            public string id_Usuario = "";
            public string id_Tercero_Usuario = "";
            public string Estado_Usuario = "";
            public string id_Tipo_Usuario = "";
            public string Password_Usuario = "";
            public string nivel = "";

        }
        public class ETercero
        {
            public string id_Tercero = "";
            public string Nombre_Tercero = "";
            public string ID_T_Identif_Tercero = "";
            public string Cedula_Tercero = "";
            public string Fecha_Nac_Tercero = "";
            public string Estado_Tercero = "";
            public string Sexo_Tercero = "";

        }
        public class ETelefono
        {
            public string id_Tercero_Tel = "";
            public string Numero_Tel = "";
            public string TIPO_Tel = "";
            public string descr_tipo = "";
            public string ESTADO_Tel = "";
            public int N_LINEA_Tel = 0;


        }
        public class EEmail
        {
            public string id_Tercero_Email = "";
            public string Email = "";
            public string TIPO_Email = "";
            public string descr_tipo = "";
            public string ESTADO_Email = "";
            public int    N_LINEA_Email = 0;

        }
        public class EDireccion
        {
            public string id_Tercero_Direccion = "";
            public string id_mun_Direccion = "";
            public string Direccion = "";
            public string ESTADO_DIRECCION = "";
            public string TIPO_DIRECCION = "";
            public int N_LINEA_DIRECCION = 0;
            public string id_Pais_Direccion = "";
            public string id_Provincia_Direccion = "";


        }
        public class ECama
        {
            public string id_cama = "";
            public string descr_cama = "";
            public int capacidad_cama = 0;
            public string estado_cama = "";
           

        }
        public class EHabitacion
        {
            public string id_habitacion = "";
            public string descr_habitacion = "";
            public string t_habitacion = "";
            public string edificio_habitacion = "";
            public int piso_habitacion = 0;
            public string estado_habitacion = "";


        }
        public class ETHabitacion
        {
            public string id_t_hab = "";
            public string descr_t_hab = "";
            public string capacidad_hab = "";
            public string costo_hab = "";
            public string estado_t_hab = "";

      
        }
        public class EEdificio
        {
            public string id_edificio = "";
            public string descr_edificio = "";
            public int cant_nivel_edificio = 0;
            public string estado_edificio = "";


        }
        public class EEmpleado
        {
            public string id_empleado = "";
            public string id_tercero_empleado= "";
            public string id_t_empleado = "";
            public string fecha_i_empleado = "";
            public string estado_empleado = "";
	

        }
        public class ECliente
        {
            public string ID_CLIENTE = "";
            public string ID_TERCERO_CLIENTE = "";
            public string ID_T_CLIENTE = "";
            public decimal LIM_CRED_CLIENTE = 0;
            public string ESTADO_CLIENTE = "";


        }
        public class EServicio
        {
            public string id_servicio = "";
            public string descr_servicio = "";
            public decimal costo_servicio = 0;
            public string estado_servicio = "";


        }
    }
}
