using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzanieBudynkiem
{
    public class CPracownik
    {
        protected string imie;
        protected string nazwisko;
        protected string email;
        protected string login;
        protected string haslo;
        protected string pesel;

        public List<CTablicaRejestracyjna> tabliceRejestracyjne = new List<CTablicaRejestracyjna>();

        public CPracownik()
        {
            this.imie = "Jan";
            this.nazwisko = "Kowalski";
            this.email = "jan.kowalski@gmail.com";
            this.login = "JanKowalski";
            this.haslo = "haslo";
            this.pesel = "12345678910";
        }

        public CPracownik(string imie, string nazwisko, string email, string login, string haslo, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.email = email;
            this.login = login;
            this.haslo = haslo;
            this.pesel = pesel;
        }

        public string ZwrocImie() { return this.imie; }
        public string ZwrocNazwisko() { return this.nazwisko; }
        public string ZwrocEmail() { return this.email; }
        public string ZwrocLogin() { return this.login; }
        public string ZwrocHaslo() { return this.haslo; }
        public string ZwrocPesel() { return this.pesel; }

    }
}
