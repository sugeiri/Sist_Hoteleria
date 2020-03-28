using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistHoteleria
{
    public class Conexion
    {
        private static string ConnectionString = "";
        //@"Persist Security Info=False;User ID = sa; Password=971223;Initial Catalog = db_Sist_co; Server=QJM_SUGEIRI;database=db_Sist_co";
        static SqlConnection conexion = new SqlConnection();
        static string Database = "db_hotel";
        static string Usuario = "SistHot";
        static string Pass = "971223";
        static string Server = "QJM_SUGEIRI";
        public static SqlConnection OpenC(ref string Error)
        {
            ConnectionString = @"Persist Security Info=False;User ID = " + Usuario + "; Password=" + Pass + ";Initial Catalog = " + Database + "; Server=" + Server + ";database=" + Database + "";

            conexion = new SqlConnection(ConnectionString);
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                Error = ex.Message.ToString();

            }
            finally
            {
                conexion.Close();
            }
            return conexion;


        }
        public static DataSet EjecutaSQL(string Sql, ref string Error)
        {

            DataSet dt = new DataSet();
            try
            {
                  string consulta = Sql;
                SqlCommand comando = new SqlCommand(consulta, OpenC(ref Error));
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(dt);
                OpenC(ref Error).Close();
                return dt;
            }
            catch (Exception e)
            {
                Error = e.Message.ToString();
            }
            return dt;
        }
        public static string Encriptar(string dato)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(dato);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public static string DesEncriptar(string dato)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(dato);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        public static bool Inserta_Datos(string SQl, ref string Error)
        {

            using (var Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Connection.Open();
                    var Command = Connection.CreateCommand();
                    Command.CommandText = SQl;

                    try
                    {
                        Command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex_01)
                    {
                        Error = ex_01.Message;
                        return false;
                    }
                }
                catch (Exception ex_01)
                {
                    Error = ex_01.Message;
                    return false;
                }
            }

        }
    }
}
