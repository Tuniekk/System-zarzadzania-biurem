using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzanieBudynkiem
{
    public class CMiejsceParkingoweBiurowe
    {
        private int numer;
        private int numerPietra;
        private bool stanMiejsca;
        private CPracownikAdministracyjny zajmujacyMiejsce = null;
        public CMiejsceParkingoweBiurowe(int numer, int numerPietra, bool stanMiejsca)
        {
            this.numer = numer;
            this.numerPietra = numerPietra;
            this.stanMiejsca = stanMiejsca;
        }
        public int zwrocNumerPietra() { return this.numerPietra; }
        public int zwrocNumer() { return this.numer; }
        public bool zwrocStanMiejsca() { return this.stanMiejsca; }
        public CPracownikAdministracyjny zwrocZajmujacegoMiejsce() { return this.zajmujacyMiejsce; }

        public void zmienWlasciciela(CPracownikAdministracyjny pracownik)
        {
            this.zajmujacyMiejsce = pracownik;
            if (this.zajmujacyMiejsce == null)
                stanMiejsca = false;
            else
                stanMiejsca = true;
        }
    }
}
