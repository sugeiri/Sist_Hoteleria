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
        public class ETipo
        {
            public string id = "";
            public string descripcion = "";
            public string estado = "";
            public bool Tipo_PK_int = true;
        }
    }
}
