using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzanieBudynkiem
{
    public class CLicznik
    {
        private int idLicznika;
        private List<CZuzycieDnia> listaZuzyc = new List<CZuzycieDnia>();
        
        public CLicznik(int idLicznika)
        {
            this.idLicznika = idLicznika;
            this.listaZuzyc.Add(new CZuzycieDnia(new DateTime(2023, 02, 04), 20, 20, 20));
            this.listaZuzyc.Add(new CZuzycieDnia(new DateTime(2023, 02, 03), 20, 20, 20));
            this.listaZuzyc.Add(new CZuzycieDnia(new DateTime(2023, 02, 02), 20, 20, 20));
            this.listaZuzyc.Add(new CZuzycieDnia(new DateTime(2023, 02, 01), 20, 20, 20));
            this.listaZuzyc.Add(new CZuzycieDnia(new DateTime(2023, 01, 31), 20, 20, 20));
        }
        public float ObliczZuzycieCiepla(DateTime odKiedy, DateTime doKiedy)
        {
            float obliczoneZuzycie = 0;
            foreach(var zuzycie in this.listaZuzyc)
                if(zuzycie.zwrocDzienZuzycia() >= odKiedy && zuzycie.zwrocDzienZuzycia() <= doKiedy)
                {
                    obliczoneZuzycie += zuzycie.zwrocIloscZuzyciaCiepla();
                }
            return obliczoneZuzycie;
        }
        public float ObliczZuzyciePradu(DateTime odKiedy, DateTime doKiedy)
        {
            float obliczoneZuzycie = 0;
            foreach (var zuzycie in this.listaZuzyc)
                if (zuzycie.zwrocDzienZuzycia() >= odKiedy && zuzycie.zwrocDzienZuzycia() <= doKiedy)
                {
                    obliczoneZuzycie += zuzycie.zwrocIloscZuzyciaPradu();
                }
            return obliczoneZuzycie;
        }
        public float ObliczZuzycieWody(DateTime odKiedy, DateTime doKiedy)
        {
            float obliczoneZuzycie = 0;
            foreach (var zuzycie in this.listaZuzyc)
                if (zuzycie.zwrocDzienZuzycia() >= odKiedy && zuzycie.zwrocDzienZuzycia() <= doKiedy)
                {
                    obliczoneZuzycie += zuzycie.zwrocIloscZuzyciaWody();
                }
            return obliczoneZuzycie;
        }
    }
}
