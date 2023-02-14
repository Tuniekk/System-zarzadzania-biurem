using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzanieBudynkiem
{
    public class CRolety
    {
        private int numer;
        private float poziomWysuniecia;

        public CRolety(int numer, float poziomWysuniecia)
        {
            this.numer = numer;
            this.poziomWysuniecia = poziomWysuniecia;
        }

        public int zwrocNumer() { return this.numer; }
        public float zwrocPoziomWysuniecia() { return this.poziomWysuniecia; }
        public void zmienPoziomWysuniecia(float nowyPoziom)
        {
            this.poziomWysuniecia = nowyPoziom;
        }
    }
}
