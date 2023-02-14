using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzanieBudynkiem
{
    public class CPomieszczenie
    {
        private int numer;
        private float obecnaTemperatura;
        private float minTemperatura;
        private float maxTemperatura;
        private int wielkosc;

        public CLicznik licznikPomieszczenia = new CLicznik(1);
        public List<CRolety> listaRolet = new List<CRolety>();

        public CPomieszczenie(int numer, float obecnaTemperatura, int wielkosc)
        {
            this.numer = numer;
            this.maxTemperatura = 26;
            this.minTemperatura = 16;
            this.obecnaTemperatura = obecnaTemperatura;
            this.wielkosc = wielkosc;
            this.listaRolet.Add(new CRolety(1, 0));
            this.listaRolet.Add(new CRolety(2, 0));
        }

        public int ZwrocNumer() { return this.numer; }
        public float ZwrocObacnaTemperature() { return this.obecnaTemperatura; }
        public int ZwrocWielkosc() { return this.wielkosc; }
        public float ZwrocMinTemperature() { return this.minTemperatura; }
        public float ZwrocMaxTemperature() { return this.maxTemperatura; }

        public void ZmienTemperature(float nowaTemperatura)
        {
            this.obecnaTemperatura = nowaTemperatura;
        }

    }
}
