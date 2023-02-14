using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzanieBudynkiem
{
    public class CZuzycieDnia
    {
        private DateTime dzienZuzycia;
        private float zuzycieCiepla;
        private float zuzyciePradu;
        private float zuzycieWody;

        public CZuzycieDnia(DateTime dzienZuzycia, float zuzycieCiepla, float zuzyciePradu, float zuzycieWody)
        {
            this.dzienZuzycia = dzienZuzycia;
            this.zuzycieCiepla = zuzycieCiepla;
            this.zuzyciePradu = zuzyciePradu;
            this.zuzycieWody = zuzycieWody;
        }

        public DateTime zwrocDzienZuzycia() { return this.dzienZuzycia; }
        public float zwrocIloscZuzyciaCiepla() { return this.zuzycieCiepla; }
        public float zwrocIloscZuzyciaPradu() { return this.zuzyciePradu; }
        public float zwrocIloscZuzyciaWody() { return this.zuzycieWody; }
    }
}
