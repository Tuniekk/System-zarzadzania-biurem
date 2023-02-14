using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzanieBudynkiem
{
    public class CParkingBiura
    {
        private int liczbaMiejsc;
        public List<CMiejsceParkingoweBiurowe> listaMiejsc = new List<CMiejsceParkingoweBiurowe>();

        public CParkingBiura(int liczbaMiejsc)
        {
            this.liczbaMiejsc = liczbaMiejsc;
            for (int i = 1; i < this.liczbaMiejsc/2; i++)
                listaMiejsc.Add(new CMiejsceParkingoweBiurowe(i+20, 1, false));
            for (int i = this.liczbaMiejsc / 2; i <= this.liczbaMiejsc/2;i++)
                listaMiejsc.Add(new CMiejsceParkingoweBiurowe(i+20, 1, true));
        }

        public int zwrocLiczbeMiejsc() { return this.liczbaMiejsc; }
    }
}
