using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzanieBudynkiem
{
    public class CBiuro
    {
        private string nazwa;
        public List<CPomieszczenie> listaPomieszczen = new List<CPomieszczenie>();
        public CBiuro(string nazwa)
        {
            this.nazwa = nazwa;
            listaPomieszczen.Add(new CPomieszczenie(1, 20, 15));
            listaPomieszczen.Add(new CPomieszczenie(2, 22, 20));
            listaPomieszczen.Add(new CPomieszczenie(3, 25, 30));
            listaPomieszczen.Add(new CPomieszczenie(4, 18, 18));
        }

        public string zwrocNazwa() { return this.nazwa; }
    }
}
