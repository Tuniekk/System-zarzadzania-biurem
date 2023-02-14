using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarzadzanieBudynkiem
{
    public partial class CEkranZarzadzaniaTablicamiRejestracyjnymi : Form
    {
        public CTablicaRejestracyjna wybranaTablica = new CTablicaRejestracyjna("0", "0", "00000");
        public CEkranZarzadzaniaTablicamiRejestracyjnymi()
        {
            InitializeComponent();
        }
        public CEkranZarzadzaniaTablicamiRejestracyjnymi(CTablicaRejestracyjna wybranaTablica)
        {
            this.wybranaTablica = wybranaTablica;
            InitializeComponent();
        }
        private void utworzEkranTablicRejestracyjnych()
        {
            this.Hide();
            CEkranTablicRejestracyjnych ekranTR = new CEkranTablicRejestracyjnych();
            ekranTR.ShowDialog();
            this.Close();
        }
        private bool sprawdzCzyJestNaLiscie(string nowaTablica)
        {
            bool czyJest = false;
            foreach (var tablica in Program.pracownikAdministracyjny.tabliceRejestracyjne)
                if (nowaTablica == tablica.zwrocTabliceRejestracyjna())
                    czyJest = true;
            return czyJest;
        }
        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.utworzEkranTablicRejestracyjnych();
        }

        private void buttonUsunTabliceZListy_Click(object sender, EventArgs e)
        {
            var potwierdzUsuniecie = MessageBox.Show("Czy jesteś pewien, że chcesz usunąć wybraną tablicę ze swojej listy?", "Potwierdzenie działania", MessageBoxButtons.YesNo);
            if (potwierdzUsuniecie == DialogResult.Yes)
            {
                Program.pracownikAdministracyjny.tabliceRejestracyjne.Remove(wybranaTablica);
                this.utworzEkranTablicRejestracyjnych();
            }
        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            string nowaTablica = this.textBoxNowaTablicaRejestracyjna.Text;
            if (this.sprawdzCzyJestNaLiscie(nowaTablica) == true)
                this.textBoxKomunikatOBledzie.Text = "Podana tablica znajduje się już na liście.";
            else if (nowaTablica.Length == 7)
            {
                Program.pracownikAdministracyjny.tabliceRejestracyjne.Add(new CTablicaRejestracyjna(nowaTablica[0].ToString(), nowaTablica[1].ToString(), nowaTablica[2].ToString() + nowaTablica[3] + nowaTablica[4] + nowaTablica[5] + nowaTablica[6]));
                Program.pracownikAdministracyjny.tabliceRejestracyjne.Remove(this.wybranaTablica);
                this.utworzEkranTablicRejestracyjnych();
            }
            else if (nowaTablica.Length == 8)
            {
                Program.pracownikAdministracyjny.tabliceRejestracyjne.Add(new CTablicaRejestracyjna(nowaTablica[0].ToString(), nowaTablica[1].ToString() + nowaTablica[2].ToString(), nowaTablica[3].ToString() + nowaTablica[4] + nowaTablica[5] + nowaTablica[6] + nowaTablica[7]));
                Program.pracownikAdministracyjny.tabliceRejestracyjne.Remove(this.wybranaTablica);
                this.utworzEkranTablicRejestracyjnych();
            }
            else
            {
                this.textBoxKomunikatOBledzie.Text = "Zły format tablicy.";
            }
        }
    }
}
