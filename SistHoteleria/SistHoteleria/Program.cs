using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistHoteleria
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] aa_Parametro = new string[2];
            aa_Parametro[0] = "";
            aa_Parametro[1] = "";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new menu());
           Application.Run(new Login(ref aa_Parametro));
            if (aa_Parametro[0].Trim() != "")
            {
                Clases.Usuario = aa_Parametro[0];
                Clases.Nivel_Acceso = aa_Parametro[1];
                var New_Pant = new menu();
                New_Pant.ShowDialog();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
