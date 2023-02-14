using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzanieBudynkiem
{
    public class CTablicaRejestracyjna
    {
        private string wyroznikWojewodztwa;
        private string wyroznikPowiatu;
        private string wyroznikPojazdu;

        public CTablicaRejestracyjna(string wyroznikWojewodztwa, string wyroznikPowiatu, string wyroznikPojazdu)
        {
            this.wyroznikWojewodztwa = wyroznikWojewodztwa;
            this.wyroznikPowiatu = wyroznikPowiatu;
            this.wyroznikPojazdu = wyroznikPojazdu;
        }

        public string zwrocWyroznikWojewodztwa() { return this.wyroznikWojewodztwa; }
        public string zwrocWyroznikPowiatu() { return this.wyroznikPowiatu; }
        public string zwrocWyroznikPojazdu() { return this.wyroznikPojazdu; }
        public string zwrocTabliceRejestracyjna() { return this.wyroznikWojewodztwa + this.wyroznikPowiatu + this.wyroznikPojazdu; }
    }
}
