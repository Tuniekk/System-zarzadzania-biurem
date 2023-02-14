using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzanieBudynkiem
{
    public class CPracownikAdministracyjny : CPracownik
    {
        /* dziedziczone po CPracownik
        private string pesel;
        private string imie;
        private string nazwisko;
        private string email;
        private string login;
        private string haslo;
        public List<CTablicaRejestracyjna> tabliceRejestracyjne = new List<CTablicaRejestracyjna>();
        */

        public CPracownikAdministracyjny(string pesel, string imie, string nazwisko, string email, string login, string haslo)
        {
            this.pesel = pesel;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.email = email;
            this.login = login;
            this.haslo = haslo;
            this.tabliceRejestracyjne.Add(new CTablicaRejestracyjna("W", "OJ", "TEK12"));
        }
        /* dziedziczone po CPracownik
        public string ZwrocPesel() { return this.pesel; }
        public string ZwrocImie() { return this.imie; }
        public string ZwrocNazwisko() { return this.nazwisko; }
        public string ZwrocEmail() { return this.email; }
        public string ZwrocLogin() { return this.login; }
        public string ZwrocHaslo() { return this.haslo; }
        */
    }
}
