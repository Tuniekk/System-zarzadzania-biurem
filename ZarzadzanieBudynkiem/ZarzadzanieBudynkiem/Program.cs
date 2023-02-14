using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarzadzanieBudynkiem
{
    internal static class Program
    {
        public static CPracownikAdministracyjny pracownikAdministracyjny = new CPracownikAdministracyjny("12345678910", "Jan", "Kowalski", "jan.kowalski@gmail.com", "Admin", "Admin");
        public static CBiuro biuro1 = new CBiuro("CeglaCompany");
        public static CParkingBiura parking1 = new CParkingBiura(10);
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {     
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CEkranLogowania());
        }
    }
}
